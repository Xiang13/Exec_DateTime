using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q7
{
	internal class Program
	{
		static void Main(string[] args)
		{
			// Q7 根據不同時間, 傳回不同問安方式

			DateTime today = DateTime.Today;
			DateTime now = DateTime.Now;
			int hour = now.Hour;
			if (hour < 6 || hour < 12)
			{
				Console.WriteLine("Q7: 早安");
			}
			else if (hour < 18)
			{
				Console.WriteLine("Q7: 午安");
			}
			else
			{
				Console.WriteLine("Q7: 晚安");
			}
			Console.WriteLine();
		}
	}
}
