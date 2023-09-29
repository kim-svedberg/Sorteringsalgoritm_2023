using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Sorteringsalgoritm_2023
{
    internal class MergeSorter
    {
        int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11};

        public void Upg1a()
        {
            ArrayUtil.Shuffle(arr);
            Print();
            Console.WriteLine("--------------------------------");

            MergeSort(arr, arr.Length-1, 0);
            Print();

        }

        public int[] MergeSort(int[] arr, int high, int low)
        {
            if (low < high)
            {
                int mid = (high + low) / 2;
                MergeSort(arr, mid, low); //Vänster subarray
                MergeSort(arr, high, mid + 1); //Höger subarray

                Merge(arr, high, low, mid + 1);
            }

            return arr;
        }

        public void Merge(int[] arr, int high, int low, int mid)
        {
            int[] copyArr = new int[arr.Length];
            int i, endOfLeft, posL, posR, elementsCount;
            endOfLeft = mid - 1;
            posL = low;
            posR = mid;

            // Copy elements from arr to copyArr
            for (i = low; i <= high; i++)
            {
                copyArr[i] = arr[i];
            }

            for (i = low; posL <= endOfLeft && posR <= high; i++)
            {
                if (copyArr[posL] <= copyArr[posR])
                {
                    arr[i] = copyArr[posL];
                    posL++;
                }
                else
                {
                    arr[i] = copyArr[posR];
                    posR++;
                }



            }

            while (posL <= endOfLeft)
            {
                arr[i] = copyArr[posL];
                i++;
                posL++;
            }

            while (posR <= high)
            {
                arr[i] = copyArr[posR];
                i++;
                posR++;
            }

        }

        public void Print()
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }
        }
    }

   
}
