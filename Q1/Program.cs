using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q1
{
	internal class Program
	{
		static void Main(string[] args)
		{
			// Q1 計算三天後 DVD 應歸還時間
			DateTime today = DateTime.Today;
			var thirdDays = today.AddDays(3);
			Console.WriteLine($"Q1: {thirdDays}");
			Console.WriteLine();
		}
	}
}
