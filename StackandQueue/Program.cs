using System;
using System.Collections;

namespace StackandQueue
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkListStack<int> listStack = new LinkListStack<int>();
            listStack.Push(10);
            listStack.Push(20);

            var value=listStack.Peek();
            Console.Write(value);





        }
    }
}
