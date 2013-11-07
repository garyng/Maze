using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MazeGen
{
    public abstract class Maze
    {
        private List<List<Node>> _nodes = new List<List<Node>>();

        public Maze(List<List<Node>> nodes)
        {
            _nodes = nodes;
        }

        /// <summary>
        /// Initialize a new 2d array of nodes
        /// </summary>
        /// <param name="width"></param>
        /// <param name="height"></param>
        public Maze(int width, int height)
        {
            for (int x = 0; x < width; x++)
            {
                List<Node> nX = new List<Node>();
                for (int y = 0; y < height; y++)
                {
                    Node nY = new Node();
                    if (y > 0)
                    {
                        nY.Up = nX[y - 1];
                        nX[y - 1].Down = nY;
                    }
                    if (x > 0)
                    {
                        nY.Left = _nodes[x - 1][y];
                        _nodes[x - 1][y].Right = nY;
                    }
                    nX.Add(nY);
                }
                _nodes.Add(nX);
            }
        }

        /// <summary>
        /// Visualize nodes
        /// </summary>
        /// <param name="sz">The size of a node</param>
        /// <returns></returns>
        public Bitmap Visualize(Size sz)
        {
            using (Bitmap b = new Bitmap(_nodes.Count*sz.Width+1,_nodes[0].Count*sz.Height+1))
            {
                using (Graphics g = Graphics.FromImage(b))
                {
                    for (int x = 0; x < _nodes.Count; x++)
                    {
                        for (int y = 0; y < _nodes[x].Count; y++)
                        {
                            g.DrawRectangle(Pens.Black, new Rectangle(x * sz.Width, y * sz.Height, sz.Width, sz.Height));
                        }
                    }
              
                };
            };
            return null;
            
        }

        /// <summary>
        /// Generate a new maze
        /// </summary>
        public virtual void Generate()
        {
        }

        /// <summary>
        /// Get the 2d list of nodes
        /// </summary>
        public List<List<Node>> Nodes
        {
            get
            {
                return _nodes;
            }
        }
    }

    public class MazeRec : Maze
    {
        public MazeRec(List<List<Node>> nodes)
            : base(nodes)
        {
        }

        /// <summary>
        /// Initialize a new 2d array of nodes
        /// </summary>
        /// <param name="width"></param>
        /// <param name="height"></param>
        public MazeRec(int width, int height)
            : base(width, height)
        {    
        }

        public override void Generate()
        {
            
        }
    }
}
