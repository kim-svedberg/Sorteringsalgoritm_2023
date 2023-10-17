using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    internal class ModdedQuickSorter : IntSorter
    {
        public void ModdedQuickSort(int[] arr, int high, int low)
        {
            if(high <= low)
            {
                return;
            }

            int p = arr[low];
            int i = low;
            int j = high + 1;
            int M = 100;

            while (true)
            {
                i++;
                while(i < high && arr[i] < p)
                {
                    i++;

                }
               
                j--;
                while(arr[j] > p) 
                { 
                    j--; 
                }

                if(i >= j)
                {
                    break;
                }
                else
                {
                    int temp = arr[i];
                    arr[i] = arr[j];
                    arr[j] = temp;
                }



            }

            int value = arr[j];
            arr[j] = p;
            arr[low] = value;

            if (high - low <= M)
            {
                InsertionSort(arr, j-1, low);
            }
            else
            {
                ModdedQuickSort(arr, j - 1, low);
            }
            
            if(high - (j+1) <= M)
            {
                InsertionSort(arr, high, j + 1);

            }
            else
            {
                ModdedQuickSort(arr, high, j + 1);

            }


        }

        public void Sort(int[] a)
        {
            ArrayUtil.Shuffle(a);
            ModdedQuickSort(a, a.Length - 1, 0);

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

        public void Print(int[] arr)
        {
            for(int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }
        }
    }
