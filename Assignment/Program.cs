using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Assignment.sort;

namespace Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            
            /*
            List<CustomerInformation> parsedCustomerInformation =
                ParseCustomerInformation("pipe.txt", Constants.DELIMETER_PIPE);
                */

            // Use String.Format for output

        }

        public static List<CustomerInformation> ParseCustomerInformation(string fileName, string delimeter)
        {
            List<CustomerInformation> parsedData = new List<CustomerInformation>();
            string filePath = Directory.GetCurrentDirectory() + "\\resources\\" + fileName;
            string line = String.Empty;
            // 3-3-1985 is mm//dd//yyyy -> ##/##/#### 
            // Create a Stream using Filepath
            using (StreamReader file = new StreamReader(filePath))
            {
                while ((line = file.ReadLine()) != null)
                {
                    List<string> ls = line.Split(delimeter).ToList();
                    CustomerInformation customerInformation = new CustomerInformation();
                    customerInformation.LastName = ls[0];
                    customerInformation.FirstName = ls[1];
                    customerInformation.MiddleInitial = ls[2];
                    customerInformation.Gender = ls[3];
                    customerInformation.FavoriteColor = ls[4];
                    customerInformation.DateOfBirth = ls[5].Replace("-", "/");
                    parsedData.Add(customerInformation);
                }
            }

            return parsedData;
        }

        public static void PrintFirstCriteria()
        {
            
        }
    }
}