using System;
using System.Collections.Generic;
using System.Linq;
using System.Drawing;

namespace MazeGen
{
    public class Node
    {
        private bool _isFrontier;
        private List<ParentInfo> _parentInfo = new List<ParentInfo>();
        private bool _isBacktracked;

        private bool _isStart;
        private Point _pos;
        private const int _count = 4;
        private Node _down;
        private Node _up;
        private Node _right;
        private Node _left;

        /// <summary>
        /// Status of the four wall
        /// 0 = still there
        /// 1 = destroyed
        ///  ____________________
        /// |Left|Down|Right| Up |
        /// |_8__|_4__|__2__|_0__|
        /// </summary>
        private int _wall = 0;

        /// <summary>
        /// Mark the wall as destroyed
        /// </summary>
        /// <param name="index">Up = 0 Left = 1 Down = 2 Right = 3</param>
        public void UnWall(int index)
        {
            _wall |= 1 << index;
        }

        /// <summary>
        /// Get a wall's status
        /// </summary>
        /// <param name="index"></param>
        /// <returns>True = Wall destroyed </returns>
        public bool GetWall(int index)
        {
            return (_wall & (1 << index)) == (1 << index);
        }

        /// <summary>
        /// Mark the wall as not destroyed
        /// </summary>
        /// <param name="index"></param>
        public void SetWall(int index)
        {
            _wall &= ~(1 << index);
        }

        public Node this[int index]
        {
            get
            {
                return SwitchNodeProp(index);
            }
            set
            {
                SwitchNodeProp(index, value);
            }
        }

        private Node SwitchNodeProp(int index, Node value = null)
        {
            switch (index)
            {
                case 0:
                    return ReturnNodeProp(ref _up, value);
                case 1:
                    return ReturnNodeProp(ref _right, value);
                case 2:
                    return ReturnNodeProp(ref _down, value);
                case 3:
                    return ReturnNodeProp(ref _left, value);
            }

            return null;
        }
        private Node ReturnNodeProp(ref Node prop, Node value = null)
        {
            if (value == null)
            {
                return prop;
            }
            else
            {
                prop = value;
                return null;
            }
        }

        public Node Left
        {
            get
            {
                return _left;
            }
            set
            {
                _left = value;
            }
        }
        public Node Right
        {
            get
            {
                return _right;
            }
            set
            {
                _right = value;
            }
        }
        public Node Up
        {
            get
            {
                return _up;
            }
            set
            {
                _up = value;
            }
        }
        public Node Down
        {
            get
            {
                return _down;
            }
            set
            {
                _down = value;
            }
        }
        public int Count
        {
            get
            {
                return _count;
            }
        }
        public int Wall
        {
            get
            {
                return _wall;
            }
            set
            {
                _wall = value;
            }
        }
        public bool isStart
        {
            get
            {
                return _isStart;
            }
            set
            {
                _isStart = value;
            }
        }
        public Point Pos
        {
            get
            {
                return _pos;
            }
            set
            {
                _pos = value;
            }
        }

        /// <summary>
        /// For recursive backtracking
        /// </summary>
        public bool isBacktracked
        {
            get
            {
                return _isBacktracked;
            }
            set
            {
                _isBacktracked = value;
            }
        }

        /// <summary>
        /// For Prim's algorithm
        /// A list of parents
        /// </summary>
        public List<ParentInfo> parentInfo
        {
            get
            {
                return _parentInfo;
            }
            set
            {
                _parentInfo = value;
            }
        }

        /// <summary>
        /// For Prim's AQlgorithm
        /// Mark a node as frontier
        /// </summary>
        public bool isFrontier
        {
            get
            {
                return _isFrontier;
            }
            set
            {
                _isFrontier = value;
            }
        }
    }
}
