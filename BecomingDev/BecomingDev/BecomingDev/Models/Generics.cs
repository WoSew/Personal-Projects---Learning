using System.Collections.Generic;
using System.ComponentModel;
using BecomingDev.Models;

namespace BecomingDev.Models
{
    public class Result<T>
    {
        public T Item { get; set; } 

        public bool IsValid { get; set;}

        public string Error { get; set; }

    }

    public class Pair<TFirst, TSecond>
    {
        public TFirst First { get; set; }

        public TSecond Second { get; set; }
    }

    public class Triple<TFirst, TSecond, TThird> : Pair<TFirst, TSecond>
    {
        public TThird Third { get; set; } 
    }


    public class GenericOrderProcessor  //<T> where T : Order // constraint - ograniczenie
    {
        public Result<Order> ProcessOders(string email, int orderId)
        {
            Order order = new Order(1, 100);
            return new Result<Order>
            {
                Item = order
            };
        }

        public void LogOrder<TOrder, TSecondOrder>(TOrder order, TSecondOrder secondOrder)
            where TOrder : Order where TSecondOrder : Order
        {
            
        }
    }

    public class Generics
    {
        public void Test()
        {
            GenericOrderProcessor orderProcessor = new GenericOrderProcessor();

            Result<Order> result = orderProcessor.ProcessOders("email@email.com", 1);
            /*if (result.IsValid)
            {
                //result.Item
            }
            else
            {
               // result.Error
            }*/

            Pair<int, string> pair = new Pair<int, string>();

            Triple<int, string, bool> triple = new Triple<int, string, bool>();
            
            ReferenceResult<Order> orderResult = new ReferenceResult<Order>(); 

              ValueResult<int> intResult = new ValueResult<int>();

        }
    }

    //constrint to reference type
    public class ReferenceResult<T> where T : class 
    {
        public T Result { get; set; }
    }

    //constrint to value type 
    public class ValueResult<T> where T : struct 
    {
        public T Result { get; set; }
    }

}