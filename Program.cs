using System;
using System.IO;

namespace evenoroddsums
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			int num = Convert.ToInt32 (Console.ReadLine ());
			int d = 0;
			int ed = 0;
			int od = 0;
			for (int i = 1 ; i <= num; i++)
			if (num % i == 0)
			{
				d++;
				if (d % 2 == 0)
				{
					ed++;
				}
				else
				{
					od++;
				}
			}
			Console.WriteLine (" evendivisors = {0} odddivisors = {1}", ed, od);
		}
	}
}