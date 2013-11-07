using System;
using System.Collections.Generic;
using System.Linq;

namespace MazeGen
{
    public class Node
    {

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

        private Node _down;
        private Node _up;
        private Node _right;
        private Node _left;

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
    }
}
