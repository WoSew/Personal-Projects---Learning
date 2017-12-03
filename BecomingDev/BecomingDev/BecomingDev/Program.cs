using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BecomingDev.Models;

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

            var enumerations = new Enumerations();
            enumerations.TestLinq();
        }
    }
}
