using System;
using System.Collections.Generic;

namespace GameProjectN
{
    internal class Program
    {
        static void Main(string[] args)
        {
            GamerManager gamerManager = new GamerManager(new UserValidationManager());
            gamerManager.Add(new Gamer { Id = 1, BirthYear = 1985, FirstName = "ENGİN", LastName = "DEMİROĞ", IdentityNumber = 12345 });

            GamesManager gamesManager = new GamesManager();
            gamesManager.Add(new TheGame() { Id = 1, GameMoney = 10, NameOfTheGame = "Valo" });
            gamesManager.Add(new TheGame() { Id = 2, GameMoney = 15, NameOfTheGame = "lol" });

        }
    }
}
