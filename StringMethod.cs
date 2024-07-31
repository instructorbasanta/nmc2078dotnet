using System;

namespace Unit2{
	class StringMethod{
		static void Main(string[] args){
			String name = "Basanta Chapagain";
			String name1 = "basanta chapagain";
			Console.WriteLine(name.Length);
			Console.WriteLine(name[5]);
			Console.WriteLine(String.Compare(name,name1));
		}
	}
}