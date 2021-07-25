using System;
using System.Collections.Generic;
using System.Text;

namespace LogicalPrograms
{
    class Calander
    {
        public void DayMonthYear()
        {
            Console.WriteLine("Enter day: ");
            int day = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Month: ");
            int month = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Year: ");
            int year = Convert.ToInt32(Console.ReadLine());

            int yearOne = year - (14 - month) / 12;
            int x = yearOne + (yearOne / 4) - (yearOne / 100) + (yearOne / 400);
            int monthOne = month + (12 * ((14 - month) / 12)) - 2;
            int dayOne = (day + x + ((31 * monthOne) / 12)) % 7;

            Console.WriteLine("Day of Week: " + dayOne);

            switch (dayOne)
            {
                case 0:
                    Console.WriteLine("Given date is SUNDAY");
                    break;
                case 1:
                    Console.WriteLine("Given date is MONDAY");
                    break;
                case 2:
                    Console.WriteLine("Given date is TUESDAY");
                    break;
                case 3:
                    Console.WriteLine("Given date is WEDNESDAY");
                    break;
                case 4:
                    Console.WriteLine("Given date is THURSDAY");
                    break;
                case 5:
                    Console.WriteLine("Given date is FRIDAY");
                    break;
                case 6:
                    Console.WriteLine("Given date is SATURDAY");
                    break;
            }
        }
    }
}
