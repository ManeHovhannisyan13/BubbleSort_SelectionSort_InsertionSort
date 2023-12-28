using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Collections.Specialized.BitVector32;

namespace BubbleSort_SelectionSort_InsertionSort
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //BubbleSort
            Console.WriteLine("BubbleSort");
            Console.WriteLine("Enter the number of elements:");

            if (!int.TryParse(Console.ReadLine(), out int n) || n <= 0)
            {
                Console.WriteLine("Invalid input. Please enter a positive integer for the number of elements.");
            }

            int[] a = new int[n];

            Console.WriteLine("Enter the elements:");

            for (int i = 0; i < n; i++)
            {
                Console.Write($"Element {i + 1}: ");

                if (!int.TryParse(Console.ReadLine(), out a[i]))
                {
                    Console.WriteLine("Invalid input. Please enter valid integers for the elements.");
                }
            }

            BubbleSort_SelectionSort_InsertionSort.BubbleSort(a);

            Console.WriteLine("Sorted array:");

            for (int i = 0; i < a.Length; i++)
            {
                Console.WriteLine($"{a[i]}");
            }
            Console.WriteLine("________________________________________");
            Console.WriteLine();



            //SelectionSort
            Console.WriteLine("SelectionSort");
            Console.WriteLine("Enter the number of elements:");

            if (!int.TryParse(Console.ReadLine(), out int m) || m <= 0)
            {
                Console.WriteLine("Invalid input. Please enter a positive integer for the number of elements.");
            }

            int[] arr1 = new int[m];

            Console.WriteLine("Enter the elements:");

            for (int i = 0; i < m; i++)
            {
                Console.Write($"Element {i + 1}: ");

                if (!int.TryParse(Console.ReadLine(), out arr1[i]))
                {
                    Console.WriteLine("Invalid input. Please enter valid integers for the elements.");
                }
            }

            BubbleSort_SelectionSort_InsertionSort.SelectionSort(arr1);

            Console.WriteLine("Sorted array:");

            for (int i = 0; i < arr1.Length; i++)
            {
                Console.WriteLine($"{arr1[i]}");
            }
            Console.WriteLine("_____________________");




            //InsertionSort
            Console.WriteLine("InsertionSort");
            Console.WriteLine("Enter the number of elements:");

            if (!int.TryParse(Console.ReadLine(), out int k) || k <= 0)
            {
                Console.WriteLine("Invalid input. Please enter a positive integer for the number of elements.");
            }

            int[] arr2 = new int[k];

            Console.WriteLine("Enter the elements:");

            for (int i = 0; i < k; i++)
            {
                Console.Write($"Element {i + 1}: ");

                if (!int.TryParse(Console.ReadLine(), out arr2[i]))
                {
                    Console.WriteLine("Invalid input. Please enter valid integers for the elements.");
                }
            }
            BubbleSort_SelectionSort_InsertionSort.InsertionSort(arr2);

            Console.WriteLine("Sorted array:");

            for (int i = 0; i < arr2.Length; i++)
            {
                Console.WriteLine($"{arr2[i]}");
            }
            Console.WriteLine("_____________________");
        }
    }
}
