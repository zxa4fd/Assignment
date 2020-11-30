using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Assignment.utils
{
    public abstract class CustomerInfoParser
    {

        protected string fileName = "";
        
        public abstract CustomerInformation setCustomerInformation(String line);
        
        public List<CustomerInformation> ParseCustomerInformation()
        {
            List<CustomerInformation> parsedData = new List<CustomerInformation>();
            string filePath = Directory.GetCurrentDirectory() + @"\resources\" + fileName;
            string line = String.Empty;
            using (StreamReader file = new StreamReader(filePath))
            {
                while ((line = file.ReadLine()) != null)
                {

                    CustomerInformation customerInformation = setCustomerInformation(line);

                    parsedData.Add(customerInformation);
                }
            }
            return parsedData;
        }

    }
}