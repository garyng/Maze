using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MazeGen
{
    public struct ParentInfo
    {
        private int _index;
        private Node _parent;

        public ParentInfo(Node parent, int index)
        {
            _parent = parent;
            _index = index;
        }

        /// <summary>
        /// The index of the parent node
        /// </summary>
        public int Index
        {
            get
            {
                return _index;
            }
            set
            {
                _index = value;
            }
        }

        public Node Parent
        {
            get
            {
                return _parent;
            }
            set
            {
                _parent = value;
            }
        }
    }
}
