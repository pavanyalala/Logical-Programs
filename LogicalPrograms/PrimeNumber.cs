using System;
using System.Collections.Generic;
using System.Text;

namespace LogicalPrograms
{
    class PrimeNumber
    {
        public void PrimeNum()
        {

            Console.Write("Enter a Number : ");
            int number = Convert.ToInt32(Console.ReadLine());
            bool IsPrime = true;
            for (int i = 2; i < number / 2; i++)
            {
                if (number % i == 0)
                    IsPrime = false;
                    break;
            }
            if (IsPrime)
                Console.WriteLine(" Entered Number is a Prime.");
            else
                Console.WriteLine(" EnteredNumber is not a Prime.");
        }
    }
}
