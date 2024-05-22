using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LucaTimonAutogewicht
{
    public class Person
    {
        private int gewicht;

        public Person()
        {
            gewicht = 100;
        }

        public int GetGewicht()
        {
            return gewicht;
        }
    }
}