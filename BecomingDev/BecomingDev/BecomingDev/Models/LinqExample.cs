using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

namespace BecomingDev.Models
{
    public class LinqExample
    {
        public IEnumerable<BoardGames> GetBoardGame()
        {
            yield return new BoardGames("Terraforming Mars", 4, 19.99M, 8.1M, DateTime.UtcNow.AddDays(-5));
            yield return new BoardGames("Star Wars Rebellion", 5, 49.99M, 8.0M, DateTime.UtcNow.AddDays(-15));
            yield return new BoardGames("Terra Mystica", 6, 189.99M, 7.9M, DateTime.UtcNow.AddDays(-150));
            yield return new BoardGames("7 Wonders", 3, 89.99M, 8.2M, DateTime.UtcNow.AddDays(-3));
            yield return new BoardGames("Jungle Speed", 10, 76, 7.0M, DateTime.UtcNow.AddDays(-45));
            yield return new BoardGames("Smallworld", 11, 123, 6.1M, DateTime.UtcNow.AddDays(-111));
            yield return new BoardGames("Cathan", 12, 333, 4.5M, DateTime.UtcNow.AddDays(-8));
            yield return new BoardGames("Ticket to ride", 15, 59.99M, 1.9M, DateTime.UtcNow.AddDays(-1));
            yield return new BoardGames("Caverna", 16, 48.42M, 0.5M, DateTime.UtcNow);
            yield return new BoardGames("Agricola", 14, 59, 2.42M, DateTime.UtcNow.AddDays(-9));
            yield return new BoardGames("The Castles of Burgundy", 7, 0.99M, 7.5M, DateTime.UtcNow.AddDays(-51));
            yield return new BoardGames("Talisman", 8, 50, 7.4M, DateTime.UtcNow.AddDays(-31));
            yield return new BoardGames("Gloomhave", 2, 8.99M, 8.3M, DateTime.UtcNow);
            yield return new BoardGames("Dixit", 9, 28, 7.23M, DateTime.UtcNow.AddDays(-40));
            yield return new BoardGames("Pandemic Legacy", 1, 89.99M, 8.5M, DateTime.UtcNow.AddDays(-50));
            yield return new BoardGames("Splendor", 13, 99, 3.5M, DateTime.UtcNow.AddDays(-123));
        }


        public void LinqTraining()
        {
            var games = GetBoardGame();

            var sortedByPriceGames = games.OrderBy(x => x.Price);
            var sortedByPriceDescendingGames = games.OrderByDescending(x => x.Price);

            var sortedMix = games.OrderBy(c => c.Name.Length).ThenBy(x => x.Name); // sorted by name length then by alphabet

            var priceOfEverything = games.Sum(x => x.Price);

            var averagePrice = games.Average(x => x.Price).ToString("#.00");

            var top5 = games.OrderBy(x => x.Rank).Take(5);

            var gamesDictionary = games.ToDictionary(x => x.Rank, x => x.Name).OrderBy(x => x.Key);

            var midGames = gamesDictionary.Where(x => x.Key > 7).Where(x => x.Key < 12);

            var gameNames = games.Select(x => x.Name);

            var gameDate = games.Select(x => x.CreatedAt);

            var gamePrice = games.Select(x => x.Price);

            var everyGameContainsA = games.All(x => x.Name.Contains("A"));

            var gamesMoreExpensiveThanAverage = games.Where(x => x.Price > games.Average(y => y.Price))
                .OrderBy(x => x.Price);

        }

    }

    public class BoardGames
    {
        public Guid ID { get; private set; }

        public string Name { get; private set; }

        public int Rank { get; private set; }

        public decimal Price { get; private set; }

        public decimal GeekRating { get; private set; }

        public DateTime CreatedAt { get; private set; }

        public BoardGames(string name, int rank, decimal price, decimal geekRating, DateTime createdAt)
        {
            Name = name;
            Rank = rank;
            Price = price;
            GeekRating = geekRating;
            CreatedAt = createdAt;
        }
        
    }
}