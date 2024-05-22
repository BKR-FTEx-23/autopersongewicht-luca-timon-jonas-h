using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LucaTimonAutogewicht
{
    public class Auto
    {
        private double gesammt_gewicht;
        private int anzahl_personen;
        private Person person1;
        private Person person2;
        private double fahrzeug_gewicht;
        private int zähler = 0;
        private int personen_zähler = 0;
        List <Person> personen_liste=new List<Person>();
        public Auto()
        {
            anzahl_personen = 4;
            fahrzeug_gewicht = 1000;
            gesammt_gewicht = fahrzeug_gewicht;
        }

        public void PersonEinsteigen(Person pPersonEingestiegen)
        {
            person1 = pPersonEingestiegen;
            personen_liste.Add(person1);
        }



        public double GetGesammtGewicht()
        {
            if (personen_zähler == 0)
            {
                if (zähler == 0)
                {
                    gesammt_gewicht = fahrzeug_gewicht + person1.GetGewicht();
                    zähler++;
                }
                else
                {
                    gesammt_gewicht += person1.GetGewicht();
                }
            }


           


            return gesammt_gewicht;
        }

        public int GetPersonen()
        {
            return anzahl_personen;
        }

        public override string ToString()
        {
            return "";
        }
    }
}