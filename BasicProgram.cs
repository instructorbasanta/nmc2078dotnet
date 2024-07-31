//name,address,email,phone,roll,program
using System;

namespace Unit2{
	class BasicProgram{
		static void Main(string[] args){
			Console.WriteLine("NCM basic .net app");
			Console.WriteLine("\nEnter your name?\t");
			//declare variable
			string name = Console.ReadLine();
			Console.WriteLine("Hello "  + name);
			Console.WriteLine("\nEnter first number?\t");
			int a = int.Parse(Console.ReadLine());
			Console.WriteLine("\nEnter second number?\t");
			int b = int.Parse(Console.ReadLine());
			Console.WriteLine("\nSum is \t" + (a+b));
		}
	}
}