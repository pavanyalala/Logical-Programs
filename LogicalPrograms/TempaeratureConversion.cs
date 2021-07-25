using System;
using System.Collections.Generic;
using System.Text;

namespace LogicalPrograms
{
    class TempaeratureConversion
    {
        public void TempConvert()
        {
            Console.WriteLine(" Select  1 to convert Celcius to Fahrenheit , 2 for Reverse Operation");
            int choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Console.WriteLine("Enter  the Temperature in Celcius: ");
                    double celcius = Convert.ToInt32(Console.ReadLine());
                    double convert1 = (celcius * 9 / 5) + 32;
                    Console.WriteLine("Converted to Fahrenheit : " + convert1);
                    break;
                case 2:
                    Console.WriteLine("Enter the Temperature in Fahrenheit: ");
                    double fahrenheit = Convert.ToInt32(Console.ReadLine());
                    double convert2 = (fahrenheit - 32) * 5 / 9;
                    Console.WriteLine("Converted to Celcius : " + convert2);
                    break;
            }
        }
    }
}
