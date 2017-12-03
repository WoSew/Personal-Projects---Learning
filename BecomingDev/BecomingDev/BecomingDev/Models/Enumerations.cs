using System;
using System.Collections.Generic;
using System.Linq;

namespace BecomingDev.Models
{
    public class Enumerations
    {
        public void Test()
        {
            var numbersList = Enumerable.Range(1,100).ToList();
            IEnumerable<int> numbers = GetNumbers();


            foreach (var number in numbers)
            {
                Console.WriteLine(number);
            }

            var enumerator = numbers.GetEnumerator();
            while (enumerator.MoveNext())
            {
                Console.WriteLine(enumerator.Current);
            }

            IQueryable<int> differentNumbers;
            foreach (var number in numbers)
            {
                Console.WriteLine(number);
            }


            var useres = GetUsers().ToList();
            foreach (var user in useres)
            {
                
            }

        }

        public IQueryable<User> GetUsers()
        {
            return null;
        }
        
        public IEnumerable<int> GetNumbers()
        {
            yield return 1;
            yield return 2;
            yield return 3;
            yield return 4;
            yield return 5;
        }

        public void TestLinq()
        {
            var items = GetItems();

            var food = items.Where(x => x.Category == "Food");
            var tools = items.Where(x => x.Category == "Tools");
            //equivalent record
            var toolsQuery = from tool in items
                where tool.Category == "Tools"
                select tool;

            var foodAndTools = tools.Union(food);

            var axeFirst = items.FirstOrDefault(x => x.Name == "Helmet");
            var axeSingle = items.SingleOrDefault(x => x.Name == "Helmet");

            var numbers = Enumerable.Range(1, 10);
            var max = numbers.Max();
            var sum = numbers.Sum();

            var totalPriceOfTools = tools.Sum(x => x.Price);

            var query = items.Where(x => x.CreatedAt >= DateTime.UtcNow.AddDays(-10))
                .Where(x => x.Price > 300)
                .Skip(1)
                .Take(2)
                .OrderBy(x => x.Price)
                .Select(x => new {x.Name, x.Price});

            var groupedItems = items.GroupBy(x => x.Category);

            var dictionary = items.ToDictionary(x => x.Name, x => x.Price);

        }


        public IEnumerable<Item> GetItems()
        {
            yield return new Item("Axe", "Tools", 250, DateTime.Now.AddDays(-15));
            yield return new Item("Driller", "Tools", 300, DateTime.Now.AddDays(-10));
            yield return new Item("Ball", "Sport", 60, DateTime.Now.AddDays(-7));
            yield return new Item("Monitor", "Electronics", 800, DateTime.Now.AddDays(-20));
            yield return new Item("Car", "Vehicle", 20000, DateTime.Now.AddDays(-5));
            yield return new Item("Bike", "Vehicle", 1500, DateTime.Now.AddDays(-10));
            yield return new Item("Notebook", "Electronics", 3000, DateTime.Now.AddDays(-1));
            yield return new Item("Mouse", "Animal", 200, DateTime.Now.AddDays(-5));
            yield return new Item("Pizza", "Food", 40, DateTime.Now.AddDays(-2));
            yield return new Item("Dog", "Animal", 1000, DateTime.Now.AddDays(-3));
            yield return new Item("Burger", "Food", 250, DateTime.Now.AddDays(-5));
        }
    }

    public class Item
    {
        public Guid Id { get; protected set; }

        public string Name { get; protected set; }

        public string Category { get; protected set; }

        public decimal Price { get; protected set; }

        public DateTime CreatedAt { get; protected set; }

        public Item(string name, string category, decimal price, DateTime createdAt)
        {
            Id = Guid.NewGuid();
            Name = name;
            Category = category;
            Price = price;
            CreatedAt = createdAt;
        }
    }
}