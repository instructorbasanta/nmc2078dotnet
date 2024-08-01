using System;

namespace Unit2{
	class ArrayDemo{
		static void Main(string[] args){
			string[] input = new string[5];
			for(int i = 0; i < input.Length;i++){
				Console.WriteLine("Enter value for String {0}",i+1);
				input[i] = Console.ReadLine();
			}
			for(int i =0;i<input.Length;i++){
				Console.WriteLine(input[i]);
			}
			
		}
	}
}