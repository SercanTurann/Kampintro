using System;

namespace DictionaryOdev
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<string, string> myDictionary = new MyDictionary<string, string>();
            myDictionary.Add("Sercan","Sercan2");
            foreach (var item in myDictionary)
            {

            }
        }
    }
}
