using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection.Metadata;
using Assignment.sort;
using Assignment.utils;

namespace Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            List<CustomerInformation> parsedCustomerInformation = 
                CustomerInfoParser.ParseCustomerInformation("pipe.txt", Constants.DELIMETER_PIPE);
            Sort.insertionSort(parsedCustomerInformation, new GenderComparator());
            // Use String.Format for output
            Console.WriteLine("test");

        }

       

        public static void PrintFirstCriteria()
        {
            
        }
    }
}