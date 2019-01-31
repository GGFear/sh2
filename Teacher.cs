// File:    Teacher.cs
// Author:  is7327
// Created: вторник, 20 ноября 2018 г. 09:22:14
// Purpose: Definition of Class Teacher

using System;

public class Teacher
{
	public string subject { get; set; }
	public int qualification { get; set; }
	public string name { get; set; }
	public string surname { get; set; }

         public Teacher()
    {
        subject = "";
        qualification = 0;
        name = "";
        surname = "";
     
        //Console.WriteLine("Teacher was created (default)");
    }

    public Teacher(string s, int q, string n, string sn)
    {
        subject = s;
        qualification = q;
        name = n;
        surname = sn;
   
        //Console.WriteLine("Teacher was created (initialization)");
    }

    public Teacher(Teacher previousTeacher)
    {
        subject = previousTeacher.subject;
        qualification = previousTeacher.qualification;
        name = previousTeacher.name;
        surname = previousTeacher.surname;
        //Console.WriteLine("Teacher created (copy)");
    }
    ~Teacher()
    {
        Console.WriteLine("Teacher was destructed");
    }
    public int create_course()
    {
        return 0;
    }

    public void checkexam()
   {
   }
   
   public void checktests()
   {
   }
   
   public void checkhw()
   {
   }
   
   public void helpstudents()
   {
   }
   
   public void createprograme()
   {
   }

   public static Teacher operator ++(Teacher teacher) //збільшення рівня кваліфікації
   {
	   teacher.qualification++;
	   return teacher;
   }

	public static Teacher operator --(Teacher teacher) //зменшення рівня кваліфікації
	{
		teacher.qualification--;
		return teacher;
	}
}