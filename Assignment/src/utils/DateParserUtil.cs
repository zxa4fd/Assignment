using System;

namespace Assignment.utils
{
    public class DateParserUtil
    {
        public static string parseGender(string p)
        {
            if ("F".Equals(p, StringComparison.InvariantCultureIgnoreCase))
            {
                return "Female";
            }
            else if ("M".Equals(p, StringComparison.InvariantCultureIgnoreCase))
            {
                return "Male";
            }
            else
            {
                return p;
            }
        }
    }
}