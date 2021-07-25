using System;
using System.Collections.Generic;
using System.Text;

namespace LogicalPrograms
{
    class PaymentCalcualtion
    {
        public void PaymentMonthly()
        {

            Console.Write("Principal Loan Amount : ");
            int principal = Convert.ToInt32(Console.ReadLine());

            Console.Write("Number of years : ");
            double year = Convert.ToDouble(Console.ReadLine());

            Console.Write("Rate of Interest Per Annum: ");
            double rate = Convert.ToDouble(Console.ReadLine());

            double n = 12 * year;
            double r = rate / (12 * 100);
            double payment = (principal * r) / (1 - Math.Pow((1 + r), (-n)));
            Console.WriteLine("Monthly Payment = " + payment);
        }
    }
}
