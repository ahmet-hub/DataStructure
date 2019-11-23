using System;
using System.Collections.Generic;
using System.Text;

namespace LinkedList
{
    public class DoubleLinkedList
    {
        public DNode Head { get; set; }
        public DNode Prev { get; set; }
        public void InsertFront(DoubleLinkedList linkedList, object data)
        {
            DNode newNode = new DNode(data);
            if (linkedList.Head == null)
            {
                linkedList.Head = newNode;
                newNode.Next = null;
                newNode.Prev = null;
            }
            else
            {
                DNode lastNode = GetLastNode(linkedList);
                newNode.Next = linkedList.Head;
                linkedList.Head.Prev = newNode;
                linkedList.Head = newNode;
                newNode.Prev = lastNode;

            }
        }
        public void InsertFront2(DoubleLinkedList linkedList, object data)
        {
            DNode newNode = new DNode(data);             //Liste boşsa....
                                                         //Gelen data =newnode oldu                
            newNode.Next = linkedList.Head;
            //DNode lastNode=GetLastNode(linkedList);                                                         //eklediğimiz nodenin nexti listedeki eski baş oldu.                                                
            newNode.Prev = null;                        //eklediğimiz node listenin başı olduğu için previ=null oldu 
            if (linkedList.Head != null)                //Listede eleman varsa 
            {
                DNode lastNode = GetLastNode(linkedList);
                linkedList.Head.Prev = newNode;
                newNode.Prev = lastNode;
                //Listede eleman varsa önceki baş nodenin previ yeni eklenen node oldu
            }
            linkedList.Head = newNode;                   //Listenin başı yeni eklenen node oldu
        }

        public void InsertLast(DoubleLinkedList linkedList, object data)
        {
            DNode newNode = new DNode(data);
            if (linkedList.Head == null)
            {
                linkedList.Head = newNode;              // listede node yoksa nodeyi ekle
            }
            DNode lastNode = GetLastNode(linkedList);   //son nodeyi bul

            lastNode.Next = newNode;                    // son nodenin nextine---->> yeni nodeyi ekle
            newNode.Prev = lastNode;                    // eklenen nodenin prev(öncesine)--->>>lastnodeyi ekle


        }
        public void InsertAfter(DNode prev_node, object data)
        {
            if (prev_node == null)
            {
                Console.WriteLine("The given previous node Cannot be null");
                return;
            }
            DNode newNode = new DNode(data);
            newNode.Next = prev_node.Next;
            prev_node.Next = newNode;
            newNode.Prev = prev_node;
            if (newNode.Next != null)
            {
                newNode.Next.Prev = newNode;
            }
        }

        public void InsertBefore(DNode next_node, DoubleLinkedList LinkedList, object data)
        {
            if (next_node == null)
            {
                Console.WriteLine("The given previous node Cannot be null");
                return;
            }

            DNode newNode = new DNode(data);
            newNode.Prev = next_node.Prev;   //yeni ekliyeceğimiz nodenin previni parametre olarak gelen nodenin previ yaptık.
            newNode.Next = next_node;        //yeni ekliyeceğimiz nodenin nextini parametre olan node yaptık.(ondan önce ekliyoruz)
            next_node.Prev = newNode;        // parametre olan nodenin previ yeni eklediğimiz node olmalı.(ondan önce ekliyoruz)
            if (newNode.Prev != null)
            {
                newNode.Prev.Next = newNode;    //yeni ekliyeceğimiz nodeden önce node varsa = yeni ekliyeceğimiz nodenin previnin.nexti yeni ekliyeceğimiz node olmalı(kaybolmasın)
            }
            else
                LinkedList.Head = newNode;    // yeni ekliyeceğimiz node listenin başına eklenecekse head = yeni ekliyeceğimiz node.
            newNode.Prev = null;            // listenin headi olduğu için previ null.

        }

        public DNode GetLastNode(DoubleLinkedList linkedList)
        {
            DNode temp = linkedList.Head;
            while (temp.Next != null)
            {
                temp = temp.Next;

            }
            return temp;

        }

        public void DeleteFront(DoubleLinkedList linkedList)
        {
            if (linkedList.Head != null)
            {
                linkedList.Head = linkedList.Head.Next;
            }

        }
        public void DeleteLast(DoubleLinkedList linkedList)
        {
            DNode SecondLastNode = GetSecondLastNode(linkedList);

            SecondLastNode.Next = null;

        }

        public DNode GetSecondLastNode(DoubleLinkedList linkedList)
        {
            DNode temp = linkedList.Head;
            while (temp.Next.Next != null)
            {
                temp = temp.Next;
            }
            return temp;

        }
        public void Display(DoubleLinkedList linkedList)
        {
            DNode node = Head;
            while (node != null)
            {
                Console.WriteLine(node.Data);
                node = node.Next;
            }
        }
        public void Print()
        {
            var prtemp = Head;
            StringBuilder sb = new StringBuilder();
            while (true)
            {
                if (prtemp == null)
                {
                    break;
                }
                sb.Append("|" + prtemp.Data + "|");
                var temp = prtemp;
                prtemp = temp.Next;
            }
            Console.WriteLine(sb.ToString());
        }
    }
}
