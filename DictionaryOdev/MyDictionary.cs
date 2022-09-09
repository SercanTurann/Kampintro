using System;
using System.Collections.Generic;
using System.Text;

namespace DictionaryOdev
{
    internal class MyDictionary<T,K>
    {
        KeyValuePair<T,K>[] items;

        public MyDictionary()
        {
            items = new KeyValuePair<T, K>[0];
        }

        public void Add(T _key  ,K _value)
        {

            if (Control(_key))
            {
                Configuration();
                items[items.Length - 1] = new KeyValuePair<T, K>(_key, _value); // En son bize gelen değeri dizimize aktarıp işi bitirdik.
            }
            else
            {
                Console.WriteLine("Girdiğiniz key değeri özel olmalı. Yani daha önceden eklenmiş bir key değerini tekrardan kullanamassınız.");
            }
        }

        private void Configuration()
        {
            throw new NotImplementedException();
        }
    }
}
