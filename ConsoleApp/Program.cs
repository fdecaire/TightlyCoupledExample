using System;
using MyClasses;

namespace ConsoleApp
{
	class Program
	{
		static void Main(string[] args)
		{
			var myRootClass = new MyRootClass();

			myRootClass.Increment();

			Console.WriteLine(myRootClass.CountExceeded());
			Console.ReadKey();
		}
	}
}
