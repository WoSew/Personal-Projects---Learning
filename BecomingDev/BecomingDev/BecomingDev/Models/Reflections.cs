using System;
using System.Linq;
using System.Reflection;

namespace BecomingDev.Models
{
    public class Reflections
    {
        public void Test()
        {
            var user = new User("user1@email.com", "secret");

            var type = user.GetType().GetTypeInfo();

            Console.WriteLine($"{type.Name} {type.Namespace} {type.FullName}");

            var methods = type.GetMethods();

            foreach (var method in methods)
            {
                Console.WriteLine($"{method.Name}");
            }

            user.Activate();
            Console.WriteLine($"Is active: {user.IsActive}.");

            var deactivateMethod = methods.First(x => x.Name == "Deactivate");
            deactivateMethod.Invoke(user, null);

            Console.WriteLine($"Is active: {user.IsActive}.");

            Console.WriteLine($"User email: {user.Email}.");

            var setEmailMethod = type.GetMethod("SetEmail");
            setEmailMethod.Invoke(user, new[] {"user2@email.com"});

            Console.WriteLine($"User email: {user.Email}.");

            var email = type.GetProperty("Email").GetValue(user);
            Console.WriteLine($"{email}");

            var databaseTypes = Assembly.GetEntryAssembly().GetTypes().Where(x => x.Name.Contains("Database"));

            foreach (var databaseType in databaseTypes)
            {
                Console.WriteLine($"{databaseType}");
            }

            var user2 = (User)Activator.CreateInstance(typeof(User), new[] { "user22@email.com", "sercret2"});

            Console.WriteLine($"{user2.Email}");
        }
    }

}   