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
        private static String staticFileName;

        static void Main(string[] args)
        {
            // Command to run .\Assignment `/resources/pipe.txt` "|"
            List<CustomerInformation> parsedCustomerInformation =
                CustomerInfoParser.ParseCustomerInformation("pipe.txt", Constants.DELIMETER_PIPE);

            SortAndPrintFirstCriteria(parsedCustomerInformation);
            SortAndPrintSecondCriteria(parsedCustomerInformation);
            SortAndPrintThirdCriteria(parsedCustomerInformation);
        }

        public static void SortAndPrintFirstCriteria(List<CustomerInformation> parsedCustomerInformation)
        {
            Sort.shellSort(parsedCustomerInformation, new GenderComparator());
            Sort.shellSort(parsedCustomerInformation, new LastNameComparatorAsc());
            Console.WriteLine("gender then lastname ascending");
            PrintToConsole(parsedCustomerInformation);
        }

        public static void SortAndPrintSecondCriteria(List<CustomerInformation> parsedCustomerInformation)
        {
            Sort.shellSort(parsedCustomerInformation, new DateOfBirthComparatorAsc());
            Console.WriteLine("dateofbirth ascending");
            PrintToConsole(parsedCustomerInformation);
        }

        public static void SortAndPrintThirdCriteria(List<CustomerInformation> parsedCustomerInformation)
        {
            Sort.shellSort(parsedCustomerInformation, new LastNameComparatorDesc());
            Console.WriteLine("lastname descending");
            PrintToConsole(parsedCustomerInformation);
        }
        
        public static void PrintToConsole(List<CustomerInformation> parsedCustomerInformation)
        {
            Console.WriteLine("--------------------------");
            foreach (CustomerInformation ci in parsedCustomerInformation)
            {
                String formattedString = String.Format("{0,-12}{1,-12}{2,-12}{3,-12}{4,-12}{5,-12}",
                    ci.LastName, ci.FirstName, ci.MiddleInitial, ci.Gender, ci.FavoriteColor, ci.DateOfBirth);
                Console.WriteLine(formattedString);
            }

            Console.WriteLine();
            Console.WriteLine("--------------------------");
            Console.WriteLine();
        }
    }
}