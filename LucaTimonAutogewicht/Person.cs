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
        private double führerscheinID;

        public Person(string pName, double pGewichtPerson, double pFührerscheinID)
        {
            name = pName;
            gewicht = pGewichtPerson;
            führerscheinID = pFührerscheinID;
        }
        public Person(string pName, double pGewichtPerson):this (pName,pGewichtPerson,123)
        {
           
        }


        public Person() : this("John Doe", 100,551)
        {
            // name = "John Doe";
            // gewicht = 100;
        }

        public double Gewicht
        {
            get { return gewicht; } 
            set { gewicht = value; }
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