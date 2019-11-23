using System;
using System.Collections.Generic;
using System.Text;

namespace StackandQueue
{
    public class LinkListStack<T>
    {
        Node<T> Top;

        public LinkListStack()
        {
            this.Top = null;
        }

        public void Push(T Value)
        {
            Node<T> newNode = new Node<T>(Value);
            if (Top == null)                           
            {                              
                Top = newNode;                          
                Top.Next = null;                       
            }
            else
            {                                            
                newNode.Next = Top;                     
                Top = newNode;                          

            }
        }
        public  void Pop()
        {
            if (Top == null)
            {
                Console.WriteLine("Stack Boş");     
                return;
            }

            Console.WriteLine("Çıkarıldı: {0}", Top.Data);    
            Top = Top.Next;           

        }
        public T Peek()
        {
            if (Top == null) 
            {
                throw new InvalidOperationException("Stack Boş");

            }           
            return Top.Data;
            

        }

        public void Print()
        {
            var prtemp = Top;
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

