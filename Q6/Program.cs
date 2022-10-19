using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q6
{
	internal class Program
	{
		static void Main(string[] args)
		{
			// Q6 根據日期, 傳回今天是本月的上旬, 中旬或下旬

			DateTime today = DateTime.Today;
			int day = today.Day;
			if (day <= 10)
			{
				Console.WriteLine("Q6: 上旬");
			}
			else if (day <= 20)
			{
				Console.WriteLine("Q6: 中旬");
			}
			else
			{
				Console.WriteLine("Q6: 下旬");
			}
			Console.WriteLine();
		}
	}
}
