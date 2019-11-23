using System;
using System.Collections.Generic;
using System.Text;

namespace SearchingAlgorithms
{
    public class Search
    {
        public int LinearSearch(int[] numbers, int number)              //Return index.
        {
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] == number)
                    return i;
            }
            return -1;
        }

        public bool LinearSearchBoolean(int[] numbers, int number)     //Return True/False.
        {
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] == number)
                    return true;
            }
            return false;
        }

        public int LinearSearchRecursive(int[] numbers, int first, int last, int number)
        {
            if (last < first)
                return -1;
            if (numbers[first] == number)
                return first;
            if (numbers[last] == number)
                return last;
            return LinearSearchRecursive(numbers, first + 1, last - 1, number);

            
        }

        public int BinarySearch(int[] numbers, int number)             //  Return index.
        {
            int start = 0;
            int end = numbers.Length - 1;
            while (start <= end)
            {
                int mid = (start + end) / 2;
                if (number < numbers[mid]) end = mid + 1;
                else if (number > numbers[mid]) start = mid - 1;
                else return mid;

            }
            return -1;
        }

        public bool BinarySearchBoolean(int[] numbers, int number)     //  Return True/False.
        {
            int start = 0;
            int end = numbers.Length - 1;
            while (start <= end)
            {
                int mid = (start + end) / 2;
                if (number < numbers[mid]) end = mid + 1;
                else if (number > numbers[mid]) start = mid - 1;
                else return true;
            }


            return false;
        }

        public int BinarySearchRecursive(int[] numbers, int first, int last, int number)
        {
            int mid = (first + last) / 2;
            if (number == numbers[mid]) return mid;

            else if (first >= last) return -1;
            else if (number <= numbers[mid])
                return BinarySearchRecursive(numbers, first, mid, number);
            else return BinarySearchRecursive(numbers, mid, last, number);
        }

        public int JumpSearch(int[] numbers, int number)
        {
            int n = numbers.Length;
            int step = (int)Math.Floor(Math.Sqrt(n));
            int prev = 0;
            while (numbers[Math.Min(step, n) - 1] < number)
            {
                prev = step;
                step += (int)Math.Floor(Math.Sqrt(n));
                if (prev >= n)
                    return -1;
            }
            while (numbers[prev] < number)
            {
                prev++;


                if (prev == Math.Min(step, n))
                    return -1;
            }

            if (numbers[prev] == number)
                return prev;

            return -1;
        }


    }
}

