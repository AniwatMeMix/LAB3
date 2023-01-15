using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LAB3
{
    internal class Student
    {
        public string name;
        public string ID;
        public int year;
        public int iHigh;
        public string Grade;
        public string Major;
        public int Num;


        public int student
        {
            get { return Num + 1 ; }
        }
        public string Name
        {
            get { return this.name; }
        }
        public string id
        {
            get { return this.ID; }
        }
        public int Birthyear
        {
            get { return this.year; }
        }
        public int High
        {
            get { return this.iHigh; }
        }
        public string grade
        {
            get { return this.Grade; }
        }
        public string major
        {
            get { return this.Major; }
        }
       

        //constructor
        public Student(int Num, string name, string ID, int birthYear, int High, String Grade, string Major)
        {
            this.name = name;
            this.ID = ID;
            this.year = birthYear;
            this.iHigh = High;
            this.Grade = Grade;
            this.Major = Major;
            
            
        }

     

        // cinstructor
        // public Student(string name,int age ) {
        //  this._name = name;
        //  this._age = age;
    }

       // public string myAge()
      //  {
           // int age = 2023 - _age;
           // return "18";
      //  }

    //}
}
