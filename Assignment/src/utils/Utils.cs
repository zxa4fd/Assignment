using System;

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
}