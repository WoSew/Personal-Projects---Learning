using System;
using System.Collections.Generic;

namespace BecomingDev.Models
{
    public abstract class Car // We define abstract classes to let the user know that the instance of this entity itself does not make much sense. That is why we need to inherit and build on it in this way
    {
        public double Speed { get; protected set; } = 100; //default value 
        public double Acceleration { get; protected set; } = 10;

        public void Start()
        {
            Console.WriteLine("Turning on the engine...");
            Console.WriteLine($"Running at:{Speed} km/h.");
        }

        public void Stop()
        {
            Console.WriteLine("Stopping the car...");
        }

        public virtual void Accelerate() // virtual metod CAN be override in inherited members, if we want to use basic metod and write something more just write base.MetodName(); and the rest
        {
            Console.WriteLine("Accelerating...");
            Speed += Acceleration;
            Console.WriteLine($"Running at:{Speed} km/h.");
        }

        public abstract void Boost(); // abstract metod MUST be implemented in inherited members
        
    }

    public class Truck : Car
    {
        public override void Accelerate()
        {
            Console.WriteLine("Accelerating a truck...");
            base.Accelerate();
        }

        public override void Boost()
        {
            Console.WriteLine("Boosting a truck...");
            Speed += 50;
            Console.WriteLine($"Running at:{Speed} km/h.");
        }
    }

    public class SportCar : Car
    {
        public override void Accelerate()
        {
            Console.WriteLine("Accelerating...");
            Speed += Acceleration;
            Console.WriteLine($"Running at:{Speed} km/h.");
        }

        public override void Boost()
        {
            Console.WriteLine("Boosting a sport car...");
            Speed += 80;
            Console.WriteLine($"Running at:{Speed} km/h.");
        }

        public void DisplayInfo()
        {
            Console.WriteLine("Sport car.");
        }

    }

    public class Race
    {
        public void Begin()
        {
            SportCar sportCar = new SportCar();
            Truck truck = new Truck();

            List<Car> cars = new List<Car>()
            {
                sportCar, truck
            };

            foreach (Car car in cars)
            {
                car.Start();
                car.Accelerate();
                car.Boost();
            }
            Console.ReadLine();

        }

        public void Casting() // rzutowanie
        {
            Car sportCar = new SportCar();
            Car truck = new Truck();

            //sportCar.DisplayInfo(); // can't use metod DisplayInfo in this way, becaouse sportCar is a object from class Car, not SportCar. Solution of this problem is casting look down:

            //down casting - rzutowaniu w dół 
            SportCar realSportCar = (SportCar) sportCar;
            realSportCar.DisplayInfo();

            //up casting - rzutowanie w górę
            Car realCar = (Car) realSportCar; // now metod DisplayInfo is not available

            //more secure approach:
            bool isSportcar = sportCar is SportCar; //I check if I can cast a sportCar for the type SportCar
            if (isSportcar)
            {
                ((SportCar)sportCar).DisplayInfo();
            }

            SportCar castedSportCar = sportCar as SportCar;
            if (castedSportCar != null)
            {
                castedSportCar.DisplayInfo();
            }

        }

    }

}