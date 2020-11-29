using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Reflection.Metadata;

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
    }

    public class GenderComparator : Comparer<CustomerInformation>
    {
        public override int Compare(CustomerInformation x, CustomerInformation y)
        {
            if ("F".Equals(x.Gender, StringComparison.InvariantCultureIgnoreCase) 
                || "Female".Equals(x.Gender, StringComparison.InvariantCultureIgnoreCase))
            {
                return 1;
            }
            else
            {
                return -1;
            }
        }
    }

    public class LastNameComparatorAsc : Comparer<CustomerInformation>
    {

        public override int Compare(CustomerInformation x, CustomerInformation y)
        {
            return x.LastName.CompareTo(y.LastName);
        }
    }
    
    public class LastNameComparatorDesc : Comparer<CustomerInformation>
    {

        public override int Compare(CustomerInformation x, CustomerInformation y)
        {
            return y.LastName.CompareTo(x.LastName);
        }
    }
    
}
