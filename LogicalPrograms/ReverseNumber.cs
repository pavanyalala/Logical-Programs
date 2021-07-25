using System;
using System.Collections.Generic;
using System.Text;

namespace LogicalPrograms
{
    class ReverseNumber
    {
        public void ReverseNum()
        {
            int number, reverse = 0, remainder;
            Console.Write("Enter a number : ");
            number = int.Parse(Console.ReadLine());
            while (number != 0)
            {
                remainder = number % 10;
                reverse = reverse * 10 + remainder;
                number = number / 10;
            }
            Console.Write("Reversed Number: " + reverse);
        }
    }
}
