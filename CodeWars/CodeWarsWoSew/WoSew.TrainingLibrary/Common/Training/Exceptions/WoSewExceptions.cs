using System;
using System.Runtime.CompilerServices;
using System.Security.Policy;

namespace WoSew.TrainingLibrary.Test.Common.Training.Exceptions
{
    public class WoSewExceptions
    {


        public void TryCatchFinally()
        {
            int x, y, z;
            x = 10;
            y = 0;
            
            try
            {
                z = x / y;
            }
            catch
            {
                Console.WriteLine("Please, do not divie by zero");
            }
            finally
            {
                Console.WriteLine("TADAM! --Finally block--");
            }
        }

        public void TryCatchFinallyException()
        {
            int zero = 0;
            try
            {
                var x = 10 / zero;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                var text = e.Message;
            }
        }

        public void SelectiveExceptions()
        {

            string[] exampleString = new string[5];

            try
            {
                exampleString[10] = "Error";
            }
            catch (IndexOutOfRangeException)
            {
                Console.WriteLine("Index out of range");
            }
            catch
            {
                Console.WriteLine("Another error");
            }



        }

        public void ThrowExceptions()
        {
            //Throw Exceptions
            try
            {
                throw new IndexOutOfRangeException();
            }
            catch (Exception e)
            {
                Console.WriteLine("Wojtek Throw exception");

            }
        }

    }
}