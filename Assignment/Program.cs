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
            
            // Command to run .\Assignment `/resources/pipe.txt` "|"
            List<CustomerInformation> parsedCustomerInformation = 
                CustomerInfoParser.ParseCustomerInformation("pipe.txt", Constants.DELIMETER_PIPE);
            Sort.insertionSort(parsedCustomerInformation, new DateOfBirthComparatorAsc());
            // Use String.Format for output
            
            /*foreach (var customerInformation in parsedCustomerInformation)
            {
                Console.WriteLine(customerInformation.FirstName + customerInformation.LastName + customerInformation.DateOfBirth);
            }*/
            
        }

       

        public static void PrintFirstCriteria()
        {
            
        }
    }
}