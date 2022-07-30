using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionsMethods.Classes
{
    public static class StringExtensions
    {
        public static int WordCount(this string str, char c)
        {
            int counter = 0;
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == c)
                    counter++;
            }
            return counter;
        }

        public static string ListToString(this IList list)
        {
            StringBuilder result = new StringBuilder("");
            if (list.Count > 0)
            {
                result.Append(list[0].ToString());
                for (int i = 1; i < list.Count; i++)
                    result.AppendFormat(", {0}",
                       list[i].ToString());
            }
            return result.ToString();
        }
    }
}
