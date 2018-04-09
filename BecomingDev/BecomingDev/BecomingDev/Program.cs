using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BecomingDev.Algorithmics;
using BecomingDev.Models;
using BecomingDev.Test;

namespace BecomingDev
{
    class Program
    {
        static void Main(string[] args)
        {
            #region anonymus type - VAR
            /*
            var xx = 0;
            var user = new User("user@email.com", "secret");


            var anonymusUser = new
            {
                Id = 1,
                Email = "abc@email.com",
                Adress = new
                {
                    Street = "Sienkiewicza 2a"
                }
            };

            List<User> users = new List<User>();
            var differentUsers = users.Select(x => new
            {
                Email = x.Email
            });

            foreach (var differentUser in differentUsers)
            {
                //differentUser.Email;
            }
            */

            #endregion

            UltraCar test = new UltraCar();

            test.VirtualTest();

            TryCatchException exceptionTest = new TryCatchException();

            exceptionTest.TRyCatch3();


            var result = StringOperations.ReverseString("Wojtek");

            var result2 = StringOperations.ReverseString2("Wojtek2");

            var resultPalindrom = StringOperations.IsPalindrom("Może jutro ta dama da tortu jeżom");

            bool flag = StringOperations.IsAnagram("dupa", "audp");

            var substringTest = StringOperations.SubString("POLSKA", 2, 5); //LS

            var silnia = StringOperations.PowerOfInt(6);

            int[] arr = { 800, 11, 50, 771, 649, 770, 240, 9 };

            var bubble = StringOperations.bubbleSort(arr);



            var asynhronous = new Asynhronous();
            asynhronous.Test().Wait();


            Console.ReadLine();
        }
    }
}
