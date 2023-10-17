using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    internal class QuickSorter : IntSorter
    {
        public void QuickSort(int[] arr, int high, int low)
        {
            if(high <= low)
            {
                return;
            }

            int p = arr[low];
            int i = low;
            int j = high + 1;

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
            
            QuickSort(arr, j-1, low);
            QuickSort(arr, high, j+1);

        }

        public void Sort(int[] a)
        {
            ArrayUtil.Shuffle(a);
            QuickSort(a, a.Length - 1, 0);

        }
    }

