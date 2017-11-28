using System;

namespace BecomingDev.Models
{
    public class Exceptions
    {
        public void Test()
        {
            //connection to DB
            try
            {
                User user = new User("user@email.com", "Secret");
                user = null;
                throw new ArgumentNullException(nameof(user));
                //Sing up user...
                //Email in use...
                throw new Exception("Email in use.");
            }

            catch (ArgumentNullException exception)
            {
                Console.WriteLine($"Null error:  {exception}");
            }

            catch (Exception exception
            ) // catch zawierajacy Exception powinien być na końcu, by pozostałe mogły wyłapać inne wyjątki, a nie on wyłapał wszystkie
            {
                Console.WriteLine($"An error:  {exception}");
            }
            finally
            {
                //Dispose()  // przerywamy polaczenie z DB
            }



            Console.WriteLine("OK");
            Console.ReadLine();
            /*
            Exception exception = new Exception("Parent", new Exception("Child")); // class exception own inner exception. It is possible to go inside and get more information // string sourceChildExceptionSource = exception.InnerException.Source;

            throw exception;
            */
        }
    }
}