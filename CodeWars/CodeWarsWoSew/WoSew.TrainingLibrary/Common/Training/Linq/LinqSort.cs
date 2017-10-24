using System;
using System.Collections.Generic;
using System.Linq;

namespace WoSew.TrainingLibrary.Common.Training.Linq
{
    public class LinqSort
    {
        private string[] tableOfStrings = new string[]
        {
            "Lorem",
            "Ipsum",
            "is",
            "simply",
            "dummy",
            "text",
            "of",
            "the",
            "printing",
            "and",
            "typesetting "
        };

        public void WoSewOrderBy()
        {
            var orderedtableofString = tableOfStrings.OrderBy(x => x);

            var odberedDescendingtableOfString = tableOfStrings.OrderByDescending(x => x);

        }


    }

    class Comparer : IComparer<string>
    {
        public int Compare(string x, string y)
        {
            Random rand = new Random();
            int i = rand.Next(2);
            if (i == 0)
                return 0; //true
            else
                return -1; //false
        }
    }
    
    class Animal
    {
        public string Name;
        public char Sex; //K or M
        public int Age;

        public Animal()
        {
            
        }

        public Animal(string n, char s, int a)
        {
            Name = n;
            Sex = s;
            Age = a;
        }

        public void show(List<Animal> listONe)
        {
            int id = 1;
            foreach (var item in listONe)
            {
                string word = id + ". " + item.Name + " " + item.Sex + " " + item.Age;
                id++;
                Console.WriteLine(word);
            }
            
        }
    }
}