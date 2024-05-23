using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LucaTimonAutogewicht
{
    public class Person
    {
        private double gewicht;
        private string name;
        public Person()
        {
            name = "John Doe";
            gewicht = 100;
        }

        public Person(string pName, double pGewichtPerson)
        {
            name = pName;
            gewicht = pGewichtPerson;
        }

        public double GetGewicht()
        {
            return gewicht;
        }
        public string GetName()
        {
            return name;
        }
    }
}