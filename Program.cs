using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ver1._1
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.Write("Tkachenko Lena IS-73\n");
            System.Console.Write("Start.\n");

			var smartSystem = new SmartSystem();

	        var teacher = new Teacher();	//Отримання інформації про викладача
	        Console.WriteLine("TEACHER PROFILE");
	        Console.Write("Name: ");
	        teacher.name = Console.ReadLine();
	        Console.Write("Surname: ");
	        teacher.surname = Console.ReadLine();
	        Console.Write("Qualification: ");
	        teacher.qualification = Int32.Parse(Console.ReadLine());

	        smartSystem += teacher; //Внесення викладача до смарт-системи 

	        teacher--;
            Console.WriteLine("\nTeacher {0} {1} was not good at his work, so his qualification got lower: {2}", teacher.name, teacher.surname, teacher.qualification);

			var student = new Student(); //Отримання інформації про студентів
			Console.WriteLine("\nSTUDENT PROFILE");
			Console.Write("Name: ");
            student.name = Console.ReadLine();
			Console.Write("Surname: ");
	        student.surname = Console.ReadLine();
			Console.Write("Rating: ");
			student.rating = Int32.Parse(Console.ReadLine());

	        student++;
			Console.WriteLine("\nStudent {0} {1} was successful and his rating got higher: {2}",student.name,student.surname,student.rating);

	        Console.WriteLine("\nCOURSES\nAdd course to student`s program.");	//реєстрація курсів для студента
			char button;
	        do
	        {
				var individualProgram = new IndividualProgram();
				Console.WriteLine("\nCOURSE");
				Console.Write("Name: ");
		        individualProgram.namecourse = Console.ReadLine();
				Console.Write("Mark: ");
		        individualProgram.mark = Int32.Parse(Console.ReadLine());

		        student += individualProgram;//додавання курсу до профайлу студента

		        Console.WriteLine("\nWould you like to add course to students` individual program?\t(press 'y')");
		        button = Console.ReadKey().KeyChar;
	        } while (button == 'y');

			Console.WriteLine("\nSTUDENT PROFILE"); //виведення профайлу студента
			Console.WriteLine("Name: {0}\nSurname: {1}\nRating: {2}",student.name, student.surname, student.rating);
			Console.WriteLine("Individual programs: ");
	        int numberCourse = 0;
	        foreach (var course in student.individualprogram)
	        {
		        Console.WriteLine("{0} {1}\t Mark: {2}", ++numberCourse,course.namecourse,course.mark );
	        }

			Console.WriteLine("\nFinish");
            Console.ReadLine();
        }
}
        }
