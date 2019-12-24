
using System;

namespace CGPA_calculator
{
	class Program
	{
		public static void Main(string[] args)
		{
			Console.WriteLine("Hello World!");
			double CGPA = 0;
			double totGrades = 0;
			double totUnits = 0;
			Console.WriteLine("Enter the number of semesters :");
			int semesters = Int32.Parse(Console.ReadLine());
			
			for(int i = 1 ; i <= semesters ; i++) {
				double GPA = 0;
				double sUnit = 0;
				double sGrade = 0;
				Console.WriteLine("Enter the number of courses offered in semester " + i + ": ");
				int courses = Int32.Parse(Console.ReadLine());
				double calc = 0;
				for(int j = 0 ; j < courses ; j++) {
					Console.WriteLine("Enter the course code");
					String courseCode = Console.ReadLine();
					double mark = 0;
					Console.WriteLine("Enter grade: ");
					double grade = Convert.ToDouble(Console.ReadLine());
					Console.WriteLine("Enter unit: ");
					double unit = Convert.ToDouble(Console.ReadLine());
					totUnits += unit;
					sUnit += unit;
					if(grade >= 70) {
						mark = 5;
					} else if(grade >= 60 && grade <= 69) {
						mark = 4;
					} else if(grade >= 50 && grade <= 59) {
						mark = 3;
					} else if(grade >= 45 && grade <= 49) {
						mark = 2;
					} else if(grade >= 40 && grade <= 44) {
						mark = 1;
					} else { mark = 0; }
					
					calc = mark * unit;
					totGrades += calc;
					sGrade += calc;
				}
				
				GPA = sGrade/sUnit;
				Console.WriteLine("Your GPA for this semester is: " + Math.Round(GPA,2));
				
				if(i % 2 == 0) {
					CGPA = totGrades/totUnits;
					Console.WriteLine("Your CGPA after year " + (i/2) + " is " + Math.Round(CGPA,2));
				}
			}
			CGPA = totGrades/totUnits;
			Console.WriteLine("Your Cumulative GPA is: " + Math.Round(CGPA,2));
			
			// TODO: Implement Functionality Here
			
			//Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
		
	}
}