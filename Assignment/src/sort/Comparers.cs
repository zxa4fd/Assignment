using System;
using System.Collections.Generic;
using Assignment.utils;

namespace Assignment.sort
{
    public class GenderComparator : Comparer<CustomerInformation>
    {
        public override int Compare(CustomerInformation x, CustomerInformation y)
        {
            if ("F".Equals(x.Gender, StringComparison.InvariantCultureIgnoreCase) 
                || "Female".Equals(x.Gender, StringComparison.InvariantCultureIgnoreCase))
            {
                return -1;
            }
            else
            {
                return 0;
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
    
    public class DateOfBirthComparatorAsc : Comparer<CustomerInformation>
    {
        public override int Compare(CustomerInformation x, CustomerInformation y)
        {
            string firstDateString = x.DateOfBirth;
            string secondDateString = y.DateOfBirth;
            DateTime a = DateTime.Parse(DateStringFormatter.parseDateString(firstDateString));
            DateTime b = DateTime.Parse(DateStringFormatter.parseDateString(secondDateString));
            return a.CompareTo(b);

        }
    }
}