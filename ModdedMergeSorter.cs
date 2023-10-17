using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



    internal class ModdedMergeSorter : IntSorter
    {
        int[] copyArr;
        int M = 100;


        public int[] MergeSort(int[] arr, int high, int low)
        {
            if (low < high)
            {
                int mid = (high + low) / 2;

                if (mid - low <= M)
                {
                    InsertionSort(arr, mid, low);
                }
                else
                {
                    MergeSort(arr, mid, low); //Vänster subarray

                }

                if (high - (mid+1) <= M)
                {
                    InsertionSort(arr, high, mid + 1);
                }
                else
                {
                    MergeSort(arr, high, mid + 1); //Höger subarray

                }

                Merge(arr, high, low, mid + 1);
            }

            return arr;
        }

        public void Merge(int[] arr, int high, int low, int mid)
        {
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
        public void Sort(int[] a)
        {
            copyArr = new int[a.Length];
            MergeSort(a, a.Length - 1, 0);

        }

        public void InsertionSort(int[] a, int high, int low)
        {
            int N = high + 1;

            for (int i = low; i < N; i++)
            {
                for (int j = i; j > low && a[j] < a[j - 1]; j--)
                {
                    int x = a[j];
                    a[j] = a[j - 1];
                    a[j - 1] = x;
                }
            }
        }
    }
