using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Assignment.utils
{
    public class CommaCustomerInfoParser : CustomerInfoParser
    {
        public CommaCustomerInfoParser()
        {
            fileName = "comma.txt";
        }
        
        public override CustomerInformation SetCustomerInformation(string line)
        {
            List<string> customerInformationLineList = line.Split(",").ToList();
            CustomerInformation customerInformation = new CustomerInformation();
            customerInformation.LastName = customerInformationLineList[0];
            customerInformation.FirstName = customerInformationLineList[1];
            customerInformation.Gender = GenderParser.parseGender(customerInformationLineList[2]);
            customerInformation.FavoriteColor = customerInformationLineList[3];
            customerInformation.DateOfBirth = customerInformationLineList[4].Replace("-", "/");
            return customerInformation;
        }
    }
}