using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp11
{
    public class Pair<TKey, TValue> where TKey : IComparable<TKey>
    {
        //public Pair(TKey key, TValue value)
        //{
        //    ValueId = key;
        //    Definition = value;
        //}
        public TKey ValueId { get; set; }
        public TValue Definition { get; set; }
    }
}

