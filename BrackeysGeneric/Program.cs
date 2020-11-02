using System;
using System.Collections.Generic;

namespace BrackeysGeneric
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            KeyValuePair<string, int> meaning = new KeyValuePair<string, int>("Life", 25);
            meaning.Print();

            Dictionary<string, int> prices = new Dictionary<string, int>(5);
            prices.Add("Watermelon", 5);
            prices.Add("car", 2000);
            System.Console.WriteLine(prices["Watermelon"]);
            System.Console.WriteLine(prices["car"]);
            System.Console.WriteLine();

            System.Console.WriteLine(Utility.CompareValues("10", "10"));

            System.Console.WriteLine();

            System.Console.WriteLine(Utility.CompareTypes("10", "11"));

            
            Console.ReadLine();
        }
    }

    class KeyValuePair<TKey, TValue>
    {
        public TKey key;
        public TValue value;

        public KeyValuePair(TKey _key, TValue _value)
        {
            key = _key;
            value = _value;
        }

        public void Print()
        {
            System.Console.WriteLine(key.ToString() + " is the key");
            System.Console.WriteLine();
            System.Console.WriteLine(value.ToString() + " IS THE VALUE");
        }
    }

    class Utility
    {
        public static bool CompareValues<T01, T02>(T01 value01, T02 value02)
        {
            return value01.Equals(value02);
        }

        public static bool CompareTypes<T01, T02>(T01 type01, T02 type02)
        {
            return typeof(T01).Equals(typeof(T02));
        }
    }
}


