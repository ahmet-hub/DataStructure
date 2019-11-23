using System;
using System.Collections.Generic;
using System.Text;

namespace StackandQueue
{
    public class StackImpl<T>
    {
        public object[] StackArray { get; set; }
        public int Size { get; set; }

        public int Top { get; set; }
        public StackImpl()
        {
            StackArray = new object[1];
            Top = 0;
            Size = 1;
        }

        public void Push(object data)
        {
            if (Top >= Size)
            {
               object[] temp = new object[Size * 2];
               for (int i = 0; i < Size; i++)               
                    temp[i] = StackArray[i];
               
                StackArray = temp;
                Size *= 2;               
                
            }
        
            StackArray[Top++] = data;

        }
        public T Pop()
        {
            if (Top <= Size / 4)
            {
                object[] temp = new object[Size /2];
                for (int i = 0; i < Size; i++)
                    temp[i] = StackArray[i];
                StackArray = temp;
                Size /= 2;
            }
            return (T)StackArray[--Top];
        }
        public T Peek()
        {
            return (T)StackArray[Top];
        }
        public void Display()
        {
            for (int i = 0; i < Top; i++)
            {
                Console.Write(" " +StackArray[i] );
            }
        }
    }
}
