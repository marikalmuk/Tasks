using System;
using System.Collections.Generic;

namespace ConsoleApp10
{

    public class MyDictionary<Key, Value>
    {
        public MyDictionary()
        { }

        Dictionary<Key, Value> dictionary = new Dictionary<Key, Value>();

        public void Add(Key key, Value value)
        {
            dictionary.Add(key, value);

            foreach (KeyValuePair<Key, Value> i in dictionary)
            {
                Console.WriteLine(i.Key + " - " + i.Value);
            }
        }
        public void GetValueByKey(Key key)
        {
            Value value = dictionary[key];
            Console.WriteLine($"the value is {value}");
        }

        public void ValidateKey(Key key)
        {
            try
            {
                if (dictionary.ContainsKey(key))
                {
                    throw new Exception("key already present in the dictionary");
                }
                else
                {
                    GetValueByKey(key);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine($"Exception occured: {e.Message}");
            }
        }

        public void RemoveByKey(Key key)
        {
            dictionary.Remove(key);
            foreach (KeyValuePair<Key, Value> i in dictionary)
            {
                Console.WriteLine(i.Key + " - " + i.Value);
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<int, string> myDictionary = new MyDictionary<int, string>();

            myDictionary.Add(1, "alpha");
            myDictionary.Add(2, "beta");
            myDictionary.Add(3, "gamma");

            myDictionary.GetValueByKey(3);

            myDictionary.ValidateKey(5);

            myDictionary.RemoveByKey(2);

        }
    }
}
