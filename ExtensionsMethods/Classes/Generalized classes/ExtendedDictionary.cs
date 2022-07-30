using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionsMethods.Classes.Generalized_classes
{
    class ExtendedDictionary<T, U, V>
    {
        public T Key { get; set; }

        public U GetFisrtValue { get; set; }

        public V GetSecondValue { get; set; }

        public List<string> list = new List<string>();

        public int[] arr;

        /*public List<T> listT;

        public List<U> listU;

        public List<V> listV;

        public List<ExtendedDictionary<T, U, V>> list = new List<ExtendedDictionary<T, U, V>>();

        public void Add(T Key, U GetFisrtValue, V GetSecondValue)
        {
            list.Add(new ExtendedDictionary<T, U, V>() 
            {
                listT = new List<T> { Key },
                listU = new List<U> { GetFisrtValue },
                listV = new List<V> { GetSecondValue }
            });
        }

        public void Remove(int Key)
        {
            list.Remove(list[Key]);
        }

        public void GetForKey(int Key)
        {
            Console.WriteLine(list[Key]);
        }

        public void ShowDictonary()
        {
            foreach (ExtendedDictionary<T, U, V> l in list)
            {
                Console.WriteLine(l);
            }
        }*/

        public void Add(T Key, U GetFisrtValue, V GetSecondValue)
        {
            list.Add($"{Key} - {GetFisrtValue} - {GetSecondValue}");
        }

        public void Remove(int Key)
        {
            list.Remove(list[Key]);
        }

        public void GetForKey(int Key)
        {
            if (Key != 0)
                Console.WriteLine(list[Key]);
            else
                Console.WriteLine("Помилка!");
        }

        public void ShowDictonary() 
        {
            foreach (string l in list)
            {
                Console.WriteLine(l);
            }
        }

        public void CountElements()
        {
            int sum = 0;
            foreach (string l in list)
            {
                ++sum;
            }
            Console.WriteLine($"Кількість елементів: {sum}");
        }

        public void GetForKey_Other(int Key)
        {
            if (Key == 0)
                Console.WriteLine("Помилка! Такого елемента не існує.");
            else 
                Console.WriteLine("Елемент існує.");
        }


        public string GetForTwoValues(U GetFisrtValue, V GetSecondValue)
        {
            foreach (string element in list)
            {
                if (GetFisrtValue != null && GetSecondValue != null)
                {
                    return "Елементи існують.";
                }
            }
            return "Таких елементів не існує!!!";
        }
    }
}
