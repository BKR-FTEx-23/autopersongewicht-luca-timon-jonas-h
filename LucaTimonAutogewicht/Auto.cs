using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LucaTimonAutogewicht
{
    public class Auto
    {
        private double gesamt_gewicht;
        private string personenNamen = "";
        private double fahrzeug_gewicht;
        List<Person> personen_liste = new List<Person>();

        public Auto()
        {
            fahrzeug_gewicht = 1000;
            gesamt_gewicht = fahrzeug_gewicht;
        }

        public double GesammtGewicht        //property
        {
            get { 
                gesamt_gewicht = fahrzeug_gewicht;

                foreach (Person pPerson in personen_liste)
                {
                    if (pPerson.Gewicht != 0)
                    {
                        gesamt_gewicht += pPerson.Gewicht;
                    }
                    else
                    {
                        gesamt_gewicht = fahrzeug_gewicht;
                    }
                }
                return gesamt_gewicht;
            }
        }

        public void Einsteigen(Person pPersonFürListe)
        {
            personen_liste.Add(pPersonFürListe);
        }
        public void Aussteigen()
        {
            personen_liste.Clear();
        }
       
        public double GetGesammtGewicht()
        {
            gesamt_gewicht = fahrzeug_gewicht;

            foreach (Person pPerson in personen_liste)
            {
                if (pPerson.Gewicht != 0)
                {
                    gesamt_gewicht += pPerson.Gewicht;                   
                }
                else
                {
                    gesamt_gewicht = fahrzeug_gewicht;
                }
            }
            return gesamt_gewicht;
        }

        public string GetAllePersonennamen()
        {
            personenNamen = "";

            foreach (Person pPerson in personen_liste)
            {
                personenNamen += pPerson.GetName() + "\r\n";
            }
            if (personen_liste.Count != 0)
            {
                personenNamen.Remove(personenNamen.Length - 1);
            }
            return personenNamen;
        }
    }
}