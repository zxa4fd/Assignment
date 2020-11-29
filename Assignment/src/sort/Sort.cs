using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;

namespace Assignment.sort
{
    public class Sort
    {
        public static void insertionSort(List<int> list)
        {
            for (int i = 1; i < list.Capacity; i++)
            {
                var currentItem = list[i];
                int j = i - 1;
                while (j >= 0 && currentItem < list[j])
                {
                    list[j + 1] = list[j];
                    j--;

                }
                list[j + 1] = currentItem;
            }
        }
    }
}
