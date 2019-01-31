// File:    SmartSystem.cs
// Author:  is7327
// Created: вторник, 20 ноября 2018 г. 09:22:05
// Purpose: Definition of Class SmartSystem

using System;

public class SmartSystem
{
    
    public string name { get; set; } 
   
    public System.Collections.ArrayList teacher { get; set; }
    public System.Collections.ArrayList classroom { get; set; }
    public System.Collections.ArrayList elibrary { get; set; }

    public SmartSystem()
    {
        name = "";

        classroom = new System.Collections.ArrayList();
        Classroom newClassroom = new Classroom();

        course = new System.Collections.ArrayList();
        Course newCourse = new Course();

        elibrary = new System.Collections.ArrayList();
        Elibrary newElibrary = new Elibrary();

        student = new System.Collections.ArrayList();
        Student newStudent = new Student();
        student.Add(newStudent);

        teacher = new System.Collections.ArrayList();
        Teacher newTeacher = new Teacher();
        teacher.Add(newTeacher);

        //Console.WriteLine("SmartSystem was created (default)");
    }

    public SmartSystem(string n, string na, string sn, int r, string nam, float ma, string name, int q, string sur, string sub, string a, string b, string g, int c, int sa, int pr, string av, string v, string s, string p)
    {
        name = n;

        classroom = new System.Collections.ArrayList();
        Classroom newClassroom = new Classroom(a, b);

        course = new System.Collections.ArrayList();
        Course newCourse = new Course(g,c,sa,pr);

        elibrary = new System.Collections.ArrayList();
        Elibrary newElibrary = new Elibrary(av,v,s,p);

        student = new System.Collections.ArrayList();
        Student newStudent = new Student(n,na,r,nam,ma);
        student.Add(newStudent);

        teacher = new System.Collections.ArrayList();
        Teacher newTeacher = new Teacher(name, q, sur, sub);
        teacher.Add(newTeacher);

        //Console.WriteLine("University was created (initialization)");
    }

    public SmartSystem(SmartSystem ss)
    {
        name = ss.name;
        classroom = ss.classroom;
        course = ss.course;
        elibrary = ss.elibrary;
        student = ss.student;
        teacher = ss.teacher;

        //Console.WriteLine("University was created (copy)");
    }
    ~SmartSystem()
    {
        Console.WriteLine("University was destructed");
    }
    /// <summary>
    /// Property for collection of Teacher
    /// </summary>
    /// <pdGenerated>Default opposite class collection property</pdGenerated>
    public System.Collections.ArrayList Teacher
   {
      get
      {
         if (teacher == null)
            teacher = new System.Collections.ArrayList();
         return teacher;
      }
      set
      {
         RemoveAllTeacher();
         if (value != null)
         {
            foreach (Teacher oTeacher in value)
               AddTeacher(oTeacher);
         }
      }
   }
   
   /// <summary>
   /// Add a new Teacher in the collection
   /// </summary>
   /// <pdGenerated>Default Add</pdGenerated>
   public void AddTeacher(Teacher newTeacher)
   {
      if (newTeacher == null)
         return;
      if (this.teacher == null)
         this.teacher = new System.Collections.ArrayList();
      if (!this.teacher.Contains(newTeacher))
         this.teacher.Add(newTeacher);
   }
   
   /// <summary>
   /// Remove an existing Teacher from the collection
   /// </summary>
   /// <pdGenerated>Default Remove</pdGenerated>
   public void RemoveTeacher(Teacher oldTeacher)
   {
      if (oldTeacher == null)
         return;
      if (this.teacher != null)
         if (this.teacher.Contains(oldTeacher))
            this.teacher.Remove(oldTeacher);
   }
   
   /// <summary>
   /// Remove all instances of Teacher from the collection
   /// </summary>
   /// <pdGenerated>Default removeAll</pdGenerated>
   public void RemoveAllTeacher()
   {
      if (teacher != null)
         teacher.Clear();
   }
   public System.Collections.ArrayList student;
   
