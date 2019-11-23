using System;
using System.Collections.Generic;
using System.Text;

namespace SearchingAlgorithms
{
    public class Sort
    {
        public int[] SelectionSort(int[] numbers)
        {
            for (int i = 0; i < numbers.Length; i++)
            {
                int min = i;
                for (int j = i+1; j < numbers.Length; j++)
                {
                    if (numbers[j] < numbers[min]) min = j;

                }
                int temp = numbers[i];
                numbers[i] = numbers[min];
                numbers[min] = temp;

            }
            return numbers;
        }
        public int[] BubbleSort(int[] numbers)
        {
            int temp = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                for (int j = 1; j < numbers.Length-i; j++)
                {
                    if (numbers[j - 1] > numbers[j])
                    {
                        temp = numbers[j - 1];
                        numbers[j - 1] = numbers[j];
                        numbers[j] = temp;
                    }
                }
            }
            return numbers;
        }

    }


}