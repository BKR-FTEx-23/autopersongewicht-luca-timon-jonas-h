using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LucaTimonAutogewicht
{
    public class Person
    {
        private double gewicht;

        public Person()
        {
            gewicht = 100;
        }
        public Person (double pGewicht) 
        {
            gewicht =pGewicht;
        }


        public double GetGewicht()
        {
            return gewicht;
        }
    }
}