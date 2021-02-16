using System;
using System.Linq;
using UnitTestingExercise;
namespace UnitTestingExercise
{
    public class UnitTestMethods
    {
        // Create an Add method that passes 3 integers
        public int Add(int num1, int num2, int num3)
        {
            return num1 + num2 + num3;
        }

       

        // Create a Subtract method that passes 2 integers
        // Keep track of which number is getting passed as minuend and subtrahend
        public int Subtract(int minuend, int subtrhend)
        {
            return minuend - subtrhend;
        }

        // Create a Multiply method that passes 2 integers
        public int Multiply(int num1, int num2)
        {
            return num1 * num2;
        }

        // Create a Divide method that passes 2 integers
        public int Divide(int num1, int num2)
        {
            //if (num2 == 0)
            //{
            //    return 0;
            //}
            //return num1 / num2;

            return num2 == 0 ? 0 : num1 / num2;
        }

        // Create 2 methods that will utilize the [Fact] tests you wrote
        public string ReturnHelloWorld()
        {
            return "Hello, World!";
        }

        public int[] EvenNumbersFrom_0_100()
        {
            int[] arr = new int[51];
            int x = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = x;
                x += 2;
            }
            return arr;
        }

        // Bonus Method Using Params Keyword
        public decimal Add(params int[] arr)
        {
            if (arr == null || arr.Length == 0)
            {
                return 0;
            }
            else
            {
                return arr.Sum();
            }
        } 
        
    }
}
