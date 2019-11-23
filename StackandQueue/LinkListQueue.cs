using System;
using System.Collections.Generic;
using System.Text;

namespace StackandQueue
{
    public class LinkListQueue<T>
    {
        Node<T> Front;
        Node<T> Rear;

        public LinkListQueue()
        {
            this.Front = this.Rear = null;
        }

        public void Enqueue(T Value)
        {
            Node<T> newNode = new Node<T>(Value);
            if (this.Rear == null)                                  //Stack'in  boşsa 
            {
                this.Front = this.Rear = newNode;                   //Stack'in önü ve arkası yeni eklenen node olsun

            }
            else                                                         //Stack boş değilse?? 
            {
                this.Rear.Next = newNode;                                //Stack'in arkasının nexti yeni node olsun             
                this.Rear = newNode;                                    // Stack'in arkası yeni node olsun
            }
        }

        public void Dequeue()
        {
            if (this.Front == null)
            {
                Console.WriteLine("Queue Boş");
                return;
            }
            else
            {
                Node<T> Temp = this.Front;                                  
                this.Front = this.Front.Next;                               //önü null olan noda kadar nodelerin nextini al
                if (this.Front == null)
                {
                    this.Rear = null;                                   //önü null olan (yani baş nodenin) arkasını null yap (Böylece 2.NODE Baş node olmuş olacak.
                }
            }
        }

    }
}
