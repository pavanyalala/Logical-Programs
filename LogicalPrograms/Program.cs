using System;

namespace LogicalPrograms
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to logical programs");
            Console.WriteLine(" Choose a number to execute a program \n1. Fibonacci Series \n2. PerfectNumber \n3. PrimeNumber \n4. ReverseNumber \n5. Calender \n6. PaymentCalculation \n7. TeperatureConversion ");
            int choice = Convert.ToInt32(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    FibonacciSeries fibonacciSeries = new FibonacciSeries();
                    fibonacciSeries.Fibonacci();
                    break;

                case 2:
                    PerfectNumber perfectNumber = new PerfectNumber();
                    perfectNumber.PerfectNum();
                    break;

                case 3:
                    PrimeNumber primeNumber = new PrimeNumber();
                    primeNumber.PrimeNum();
                    break;

                case 4:
                    ReverseNumber reverseNumber = new ReverseNumber();
                    reverseNumber.ReverseNum();
                    break;

                case 5:
                    Calander calander = new Calander();
                    calander.DayMonthYear();
                    break;

                case 6:
                    PaymentCalcualtion paymentCalcualtion = new PaymentCalcualtion();
                    paymentCalcualtion.PaymentMonthly();
                    break;

                case 7:
                    TempaeratureConversion tempaeratureConversion = new TempaeratureConversion();
                    tempaeratureConversion.TempConvert();
                    break;

                default:
                    Console.WriteLine("Choice is Out of range");
                    break;
            }
            
        }
    }
}
