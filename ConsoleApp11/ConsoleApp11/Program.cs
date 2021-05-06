using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp10
{

    public class MyDictionary<TKey, TValue> where TKey : class
    {
        public MyDictionary()
        { }

        List<Pair<TKey, TValue>> dictionary = new List<Pair<TKey, TValue>>();

        public void Add(Pair<TKey, TValue> pair)
        {
            dictionary.Add(pair);

            foreach (Pair<TKey, TValue> i in dictionary)
            {
                Console.WriteLine(i);
            }
        }
        public void GetValueByKey(TKey key)
        {
            TValue value = dictionary.Find(v => v.ValueId == key).Definition;
            Console.WriteLine($"the value is {value}");
        }
        public void ValidateKey(TKey key)
        {
            try
            {
                //if (dictionary.Contains(key)
                if (dictionary.Any(k => k.ValueId == key))
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
        public void RemoveByKey(TKey key)
        {
            var k1 = dictionary.Find(k => k.ValueId == key);
            dictionary.Remove(k1);

            foreach (Pair<TKey, TValue> i in dictionary)
            {
                Console.WriteLine(i);
            }

        }
    }
    public class Pair<TKey, TValue>
    {
        public TKey ValueId { get; set; }
        public TValue Definition { get; set; }

    }

    class Program
    {
        static void Main(string[] args)
        {
            Pair<int, string> pair = new Pair<int, string>();

            MyDictionary<Pair<int, string>> myDictionary = new MyDictionary<Pair<int, string>>();

            myDictionary.Add(1, "alpha");
            myDictionary.Add(2, "beta");
            myDictionary.Add(3, "gamma");

            myDictionary.GetValueByKey(3);

            myDictionary.ValidateKey(5);

            myDictionary.RemoveByKey(2);

        }
    }
}
