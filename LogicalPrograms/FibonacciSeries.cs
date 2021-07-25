using System;
using System.Collections.Generic;
using System.Text;

namespace LogicalPrograms
{
    class FibonacciSeries
    {
        /// <summary>
        /// Method prints 1st num=0 2nd num =1 3rdnum =1st+2nd......
        /// </summary>
        public void Fibonacci()
        {
            int number1 = 0, number2 = 1, number3 = 0;
            Console.WriteLine("Enter Length of the Series");
            int length = Convert.ToInt32(Console.ReadLine());
            Console.Write(number1 + " " + number2 + " ");  //Printing 0 and 1
            for (int i = 2; i < length; i++)   
            {
                number3 = number1 + number2;
                Console.Write(number3 + " ");
                number1 = number2;
                number2 = number3;
            }
        }
    }
}
