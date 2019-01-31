// File:    Classroom.cs
// Author:  is7327
// Created: вторник, 20 ноября 2018 г. 09:22:19
// Purpose: Definition of Class Classroom

using System;

public class Classroom
{
   private string name;
   private string task;

   public string Name
   {
       get
       {
           return name;
       }
       set
       {
           name = value;
       }
   }
   public string Task
   {
       get
       {
           return task;
       }
       set
       {
           task = value;
       }
   }

    public Classroom()
    {
        name = "";
        task = "";
        //Console.WriteLine("Classroom was created (default)");
    }

    public Classroom(string a, string b)
    {
        name = a;
        task = b;
        //Console.WriteLine("Classroom was created (initialization)");
    }

    public Classroom(Classroom previousClassroom)
    {
        name = previousClassroom.name;
        task = previousClassroom.task;
        //Console.WriteLine("Classroom created (copy)");
    }
    ~Classroom()
    {
        //Console.WriteLine("Classroom was destructed");
    }

    public void creare()
   {
   }
   
   public void registraition()
   {
   }

}