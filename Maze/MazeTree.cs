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
    public class MazeTree : Maze
    {
        
        public MazeTree(List<List<Node>> nodes)
            : base(nodes)
        {
        }
        /// <summary>
        /// Initialize a new 2d array of nodes
        /// </summary>
        /// <param name="width"></param>
        /// <param name="height"></param>
        public MazeTree(int width, int height)
            : base(width, height)
        {
        }

        public override void Generate()
        {
            int total = this.Nodes.Count * this.Nodes[0].Count;
            int visited = 1;


            List<Node> cells = new List<Node>();
            Random r = new Random();
            cells.Add(this.Nodes[(int)(r.NextDouble() * 10) % this.Nodes.Count][(int)(r.NextDouble() * 10) % this.Nodes[0].Count]);
            cells[0].isStart = true;

            //Selection method
            //0 = Lastest
            //1 = Oldest
            //2 = Random

            //default = 0
            Func<Node> selMethod = () =>
                        {
                            return cells.Last();
                        };
            switch (this.SelectionMethod)
            {
                case 1:
                    selMethod = () =>
                        {
                            return cells[0];
                        };
                    break;
                case 2:
                    selMethod = () =>
                        {
                            return cells[(int)(r.NextDouble() * 10) % cells.Count];
                        };
                    break;
            }

            while (cells.Count > 0)
            {
                Node current = selMethod();

                //List all available neighbour cells
                List<Node> readyNeighbourCells = new List<Node>();
                //Store the index of the neighbour cells
                List<int> readyNeighbourCellsIndex = new List<int>();
                for (int i = 0; i < current.Count; i++)
                {
                    if (current[i] != null && current[i].Wall == 0)
                    {
                        readyNeighbourCells.Add(current[i]);
                        readyNeighbourCellsIndex.Add(i);
                    }
                }

                //no cells found
                if (readyNeighbourCells.Count == 0)
                {
                    current.isBacktracked = true;
                    cells.Remove(current);
                    OnProgressChanged(visited, total);
                    continue;
                }

                //Random select a cell
                int randIndex = (int)(r.NextDouble() * 10) % readyNeighbourCells.Count;
                int index = readyNeighbourCellsIndex[randIndex];
                Node neighbour = readyNeighbourCells[randIndex];

                // Knock the wall
                // 0-2 1-3
                current.UnWall(index);
                neighbour.UnWall((index + 2) % 4);
                OnProgressChanged(visited, total);
                cells.Add(neighbour);
                visited++;
            }

            OnComplete();
        }

        public override string Name
        {
            get
            {
                return "Growing Tree Algorithm";
            }
        }

    }
}
