using System;
using System.Collections.Generic;
using System.Text;

namespace LinkedList
{
    public class DNode
    {
        public object Data { get; set; }
        public DNode Prev { get; set; }
        public DNode Next { get; set; }

        public DNode( object Data)
        {
            this.Data = Data;
            Prev = null;
            Next = null;
        }
    }
}
