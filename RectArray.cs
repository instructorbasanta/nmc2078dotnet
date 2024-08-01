using System;

namespace Unit2{
	class ArrayDemo{
		static void Main(string[] args){
			int[,] input = new int[3,3];
			for(int i = 0; i < 3;i++){
				for(int j = 0; j < 3;j++){
					Console.WriteLine("Enter value for String input  					[{0}{1}]",i,j);
					input[i,j] = Convert.ToInt32(Console.ReadLine());
				}
			}

			for(int i = 0; i < 3;i++){
				for(int j = 0; j < 3;j++){
					Console.WriteLine("input[{0}{1}]={2}",i,j,input[i,j]);
				}
			}			
		}
	}
}