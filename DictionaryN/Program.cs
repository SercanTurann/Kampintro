using System;
using System.Collections.Generic;

namespace DictionaryN
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string,int> dictionary =new Dictionary<string,int>();
            dictionary.Add("Sercan",32);
            dictionary.Add("Turan", 30);
            foreach (var item in dictionary)
            {
                Console.WriteLine(item);
            }
            dictionary.Remove("Sercan");
            Console.WriteLine(dictionary);
        }
    }
}
