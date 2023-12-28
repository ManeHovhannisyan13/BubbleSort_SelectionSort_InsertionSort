using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BubbleSort_SelectionSort_InsertionSort
{
    public class BubbleSort_SelectionSort_InsertionSort
    {
        //Bubble
        public static void BubbleSort(int[] arr)
        {
            int cnt = arr.Length;
            bool sorted = false;

            while (!sorted)
            {
                sorted = true;
                for (int i = 0; i < cnt - 1; i++)
                {
                    if (arr[i] > arr[i + 1])
                    {
                        int t = arr[i];
                        arr[i] = arr[i + 1];
                        arr[i + 1] = t;
                        sorted = false;
                    }
                }
                cnt--;
            }
        }

        //Selection
        public static void SelectionSort(int[] arr1)
        {
            int ndx = 0, minPos = 0, cnt = arr1.Length;

            while (ndx < cnt - 1)
            {
                minPos = ndx;

                
                for (int i = ndx + 1; i < cnt; i++)
                {
                    if (arr1[i] < arr1[minPos])
                    {
                        minPos = i;
                    }
                }

                int t = arr1[ndx];
                arr1[ndx] = arr1[minPos];
                arr1[minPos] = t;
                ndx++;
            }
        }

        //Insertion
        public static void InsertionSort(int[] arr3)
        {
            int cnt = arr3.Length;
            int key;
            for (int i = 0; i < cnt; i++)
            {
                key = arr3[i];
                int j = i - 1;
                while (j >= 0 && arr3[j] > key)
                {
                    arr3[j + 1] = arr3[j];
                    j = j - 1;
                }

                arr3[j + 1] = key;
            }
        }
    }
}
