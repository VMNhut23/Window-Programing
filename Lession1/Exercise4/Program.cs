﻿using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace Exercise4
{
	class Program
	{
		static void Main(string[] args)
		{
			// This will create a file named tmp.txt
			// at the specified location
			StreamWriter sw = new StreamWriter("C:\\Users\\pc\\Downloads\\C#Form/tmp.txt");
			// To write on the console screen
			Console.WriteLine("Enter the Text that you want to write on File");
			// To read the input from the user
			string str = Console.ReadLine();
			// To write a line in buffer
			sw.WriteLine(str);
			// To write in output stream
			sw.Flush();
			// To close the stream
			sw.Close();
			Console.ReadKey();
		}
	}
}
