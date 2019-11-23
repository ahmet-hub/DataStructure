using System;
using System.Collections.Generic;
using System.Text;

namespace StackandQueue
{
    public class Node<T>
    {
        public T Data { get; set; }
        public Node<T> Next { get; set; }
        public Node(T node)
        {
            Data = node;
            Next = null;
           

        }

    }
}
