// File:    Student.cs
// Author:  is7327
// Created: вторник, 20 ноября 2018 г. 09:22:11
// Purpose: Definition of Class Student

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Student
{
    public string name { get; set; }
    public string surname { get; set; }
    public int rating { get; set; }
	public List <IndividualProgram> individualprogram { get; set; }

	//private string name;
	//private string surname;
	//private int rating;
	//private int s1 = 1;


	public Student()
    {
        name = "";
        surname = "";
        rating = 0;

        individualprogram = new List<IndividualProgram>();
        IndividualProgram newIndividualProgram = new IndividualProgram();
       
        //Console.WriteLine("Student was created (default)");
    }

	public Student(string n, string sn, int r, string na, float ma)
	{

		name = n;
		surname = sn;
		rating = r;
	}
        //Console.WriteLine("Student was created (initialization)");

    public Student(Student previousStudent)
    {
        name = previousStudent.name;
        surname = previousStudent.surname;
        rating = previousStudent.rating;

        individualprogram = previousStudent.individualprogram;
      
        //Console.WriteLine("Student created (copy)");
    }
    ~Student()
    {
        //Console.WriteLine("Student was destructed");
    }

    public int enter_university()
    {
        // TODO: implement
        return 0;
    }

    public void examination()
   {
   }

	public static Student operator +(Student student, IndividualProgram individualProgram) //додавання курсу до профайлу студента
	{
		student.individualprogram.Add(individualProgram);
		return student;
	}

	public static Student operator -(Student student, IndividualProgram individualProgram) //видалення курса з профайла студента
	{
		student.individualprogram.Remove(individualProgram);
		return student;
	}

	public static Student operator ++(Student student) //підвищення оцінки 
	{
		student.rating++;
		return student;
	}

	public static Student operator --(Student student) //зниження оцінки
	{
		student.rating--;
		return student;
	}


}

