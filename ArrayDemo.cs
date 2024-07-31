using System;

namespace Unit2{
	class ArrayDemo{
		static void Main(string[] args){
			char[] vowels = new char[5];
			vowels[0] = 'A';
			vowels[1] = 'E';
			vowels[2] = 'I';
			vowels[3] = 'O';
			vowels[4] = 'U';
			for(int i =0;i<vowels.Length;i++){
				Console.WriteLine(vowels[i]);
			}
			
		}
	}

}