   /// <summary>
   /// Property for collection of Student
   /// </summary>
   /// <pdGenerated>Default opposite class collection property</pdGenerated>
   public System.Collections.ArrayList Student
   {
      get
      {
         if (student == null)
            student = new System.Collections.ArrayList();
         return student;
      }
      set
      {
         RemoveAllStudent();
         if (value != null)
         {
            foreach (Student oStudent in value)
               AddStudent(oStudent);
         }
      }
   }
   
   /// <summary>
   /// Add a new Student in the collection
   /// </summary>
   /// <pdGenerated>Default Add</pdGenerated>
   public void AddStudent(Student newStudent)
   {
      if (newStudent == null)
         return;
      if (this.student == null)
         this.student = new System.Collections.ArrayList();
      if (!this.student.Contains(newStudent))
         this.student.Add(newStudent);
   }
   
   /// <summary>
   /// Remove an existing Student from the collection
   /// </summary>
   /// <pdGenerated>Default Remove</pdGenerated>
   public void RemoveStudent(Student oldStudent)
   {
      if (oldStudent == null)
         return;
      if (this.student != null)
         if (this.student.Contains(oldStudent))
            this.student.Remove(oldStudent);
   }
   
   /// <summary>
   /// Remove all instances of Student from the collection
   /// </summary>
   /// <pdGenerated>Default removeAll</pdGenerated>
   public void RemoveAllStudent()
   {
      if (student != null)
         student.Clear();
   }
   public System.Collections.ArrayList course;
   
   /// <summary>
   /// Property for collection of Course
   /// </summary>
   /// <pdGenerated>Default opposite class collection property</pdGenerated>
   public System.Collections.ArrayList Course
   {
      get
      {
         if (course == null)
            course = new System.Collections.ArrayList();
         return course;
      }
      set
      {
         RemoveAllCourse();
         if (value != null)
         {
            foreach (Course oCourse in value)
               AddCourse(oCourse);
         }
      }
   }
   
   /// <summary>
   /// Add a new Course in the collection
   /// </summary>
   /// <pdGenerated>Default Add</pdGenerated>
   public void AddCourse(Course newCourse)
   {
      if (newCourse == null)
         return;
      if (this.course == null)
         this.course = new System.Collections.ArrayList();
      if (!this.course.Contains(newCourse))
         this.course.Add(newCourse);
   }
   
   /// <summary>
   /// Remove an existing Course from the collection
   /// </summary>
   /// <pdGenerated>Default Remove</pdGenerated>
   public void RemoveCourse(Course oldCourse)
   {
      if (oldCourse == null)
         return;
      if (this.course != null)
         if (this.course.Contains(oldCourse))
            this.course.Remove(oldCourse);
   }
   
   /// <summary>
   /// Remove all instances of Course from the collection
   /// </summary>
   /// <pdGenerated>Default removeAll</pdGenerated>
   public void RemoveAllCourse()
   {
      if (course != null)
         course.Clear();
   }

   public void registration()
   {

   }

   public void autorization()
   {

   }

   public void diploma()
   {

   }
   //public Elibrary elibrary;
   //public Classroom classroom;

	public static SmartSystem operator +(SmartSystem system, Teacher teacher) //додавання профайлу викладача до системи
	{
		system.teacher.Add(teacher);
		return system;
	}

	public static SmartSystem operator -(SmartSystem system, Teacher teacher) //видалення профайлу викладача з системи
	{
		system.teacher.Remove(teacher);
		return system;
	}

	public static SmartSystem operator +(SmartSystem system, Classroom classroom) //додавання класруму до системи
	{
		system.classroom.Add(classroom);
		return system;
	}

	public static SmartSystem operator -(SmartSystem system, Classroom classroom) //видалення класруму з системи
	{
		system.classroom.Remove(classroom);
		return system;
	}

	public static SmartSystem operator +(SmartSystem system, Elibrary elibrary) //додавання е-бібліотеки до системи
	{
		system.elibrary.Add(elibrary);
		return system;
	}

	public static SmartSystem operator -(SmartSystem system, Elibrary elibrary) //видалення бібліотеки з системи
	{
		system.elibrary.Remove(elibrary);
		return system;
	}
}

  /*public System.Collections.ArrayList SmartSystem()
   {
      if (smartsystem == null)
         smartsystem = new System.Collections.ArrayList();
      return smartsystem;
   }*/