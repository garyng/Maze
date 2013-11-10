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
    public abstract class Maze
    {
        public delegate void ProgressChangedEventHandler(int done, int total);
        public delegate void DoneEventHandler();
        public event ProgressChangedEventHandler ProgressChanged;
        public event DoneEventHandler Completed;

        private int _selIndex = 0;
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
                    nY.Pos = new Point(x, y);
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
            Bitmap b = new Bitmap(_nodes.Count * sz.Width + 1, _nodes[0].Count * sz.Height + 1);
            using (Graphics g = Graphics.FromImage(b))
            {
                for (int x = 0; x < _nodes.Count; x++)
                {
                    for (int y = 0; y < _nodes[x].Count; y++)
                    {
                        if (!_nodes[x][y].GetWall(0))
                        {
                            //Up
                            g.DrawLine(Pens.Black, sz.Height * x, sz.Width * y, sz.Height * (x + 1), sz.Width * y);
                        }
                        if (!_nodes[x][y].GetWall(3))
                        {
                            //Left
                            g.DrawLine(Pens.Black, sz.Height * x, sz.Width * y, sz.Height * x, sz.Width * (y + 1));
                        }
                        if (!_nodes[x][y].GetWall(1))
                        {
                            //Right
                            g.DrawLine(Pens.Black, sz.Height * (x + 1), sz.Width * y, sz.Height * (x + 1), sz.Width * (y + 1));
                        }
                        if (!_nodes[x][y].GetWall(2))
                        {
                            //Down
                            g.DrawLine(Pens.Black, sz.Height * x, sz.Width * (y + 1), sz.Height * (x + 1), sz.Width * (y + 1));
                        }
                        if (_nodes[x][y].isBacktracked)
                        {
                            g.FillRectangle(new SolidBrush(Color.FromArgb(100, Color.Pink)), sz.Height * x, sz.Width * y, sz.Width, sz.Height);
                        }
                        if (_nodes[x][y].isFrontier)
                        {
                            g.FillRectangle(new SolidBrush(Color.FromArgb(100, Color.Purple)), sz.Height * x, sz.Width * y, sz.Width, sz.Height);
                        }
                        if (_nodes[x][y].isStart)
                        {
                            g.FillRectangle(new SolidBrush(Color.FromArgb(100, Color.Blue)), sz.Height * x, sz.Width * y, sz.Width, sz.Height);
                        }
                    }

                }
            };
            return b;
        }

        protected virtual void OnProgressChanged(int done, int total)
        {
            if (ProgressChanged != null)
            {
                ProgressChanged(done, total);
            }
        }

        protected virtual void OnComplete()
        {
            if (Completed != null)
            {
                Completed();
            }
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

        public virtual string Name
        {
            get
            {
                return "";
            }
        }

        /// <summary>
        /// For Growing Tree Algorithm
        /// </summary>
        public int SelectionMethod
        {
            get
            {
                return _selIndex;
            }
            set
            {
                _selIndex = value;
            }
        }
    }
}