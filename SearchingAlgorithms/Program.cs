using System;

namespace SearchingAlgorithms
{
    class Program
    {
        static void Main(string[] args)
        {
            //Search search = new Search();
            int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            int[] numbers2 = { 3,1,2,5};
            ////int result= search.LinearSerch(numbers, 20);
            ////int result2 = search.BinarySearch(numbers, 10);
            //int lenght = numbers.Length;
            //int number10=numbers[9];

            //Console.WriteLine("uzunluk"+lenght);
            //Console.WriteLine("sayı" + number10);
            Sort sort = new Sort();
            //sort.SelectionSort(numbers);
            foreach (var item in sort.BubbleSort(numbers2)) 
            {
                Console.Write(" " + item);

            }

        }
    }
}
