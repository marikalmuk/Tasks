using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp11
{
    public class MyDictionary<TKey, TValue> where TKey : IComparable<TKey>
    {
        public MyDictionary()
        { }

        List<Pair<TKey, TValue>> dictionary = new List<Pair<TKey, TValue>>();

        public void Add(TKey key, TValue value)
        {
            Pair<TKey, TValue> pair = new Pair<TKey, TValue> { ValueId = key, Definition = value };
            dictionary.Add(pair);
        }
        public void GetValueByKey(TKey key)
        {
            TValue value = dictionary.Find(v => v.ValueId.CompareTo(key) == 0).Definition;
            Console.WriteLine($"the value is {value}");
        }
        public void ValidateKey(TKey key)
        {
            //if (dictionary.Any(k => k.ValueId == key))
            var pair = dictionary.Find(k => k.ValueId.CompareTo(key) == 0);
            if (dictionary.Contains(pair))
            {
                throw new Exception("key already present in the dictionary");
            }
            else
            {
                GetValueByKey(key);
            }
        }
        public void RemoveByKey(TKey key)
        {
            var pair = dictionary.Find(k => k.ValueId.CompareTo(key) == 0);
            dictionary.Remove(pair);
        }

        public void ShowValues()
        {
            foreach (Pair<TKey, TValue> i in dictionary)
            {
                Console.WriteLine($"{ i.ValueId} {i.Definition}");
            }
        }
    }
}
    
