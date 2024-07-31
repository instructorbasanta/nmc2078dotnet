using System;

namespace Unit2{
	class StringDemo{
		static void Main(string[] args){
			string firstName = "Ram";
			string lastName = "Kumar";
			string cid = "120";
			Console.WriteLine($"Name: {firstName} {lastName}                        CID: {cid}");
			Console.WriteLine("Name: " + firstName + " " +                         lastName + " CID: " + cid);
		}
	}

}