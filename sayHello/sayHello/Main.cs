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
			if ( s=="lai") {
				Console.WriteLine("good!");
				Console.WriteLine("thank you");
				Man my = new Man();
				my.Weight = 70;
				my.Age = 30;
				Console.WriteLine("this is my information");
				Console.WriteLine("age:"+my.Age.ToString()+" weight:"+my.Weight.ToString());
			}
			else
			{
				Console.WriteLine("a bad man!");
			}
			Console.ReadLine();
		}
	}
}
