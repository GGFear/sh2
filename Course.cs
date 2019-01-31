// File:    Course.cs
// Author:  is7327
// Created: вторник, 20 ноября 2018 г. 09:22:21
// Purpose: Definition of Class Course

using System;

public class Course
{
   private string namecourse;
   private float credits;
   private float sam_rab;
   private float prakt_rab;

   public string Namecourse
   {
       get
       {
           return namecourse;
       }

       set
       {
           namecourse = value;
       }
   }

   public float Credits
   {
       get
       {
           return credits;
       }

       set
       {
           credits = value;
       }
   }
   public float Sam_rab
   {
       get
       {
           return sam_rab;
       }

       set
       {
           sam_rab = value;
       }
   }

   public float Prakt_rab
   {
       get
       {
           return prakt_rab;
       }

       set
       {
           prakt_rab = value;
       }
   }

    public Course()
    {
        namecourse = "";
        credits = 0;
        sam_rab = 0;
        prakt_rab = 0;
        //Console.WriteLine("Course was created (default)");
    }

    public Course(string n, int q, int sa, int pr)
    {
        namecourse = n;
        credits = q;
        sam_rab = sa;
        prakt_rab = pr;
        //Console.WriteLine("Course was created (initialization)");
    }

    public Course(Course previousCourse)
    {
        namecourse = previousCourse.namecourse;
        credits = previousCourse.credits;
        sam_rab = previousCourse.sam_rab;
        prakt_rab = previousCourse.prakt_rab;
        //Console.WriteLine("Course created (copy)");
    }
    ~Course()
    {
        //Console.WriteLine("Teacher was destructed");
    }
    public int create_course()
    {
        return 0;
    }

    public void createcourse()
   {
   }
   
   public void editcourse()
   {
   }

}