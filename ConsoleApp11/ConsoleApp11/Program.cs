using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp11
{
    class Program
    {
        static void Main(string[] args)
        {
            Pair<int, string> pair = new Pair<int, string>();

            MyDictionary<int, string> myDictionary = new MyDictionary<int, string>();

            myDictionary.Add(1, "alpha");
            myDictionary.Add(2, "beta");
            myDictionary.Add(3, "gamma");
            myDictionary.Add(4, "delta");
            myDictionary.ShowValues();

            myDictionary.GetValueByKey(3);

            try
            {
                myDictionary.ValidateKey(4);
            }
            catch (Exception e)
            {
                Console.WriteLine($"Exception occured: {e.Message}");
            }

            myDictionary.RemoveByKey(2);
            myDictionary.ShowValues();

        }
    }
}

