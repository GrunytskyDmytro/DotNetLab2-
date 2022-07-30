using ExtensionsMethods.Classes;
using ExtensionsMethods.Classes.Generalized_classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionsMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;

            Console.Write("Введіть будь-яке речення, словосполучення або к-сть символів: ");
            string str = Console.ReadLine();
            char c = '?';
            int i = str.WordCount(c);

            Console.WriteLine($"\nКількість символів в даному рядку: {i} \n");

            List<string> listOfStrings = new List<string>();
            listOfStrings.Add("one string");
            listOfStrings.Add("two string");
            listOfStrings.Add("three string");
            listOfStrings.Add("four string");
            listOfStrings.Add("five string");

            string result = listOfStrings.ListToString();

            Console.WriteLine($"Результат виконання інвертування: \n\n {result} \n ");

            Console.WriteLine("----------------------------------- \n");

            //------------------------------------------------------------------------

            Console.WriteLine("Поданий одновимірний масив:");

            int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 2, 2, 2, 2, 2, 2, 2, 2};

            Console.Write("\n{ ");
            for (int r = 0; r < arr.Length; r++)
            {
                Console.Write($"{arr[r]} ");
            }
            Console.WriteLine("}\n");

            int n = 2;

            int resArr = arr.CountNum(n);

            int[] exArr = arr.DistinctNum();

            Console.WriteLine($"Кількість повторюваних значень: '{n}', в даному масиві: {resArr} \n");

            Console.WriteLine("Масив з унікальних елементів: \n");
            Console.Write("{ ");
            for (int r = 0; r < exArr.Length; r++) 
            {
                Console.Write($"{exArr[r]} ");
            }
            Console.WriteLine("}\n");

            Console.WriteLine("-----------------------------------\n");

            //------------------------------------------------------------------------

            ExtendedDictionary<int, string, string> extendedDictionary = new ExtendedDictionary<int, string, string>();

            extendedDictionary.Add(0, "Str", "Str");
            extendedDictionary.Add(1, "String", "String1");
            extendedDictionary.Add(2, "String1", "String2");
            extendedDictionary.Add(3, "String3", "String4");
            extendedDictionary.Add(4, "String5", "String6");
            extendedDictionary.Add(5, "String7", "String8");

            extendedDictionary.ShowDictonary();

            Console.WriteLine("\n-----------------------------------\n");

            extendedDictionary.Remove(3);

            extendedDictionary.ShowDictonary();

            Console.WriteLine("\n-----------------------------------\n");

            extendedDictionary.GetForKey(1);

            Console.WriteLine("\n-----------------------------------\n");

            extendedDictionary.CountElements();

            Console.WriteLine("\n-----------------------------------\n");

            extendedDictionary.GetForKey_Other(5);

            Console.WriteLine("\n-----------------------------------\n");

            Console.WriteLine(extendedDictionary.GetForTwoValues("String7", "String8"));

            Console.WriteLine();

            Console.ReadLine();
        }
    }
}
