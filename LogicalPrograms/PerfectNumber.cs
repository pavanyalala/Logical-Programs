using System;
using System.Collections.Generic;
using System.Text;

namespace LogicalPrograms
{
    class PerfectNumber
    {
        /// <summary>
        /// below method checks number is perfect or not 
        /// </summary>
        public void PerfectNum()
        {
            int number, sum = 0, perfectNumber;
            Console.Write("Enter the Number : ");
            number = Convert.ToInt32(Console.ReadLine());
            perfectNumber = number;
            for (int i = 1; i < number; i++)
            {
                if (number % i == 0)
                    sum += i;
            }    
            
            if (sum == perfectNumber)
                Console.WriteLine("Entered number is a perfect number");
            else
                Console.WriteLine("Entered number is not a perfect number");
        }
    }
}
