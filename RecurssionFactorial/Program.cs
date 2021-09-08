using System;

namespace RecurssionFactorial
{
    class Program
    {
        static void Main(string[] args)
        {
            //Take User Input Number
            Console.WriteLine("Enter The Number");
            int num = Convert.ToInt32(Console.ReadLine());
            //Declare Recurssion Function
            long fact = RecurssionFactorial(num);
            Console.WriteLine("The Factorial of Number Is: {0}", fact);
        }
        //Call Recurssion Function Itself
        private static long RecurssionFactorial(int num)
        {
            if (num == 1)
            {
                return 1;
            }
            return num * RecurssionFactorial(num - 1);
        }
    }
}
