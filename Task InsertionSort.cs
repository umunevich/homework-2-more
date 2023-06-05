using System;

namespace ConsoleApp1
{
    internal class Program
    {
        static void InsertionSort(int[] arr)
        {
            int CounterOfCompare = 0;
            int CounterOfChange = 0;
            int n = arr.Length;
            for (int i = 1; i < n; i++)
            {
                int c = arr[i];
                int j;
                CounterOfCompare++;
                for (j = i - 1; j >= 0 && arr[j]>c; j--)
                {
                    arr[j+1] = arr[j];
                    CounterOfChange++;
                }
                arr[j+1] = c;
            }
            Console.WriteLine($"The number of comparisons is {CounterOfCompare} and changes is {CounterOfChange}.");
        }

        static void Main(string[] args)
        {
            int[] array = { 3, 1, 4, 7, 2, 8, 10, 9, 5, 6 };
            //int[] array = { 1, 2, 4, 3, 5, 6, 7, 8, 9, 10 };
            //int[] array = { 10, 9, 8, 7, 6, 5, 4, 3, 2, 1 };
            Console.WriteLine("Given array: ");
            foreach (int i in array)
            {
                Console.Write($"{i} ");
            }
            Console.WriteLine();

            Console.WriteLine("Sorted array: ");


            InsertionSort(array);    

            foreach (int i in array)
            {
                Console.Write($"{i} ");
            }
            Console.WriteLine();

            
            Console.ReadKey(false);
        }
    }
}