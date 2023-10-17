using System;
using System.Collections.Generic;


    internal class SortingWithLibrary: IntSorter
    {
        SortedDictionary<int, int> d =
            new SortedDictionary<int, int>();

        public void SortDict(int[] a)
        {
            foreach (int value in a) 
            {
                if (!d.TryGetValue(value, out int amount))
                {
                    amount = 0;
                }
                d[value] = amount + 1;
            }

        }

        public void Print()
        {
            foreach (int key in d.Keys)
            {
                int amount = d[key];
                //for(int j = 0; j < amount; j++)
                {
                    Console.WriteLine(key + " x" + amount);
                }
            }
        }

        public void Sort(int[] a)
        {
            d.Clear();
            SortDict(a);
            int i = 0;
            foreach (int key in d.Keys)
            {
                int amount = d[key];
                for (int j = 0; j < amount; j++)
                {
                    a[i++] = key;
                }
            }
        }
    }

