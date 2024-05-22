using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LucaTimonAutogewicht
{
    public class Auto
    {
        private int gewicht;
        private int personen;

        public  Auto() 
        {
            gewicht = 1000;
            personen = 4;
        }

        public int GetGewicht() 
        { 
            return gewicht;
        }

        public int GetPersonen()
        {
            return personen;
        }

        public override string ToString()
        {
            return "";
        }
    }
}