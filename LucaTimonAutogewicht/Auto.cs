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
        private string personenNamen = "";
        private double fahrzeug_gewicht;
        List<Person> personen_liste = new List<Person>();
        public Auto()
        {
            anzahl_personen = 4;
            fahrzeug_gewicht = 1000;
            gesammt_gewicht = fahrzeug_gewicht;
        }


        public void PersonEinsteigen(Person pPersonEingestiegen)        //wird nicht benötigt
        {
            person1 = pPersonEingestiegen;
        }

        public void Personenliste(Person pPersonFürListe)
        {
            personen_liste.Add(pPersonFürListe);
        }
        public void PersonenlisteLeeren()
        {
            personen_liste.Clear();
        }

        public double GetGesammtGewicht()
        {
            gesammt_gewicht = fahrzeug_gewicht;

            foreach (Person pPerson in personen_liste)
            {
                if (pPerson.GetGewicht() != 0)
                {
                    gesammt_gewicht += pPerson.GetGewicht();
                }
                else
                {
                    gesammt_gewicht = fahrzeug_gewicht;
                }
            }
            return gesammt_gewicht;
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