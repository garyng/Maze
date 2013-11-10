using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;

namespace MazeGen
{
    public class MazePrim : Maze
    {
        
        public MazePrim(List<List<Node>> nodes)
            : base(nodes)
        {
        }

        /// <summary>
        /// Initialize a new 2d array of nodes
        /// </summary>
        /// <param name="width"></param>
        /// <param name="height"></param>
        public MazePrim(int width, int height)
            : base(width, height)
        {
        }

        public override void Generate()
        {
            int total = this.Nodes.Count * this.Nodes[0].Count;
            int visited = 1;

            List<Node> frontier = new List<Node>();
            Random r = new Random();

            Node current = this.Nodes[(int)(r.NextDouble() * 10) % this.Nodes.Count][(int)(r.NextDouble() * 50) % this.Nodes[0].Count];
            current.isStart = true;
            for (int i = 0; i < current.Count; i++)
            {
                if (current[i] != null)
                {
                    current[i].parentInfo.Add(new ParentInfo(current, i));
                    frontier.Add(current[i]);
                    current[i].isFrontier = true;
                }
            }

            while (frontier.Count > 0)
            {
                current = frontier[(int)(r.NextDouble() * 10) % frontier.Count];
                current.isFrontier = false;
                frontier.Remove(current);

                //random select a parent
                ParentInfo parentInfo = current.parentInfo[(int)(r.NextDouble() * 15) % current.parentInfo.Count];

                //break the wall
                //0-2 1-3
                parentInfo.Parent.UnWall(parentInfo.Index);
                current.UnWall((parentInfo.Index + 2) % 4);

                //add new frontier
                for (int i = 0; i < current.Count; i++)
                {
                    //not a frontier yet
                    //and no walls destroyed
                    if (current[i] != null && current[i].parentInfo.Count == 0 && current[i].Wall == 0)
                    {
                        frontier.Add(current[i]);
                        current[i].parentInfo.Add(new ParentInfo(current, i));
                        current[i].isFrontier = true;
                    }
                }

                visited++;
                OnProgressChanged(visited, total);
            }

            OnComplete();
        }

        public override string Name
        {
            get
            {
                return "Prim's Algorithm";
            }
        }
    }
}
