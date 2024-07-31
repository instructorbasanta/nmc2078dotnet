using System;

namespace Unit2{
	class DefaultValueExample {
		static void Main(string[] args){
			int i = default(int);
			Console.WriteLine("Default value of integer is " + i);
		}
	}
}