using System;
using System.Collections.Generic;
using System.Text;

namespace GameProjectN
{
    internal class GamesManager : IGames
    {
        public void Add(TheGame theGame)
        {
            Console.WriteLine("Oyun eklendi.");
        }

        public void Delete(TheGame theGame)
        {
            Console.WriteLine("Oyun silindi.");
        }

        public void Update(TheGame theGame)
        {
            Console.WriteLine("Oyun güncellendi.");
        }
    }
}
