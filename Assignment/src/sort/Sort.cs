using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Reflection.Metadata;
using System.Security;
using Microsoft.VisualBasic;

namespace Assignment.sort
{
    public class Sort
    {
        public static void insertionSort<T>(List<T> list, Comparer<T> comparer)
        {
            for (int i = 1; i < list.Count; i++)
            {
                T currentItem = list[i];
                int j = i - 1;
                while (j >= 0 && comparer.Compare(currentItem, list[j]) == -1)
                {
                    list[j + 1] = list[j];
                    j--;
                }
                list[j + 1] = currentItem;
            }
        }
        
        public static void shellSort<T>(List<T> list, Comparer<T> comparer)
        {
            int listLength = list.Count;

            for (int gap = listLength / 2; gap > 0; gap /= 2)
            {
                for (int i = gap; i < listLength; i++)
                {
                    T currentItem = list[i];
                    int j = i;
                    while (j >= gap  && comparer.Compare(currentItem, list[j - gap]) == -1)
                    {
                        list[j] = list[j - gap];
                        j -= gap;
                    }
                    list[j] = currentItem;
                }
            }
        }
    }
    
    

}
