using System;

namespace ConsoleApp1
{
    internal class Program
    {
        static void BubbleSort(int[] arr)
        {
            int CounterOfCompare = 0;
            int CounterOfChange = 0;
            int n = arr.Length;
            for (int i = 1; i < n; i++)
            {
                bool isSorted = true;
                for (int j = 0; j < n - i; j++)
                {
                    CounterOfCompare++;
                    if (arr[j] > arr[j+1])
                    {
                        int temp = arr[j];
                        arr[j] = arr[j+1];
                        arr[j+1] = temp;
                        isSorted = false;
                        CounterOfChange++;
                    }
                }
                if (isSorted)
                {
                    break;
                } 
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

            
            BubbleSort(array);    

            foreach (int i in array)
            {
                Console.Write($"{i} ");
            }
            Console.WriteLine();

            
            Console.ReadKey(false);
        }
    }
}