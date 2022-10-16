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
			for (int i = 5; i >= 1; i--)
			{
				int countOfStar = i;
				int countOfEmpty = 5 - i;
				
				string row = new string('*', countOfStar) + new string(' ', countOfEmpty);
				Console.WriteLine(row);
			}
		}
	}
}
