using System;
namespace Unit2 {
	public class Student {
		public string StudentName;
	}
	class DemoData {
		public static void ChangeValueType(int x){
			x = 200;
			Console.WriteLine(x);
		}
		public static void ChangeReferenceType(Student ram){
			ram.StudentName = "Ram Bahadur Thapa";
			Console.WriteLine(ram.StudentName);
		}
		static void Main(string[] args){
			int i = 100;
			Console.WriteLine(i);
			DemoData.ChangeValueType(i);
			Console.WriteLine(i);

			Student rajesh = new Student();
			rajesh.StudentName = "Rajesh Thapa";
			Console.WriteLine(rajesh.StudentName);	
			DemoData.ChangeReferenceType(rajesh);
			Console.WriteLine(rajesh.StudentName);			
		}
	}
}