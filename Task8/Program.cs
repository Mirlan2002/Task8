using System;
using System.Collections.Generic;

namespace Task8
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary m = new MyDictionary();
            m["one"] = 1;
            m["two"] = 2;
            m["three"] = 3;
            m["ten"] = 10;
            Console.WriteLine(m["ten"]);
        }
    }

    public class MyDictionary
    {
        private Dictionary<string, int> a = new Dictionary<string, int>();

        public int this[string s]
        {
            get
            {
                return a[s];
            }
            set
            {
                a[s] = value;
            }
        }
    }
}
