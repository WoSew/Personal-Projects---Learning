using System;
using System.Net.Http;
using System.Security.Cryptography.X509Certificates;
using System.Threading;

namespace BecomingDev.Models
{
    public class Delegates
    {
        public delegate void Write(string message);
        public delegate int Add(int x, int y);
        public delegate void Alert(int change);

        
        public void Test()
        {
            Write writer = WriteMessage;
            writer("Wojciech");

            Add adder = AddTwoNumbers;
            var sum = adder(1, 2);
            Console.WriteLine(sum);

            CheckTemperature(TooLowAlert, OptimalAlert, TooHighAlert);
        }

        public static void TooLowAlert(int change)
        {
            Console.WriteLine($"Temperature is too low (change by {change}).");
        }

        public static void OptimalAlert(int change)
        {
            Console.WriteLine($"Temperature is optimal (change by {change}).");
        }

        public static void TooHighAlert(int change)
        {
            Console.WriteLine($"Temperature is too high (change by {change}).");
        }

        public static void CheckTemperature(Alert tooLow, Alert optimal, Alert tooHigh)
        {
            var temperature = 10;
            var random = new Random();

            while (true)
            {
                var change = random.Next(-5, 5);
                temperature += change;
                Console.WriteLine($"Temperature is at: {temperature} C.");

                if (temperature <= 0)
                {
                    tooLow(change);
                }
                else if (temperature > 0 && temperature <= 10)
                {
                    optimal(change);
                }
                else
                {
                    tooHigh(change);
                }
                Thread.Sleep(500);
            }
        }


        public static int AddTwoNumbers(int x, int y)
        {
            return x + y;
        }

        public static void WriteMessage(string message)
        {
            Console.WriteLine($"Hello {message}!");
        }
    }

    public class LambdaExpressions
    {
       
        public void Test()
        {
            //Action - void

            Action writer = () => Console.WriteLine("Writing..."); // () - arugmenty przyjmowane przez metodę, tu puste nawiasy więc nic nie przyjmuje
            writer();

            Action<string, int> advanceWriter = (message, number) => Console.WriteLine($"{message}, {number}");
            advanceWriter("Hello", 10);

            Action<int> TooLowAlert = (change) => Console.WriteLine($"Temperature is too low (change by {change}).");
            Action<int> OptimalAlert = (change) => Console.WriteLine($"Temperature is optimal (change by {change}).");
            Action<int> TooHighAlert = (change) => Console.WriteLine($"Temperature is too high (change by {change}).");

            //Func 

            Func<int, int, int> adder = (x, y) => x + y; // Func <parametr 1, parametr2..., zwracany typ>
            var sum = adder(1, 2);
            advanceWriter("Sum: ", sum);


            //----------------------------------------------------------------------

            Action<int, string> logger = (temperature, message) =>
            {
                Console.WriteLine($"Temperature is at: {temperature} C. {message}");
            };


            CheckTemperature(t => logger(t, "Too low!"), t => logger(t, "Optimal."), t => logger(t, "Too high!"));
        }

        public static void CheckTemperature(Action<int> tooLow, Action<int> optimal, Action<int> tooHigh)
        {
            var temperature = 10;
            var random = new Random();

            while (true)
            {
                var change = random.Next(-5, 5);
                temperature += change;
                Console.WriteLine($"Temperature is at: {temperature} C.");

                if (temperature <= 0)
                {
                    tooLow(temperature);
                }
                else if (temperature > 0 && temperature <= 10)
                {
                    optimal(temperature);
                }
                else
                {
                    tooHigh(temperature);
                }
                Thread.Sleep(500);
            }
        }
    }

    public class StatusEventArgs : EventArgs
    {
        public string Status { get; }

        public StatusEventArgs(string status)
        {
            Status = status;
        }
    }
    
    public class Events
    {
        public delegate void UpdateStatus(string status);

        public event UpdateStatus StatusUpdated;

        public EventHandler<StatusEventArgs> StatusUpdatedAgain;

        public void StartUpdatingStatus()
        {
            while (true)
            {
                var message = $"status, ticks {DateTime.UtcNow.Ticks}";

                StatusUpdatedAgain?.Invoke(this, new StatusEventArgs(message));
                Thread.Sleep(1000);

                /*
                    this record means the same as:  StatusUpdated?.Invoke(message);                                 
                 
                if (StatusUpdated != null)
                {
                    StatusUpdated(message);
                }
                */
            }
        }
    }

    public class EventSandbox
    {
        public void Test()
        {
            var events = new Events();


            events.StatusUpdatedAgain += (sender, eventArgs) =>
            {
                Console.WriteLine($"{eventArgs.Status}");
            };
            events.StatusUpdated += DisplayStatus2;
            
            events.StartUpdatingStatus();
        }


        public void DisplayStatus(string message)
        {
            Console.WriteLine($"{message}");
        }
        public void DisplayStatus2(string message)
        {
            Console.WriteLine($"2 {message}");
        }
    }

}