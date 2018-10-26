using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RC3Students
{
    class Student
    {
        public string FirstName;
        private string MiddleName;
        public string LastName;

        private int age;
        private string homeCountry;


        //Constructor
        public Student(string _FirstName, string _MiddleName, string _LastName, int _Age, string _HomeCountry)

        {
            FirstName = _FirstName;
            MiddleName = _MiddleName;
            LastName = _LastName;
            age = _Age;
            homeCountry = _HomeCountry;
        }

        //Functions
        public string GetStudentName()
        {
            return FirstName + LastName;
        }

        public string GetHomeCountry()
        {
            return homeCountry;
        }





    }
}
