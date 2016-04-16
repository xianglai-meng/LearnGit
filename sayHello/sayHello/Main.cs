using System;

namespace sayHello
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			Console.WriteLine ("Hello World!");
			Console.WriteLine("input a word,please!");
			string s = Console.ReadLine().ToString();
			if ( s!= null) {
				Console.WriteLine("good!");
			}
			Console.ReadLine();
		}
	}
}
