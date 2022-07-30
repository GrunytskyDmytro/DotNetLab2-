using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionsMethods.Classes
{
    public static class ArrayExtensions
    {
        public static int CountNum<T>(this T[] arr, T num) where T : struct
        {
            int count = 0;

            foreach (T elem in arr)
            {
                if (num.Equals(elem))
                {
                    count++;
                }
            }

            return count;
        }

        public static T[] DistinctNum<T>(this T[] arr)
        {
            List<T> list = new List<T>();

            foreach (T elem in arr)
            {
                if (!list.Contains(elem))
                {
                    list.Add(elem);
                }
            }

            return list.ToArray();
        }
    }
}
