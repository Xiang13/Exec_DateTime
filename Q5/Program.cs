using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q5
{
	internal class Program
	{
		static void Main(string[] args)
		{
			// Q5 列出指定年份的每一個星期日

			DateTime today = DateTime.Today;
			// 判斷是否為閏年, True: 366 天  False: 365 天
			int year = 2022;
			int yearNums = (DateTime.IsLeapYear(year) == true) ? 366 : 365;

			// 找出第一天
			DateTime firstDay = new DateTime(year, 01, 01);
			DayOfWeek weekDay = firstDay.DayOfWeek;
			int week = (int)weekDay;

			// 找出第一個星期日
			if (weekDay != DayOfWeek.Sunday)
			{
				int diffDay = 7 - week;
				DateTime sunday = firstDay.AddDays(diffDay);
				Console.WriteLine(sunday.ToString("yyyy/MM/dd"));

				// 找出每一個星期日
				for (int i = week; i < yearNums - week; i ++ 7)
				{
					sunday = sunday.AddDays(7);
					var value = sunday.ToString("yyyy/MM/dd");
					Console.WriteLine(value);
				}
				Console.WriteLine();
			}
		}
	}
}
