using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Assignment.utils
{
    public class PipeCustomerInfoParser : CustomerInfoParser
    {

        public PipeCustomerInfoParser()
        {
            fileName = "pipe.txt";
        }
        
        public override CustomerInformation setCustomerInformation(string line)
        {
            CustomerInformation customerInformation = new CustomerInformation();
            List<string> customerInformationLineList = line.Split("|").ToList();
            customerInformation.LastName = customerInformationLineList[0];
            customerInformation.FirstName = customerInformationLineList[1];
            customerInformation.MiddleInitial = customerInformationLineList[2];
            customerInformation.Gender = GenderParser.parseGender(customerInformationLineList[3]);
            customerInformation.FavoriteColor = customerInformationLineList[4];
            customerInformation.DateOfBirth = customerInformationLineList[5].Replace("-", "/");
            return customerInformation;
        }
    }
}