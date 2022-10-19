using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q2
{
	internal class Program
	{
		static void Main(string[] args)
		{
			// Q2 計算圖書下個月歸還時間
			DateTime today = DateTime.Today;
			var nextMonth = today.AddMonths(1);

			Console.WriteLine($"Q2: {nextMonth}");
			Console.WriteLine();
		}
	}
}
