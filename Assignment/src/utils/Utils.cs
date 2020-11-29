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
                return " Female ";
            }
            else if ("M".Equals(trimmedString, StringComparison.InvariantCultureIgnoreCase))
            {
                return " Male ";
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

    public class TextOutputUtil
    {
        public void printToPath()
        {
            using (System.IO.StreamWriter file =
                new System.IO.StreamWriter(Directory.GetCurrentDirectory() + @"\output\pipe-output.txt", true))
            {
                string ab = string.Format("{0:-10} | {1:-10}", "afdsafdasdfasf", "abnbnbnb");
                file.WriteLine(ab);
                
            }
        }
    }
}