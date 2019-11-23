using System;
using System.Collections.Generic;
using System.Text;

namespace LinkedList
{
    public class SNode
    {
        public object  Data { get; set; }
        public SNode Next { get; set; }

        public SNode(object Data)
        {
            this.Data = Data;
            this.Next = null;

        }

    }
}
