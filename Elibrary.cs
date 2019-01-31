// File:    Elibrary.cs
// Author:  is7327
// Created: вторник, 20 ноября 2018 г. 09:22:25
// Purpose: Definition of Class Elibrary

using System;

public class Elibrary
{
   public string videolecture { get; set; }
   public string vebinari { get; set; }
   public string prakt_zavd { get; set; }
   public string sam_zavd { get; set; }

    public Elibrary()
    {
        videolecture = "";
        vebinari = "";
        prakt_zavd = "";
        sam_zavd = "";
        //Console.WriteLine("Elibrary was created (default)");
    }

    public Elibrary(string a, string v, string s, string p)
    {
        videolecture = a;
        vebinari = v;
        sam_zavd = s;
        prakt_zavd = p;
        //Console.WriteLine("Elibrary was created (initialization)");
    }

    public Elibrary(Elibrary previousElibrary)
    {
        videolecture = previousElibrary.videolecture;
        vebinari = previousElibrary.vebinari;
        sam_zavd = previousElibrary.sam_zavd;
        prakt_zavd = previousElibrary.prakt_zavd;
        //Console.WriteLine("Elibrary created (copy)");
    }
    ~Elibrary()
    {
        //Console.WriteLine("Elibrary was destructed");
    }

    public void use()
   {

   }
   
   public void edit()
   {

   }

}