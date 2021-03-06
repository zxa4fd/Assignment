﻿using System;
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
            CustomerInfoParser customerInfoParser = CreateParser(args[0]);
            List<CustomerInformation> parsedCustomerInformation = customerInfoParser.ParseCustomerInformation();
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

        public static CustomerInfoParser CreateParser(string name)
        {
            if ("pipe.txt".Equals(name, StringComparison.InvariantCultureIgnoreCase))
            {
                return new PipeCustomerInfoParser();
            }
            else if ("space.txt".Equals(name, StringComparison.InvariantCultureIgnoreCase))
            {
                return new SpaceCustomerInfoParser();
            } else if ("comma.txt".Equals(name, StringComparison.InvariantCultureIgnoreCase))
            {
                return new CommaCustomerInfoParser();
            }
            return null;
        }
    }
}