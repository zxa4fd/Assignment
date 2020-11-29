using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Assignment.utils
{
    public class CustomerInfoParser
    {
        public static List<CustomerInformation> ParseCustomerInformation(string pathOfFile, string delimeter)
        {
            List<CustomerInformation> parsedData = new List<CustomerInformation>();
            string filePath = Directory.GetCurrentDirectory() + pathOfFile;
            string line = String.Empty;
            using (StreamReader file = new StreamReader(filePath))
            {
                while ((line = file.ReadLine()) != null)
                {
                    List<string> customerInformationLineList = line.Split(delimeter).ToList();
                    CustomerInformation customerInformation = new CustomerInformation();
                    customerInformation.LastName = customerInformationLineList[0];
                    customerInformation.FirstName = customerInformationLineList[1];
                    customerInformation.MiddleInitial = customerInformationLineList[2];
                    customerInformation.Gender = GenderParser.parseGender(customerInformationLineList[3]);
                    customerInformation.FavoriteColor = customerInformationLineList[4];
                    customerInformation.DateOfBirth = customerInformationLineList[5].Replace("-", "/");
                    parsedData.Add(customerInformation);
                }
            }
            return parsedData;
        }
    }
}