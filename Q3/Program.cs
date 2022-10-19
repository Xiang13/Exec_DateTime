using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q3
{
	internal class Program
	{
		static void Main(string[] args)
		{
			// Q3 取得本月一日
			DateTime today = DateTime.Today;
			var fristhDay = today.ToString("yyyy/MM//01");
			Console.WriteLine($"Q3: {fristhDay}");
			Console.WriteLine();
		}
	}
}
