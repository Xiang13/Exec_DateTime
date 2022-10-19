using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q4
{
	internal class Program
	{
		static void Main(string[] args)
		{
			// Q4 取得本月最後一天
			DateTime today = DateTime.Today;
			int month = today.Month;
			int year = today.Year;

			int days = DateTime.DaysInMonth(year, month);
			DateTime dt4 = new DateTime(year, month, days);

			string value = today.ToString();
			value = dt4.ToString("yyyy/MM/dd");
			Console.WriteLine($"Q4: {value}");
			Console.WriteLine();
		}
	}
}
