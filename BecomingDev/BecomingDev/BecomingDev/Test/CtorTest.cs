using System;

namespace BecomingDev.Test
{
    public class  CtorTest
    {
        
    }

    public class Car
    {
        public virtual void VirtualTest()
        {
            Console.WriteLine("Z klasy Car");
        }

    }

    public class UltraCar : Car
    {
        //public override void VirtualTest()
        //{
        //    base.VirtualTest();
        //    Console.WriteLine("Z klasy UltraCar dopisalo sie");
        //}

        public override void VirtualTest()
        {
           
            Console.WriteLine("Z klasy UltraCar dopisalo sie");
        }

    }
}