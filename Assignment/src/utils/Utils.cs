using System;
using System.IO;

namespace Assignment.utils
{
    public class GenderParser
    {
        public static string parseGender(string stringParameter)
        {
            string trimmedString = stringParameter.Trim();
            if ("F".Equals(trimmedString, StringComparison.InvariantCultureIgnoreCase))
            {
                return "Female";
            }
            else if ("M".Equals(trimmedString, StringComparison.InvariantCultureIgnoreCase))
            {
                return "Male";
            }
            else
            {
                return stringParameter;
            }
        }
    }

    public class DateStringFormatter
    {
        public static string parseDateString(string stringParameter)
        {
            string[] date = stringParameter.Split("/");
            string returnString = date[1] + "/" + date[0] + "/" + date[2];
            return returnString;
        }
    }
}