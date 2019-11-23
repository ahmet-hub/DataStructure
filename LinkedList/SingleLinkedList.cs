using System;
using System.Collections.Generic;
using System.Text;

namespace LinkedList
{
    public  class SingleLinkedList
    {
        public SNode Head { get; set; }
        public void InsertFront(SingleLinkedList linkedList, object data)
        {
            SNode newNode = new SNode(data);
            newNode.Next = linkedList.Head;             //yeni eklediğimiz nodenin nexti--->> listeye son eklenen elemanı gösterdi.
            linkedList.Head = newNode;                  //listenin başı yeni eklediğimiz node oldu.
        }

        public void InsertLast(SingleLinkedList linkedList, object data)
        {
            SNode newNode = new SNode(data);
            if (linkedList.Head == null)                // listede node yoksa ??
            {
                linkedList.Head= newNode;               // listenin başını yeni node yap.
                return;
            }
            SNode lastNode = GetLastNode(linkedList);   //listede node varsa ??
            lastNode.Next = newNode;                    // listedeki son nodenin nextine --->> yeni nodeyi ekle.



        }
        public void InsertAfter(SNode prev_node, object data)
        {
            if (prev_node == null)
            {
                Console.WriteLine("The given previous node Cannot be null");
                return;
            }
            SNode newNode = new SNode(data);
            newNode.Next = prev_node.Next;
            prev_node.Next = newNode;           
        }
        

        //Sona Elaman Ekleyebilmek için
        private SNode GetLastNode(SingleLinkedList linkedList) 
        {
            SNode temp = linkedList.Head;           //listenin başını geçiçi bi değişkene at.
            while (temp.Next != null)               //yeni node null olana kadar dön.
            {
                temp = temp.Next;                   //her yeni nodeyi geçiçi bir değişkene at.
            }
            return temp;                            // son node return et.
        }
        public void Display( SingleLinkedList linkedList)
        {
            SNode node = Head;
            while (node != null)
            {
                Console.WriteLine(node.Data);
                node = node.Next;
            }
        }

        public void DeleteFront(SingleLinkedList linkedList)
        {
            if (linkedList.Head != null)
                linkedList.Head = linkedList.Head.Next;        
        }
        public void DeleteLast(SingleLinkedList linkedList)
        {
            SNode SecondLastNode = GetSecondLastNode(linkedList);
            SecondLastNode.Next = null;

        }

        // Son Nodeyi silebilmek için
        public SNode GetSecondLastNode(SingleLinkedList linkedList) 
        {
            SNode temp = linkedList.Head;
            while (temp.Next.Next != null)
            {
                temp = temp.Next;
            }
            return temp;             
        }
        public void DeletedNodeByKey(SingleLinkedList linkedList, object key)
        {
            SNode temp = linkedList.Head;
            SNode prev = null;
            if (temp != null && temp.Data == key)
            {
                linkedList.Head = temp.Next;
                return;
            }
            while (temp != null && temp.Data != key) 
            {
                prev = temp;
                temp = temp.Next;

            }
            if (temp == null)
            {
                return;
            }
            prev.Next = temp.Next;
        }
        
    }
}
