using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exec_For02
{
	internal class Program
	{
		static void Main(string[] args)
		{
			for (int length = 1; length <= 10; length++)
			{
				string line = string.Empty;
				if (length >= 2)
				{
					int add = (length - 1);
					line = new string('*', add);
				}
				Console.WriteLine(new string('*', length).PadLeft(10, ' ') + line);
			}

		}
	}
}
