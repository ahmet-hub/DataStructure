using System;
using System.Collections.Generic;
using System.Text;

namespace LinkedList
{
    class Program
    {
         static void Main(string[] args)
        {
            //SingleLinkedList linkedList = new SingleLinkedList();
            ////linkedList.InsertLast(linkedList, 5);
            //linkedList.InsertFront(linkedList, 10);
            //linkedList.InsertFront(linkedList, 20);
            //linkedList.InsertFront(linkedList, 30);
            //linkedList.InsertFront(linkedList, 40);
            //linkedList.InsertFront(linkedList, 50);




            //linkedList.Display(linkedList);
            //Console.WriteLine("-----");

            //linkedList.DeleteLast(linkedList);
            ////linkedList.DeleteFront(linkedList);
            //linkedList.Display(linkedList);

            ////var result= linkedList.GetSecondLastNode(linkedList);
            ////Console.WriteLine("Second Last: " + result.Data);
            ///
            DoubleLinkedList linkedList = new DoubleLinkedList();
            linkedList.InsertFront(linkedList, 5);
            linkedList.InsertFront(linkedList, 20);
            linkedList.InsertFront(linkedList, 30);
            linkedList.InsertFront(linkedList, 50);
            
            //linkedList.InsertFront(linkedList, 40);
            var lastnode=linkedList.Head.Prev;
            var headnode = linkedList.Head;

            linkedList.Display(linkedList);
            Console.WriteLine("------");

            Console.WriteLine("LastNode"+lastnode.Data);
            Console.WriteLine("HeadNode" + headnode.Data);
            linkedList.Print();


            //var result = linkedList.GetLastNode(linkedList);
            //Console.WriteLine("result: " + result.Data);
            //var lastPrev = result.Prev.Data;
            //Console.WriteLine("Prev: " + lastPrev);

            //linkedList.DeleteLast(linkedList);

            //linkedList.Display(linkedList);

            //var lastNode = linkedList.GetLastNode(linkedList);
            //Console.WriteLine("LastNode: " + lastNode.Data);
            //var lastNodePrev = lastNode.Prev.Data;


            //Console.WriteLine("LastNodePrev: " + lastNodePrev);
            //Console.WriteLine("Head Node: " + linkedList.Head.Data);
            //Console.WriteLine("Second Node: " + linkedList.Head.Next.Data);
            //linkedList.InsertBefore(linkedList.Head, linkedList,50);
            //Console.WriteLine("Head Node: " + linkedList.Head.Data);
            //Console.WriteLine("Second Node: " + linkedList.Head.Next.Data);
            //Console.WriteLine("Second Node: " + linkedList.Head.Next.Prev.Data);

            //var result = linkedList.GetLastNode(linkedList).Data;
            //Console.WriteLine("lAST Node: "+result);
            //linkedList.InsertAfter(linkedList.GetLastNode(linkedList),50);
            //var result2=linkedList.GetLastNode(linkedList);
            //Console.WriteLine("New lAST Node: " + result2.Data);
            //linkedList.Display(linkedList);










        }
    }
}
