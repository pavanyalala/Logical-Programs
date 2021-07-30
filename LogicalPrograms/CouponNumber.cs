using System;
using System.Collections.Generic;
using System.Text;

namespace LogicalPrograms
{
    class CouponNumber
    {
        public void CouponNum()
        {
			int count = 0;
			Random random = new Random();
			Console.WriteLine("Enter the number of coupons");
			int coupons = Convert.ToInt32(Console.ReadLine());
			int[] array = new int[coupons + 1];
			for (int i = 0; i < coupons + 1; i++)
			{ array[i] = random.Next(100); }

			for (int i = 0; i < coupons; i++)
			{
				Console.WriteLine(array[i]);
				if (array[i] == array[i + 1])
				{
					count--;
				}
				else
				{
					count++;
				}

			}
			Console.WriteLine("Number of Coupons : " + count);

		}
    }
}
