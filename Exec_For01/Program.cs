using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exec_For01
{
	internal class Program
	{
		static void Main(string[] args)
		{
			for (int i = 0; i <= 5; i++)
			{
				int countOfEmpty = i;
				int countOfStar = 5 - i;

				string row = new string(' ', countOfEmpty) + new string('*', countOfStar);
				Console.WriteLine(row);
			}
		}
	}
}
