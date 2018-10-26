using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Homework2Dog
{
    public class Session2DogClass
    {
        public string Name;
        public string Owner;
        private string Gender;

        private int Age;
        private double Weight;


        //Constructor
        public void Dog(string _Name, string _Owner, string _Gender, int _Age, double _Weight)

        {
            Name = _Name;
            Owner = _Owner;
            Gender = _Gender;
            Age = _Age;
            Weight = _Weight;
        }

        //Functions
        public string ItsName()
        {
            return Name;
        }

        public string BiologicalCharacteristics()
        {
            if (Age == 8)
            {
                return "It is an " + Age + "-old " + Gender + "dog";
            }
            else
            {
                return "It is a " + Age + "-old " + Gender + "dog";
            }
        }

    }
}