using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace RC3Students
{
    public interface IHuman
    {
        //Properties
        int age  {get; set;}
        string name { get; set;}

        //Behaviours
        void Sleeping();
        void Walking();
    }
}
