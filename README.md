# Projekt Autogewicht (Luca, Timon, Jonas H.)

## Übersicht  
Dieses Programm simuliert das Ein- und Aussteigen von Personen in ein Auto und berechnet dabei das Gesamtgewicht des Autos. Das Programm ist in C# geschrieben und verwendet eine Windows Forms Oberfläche zur Interaktion mit dem Benutzer.

## Klassenbeschreibung
### Form1.cs
![](https://raw.githubusercontent.com/BKR-FTEx-23/autopersongewicht-luca-timon-jonas-h/master/Oberfl%C3%A4che_Programm.png?token=GHSAT0AAAAAACRQLTJWWE3BDUZTR3Q2R27OZSO7I6A)  
*Oberfläche des Programmes aus C#*  

### Person.cs
Diese Klasse repräsentiert eine Person mit Namen und Gewicht.

Felder:

gewicht: Das Gewicht der Person.
name: Der Name der Person.
Konstruktoren:

Person(): Standardkonstruktor, setzt den Namen auf "John Doe" und das Gewicht auf 100.
Person(string pName, double pGewichtPerson): Konstruktor mit Parametern, um den Namen und das Gewicht der Person zu setzen.
Methoden:

GetGewicht(): Gibt das Gewicht der Person zurück.
GetName(): Gibt den Namen der Person zurück.
Auto
Diese Klasse repräsentiert ein Auto, das Personen aufnehmen kann und das Gesamtgewicht berechnet.

Felder:

gesamt_gewicht: Das aktuelle Gesamtgewicht des Autos inklusive Personen.
personenNamen: Eine Zeichenkette, die die Namen aller Personen im Auto enthält.
fahrzeug_gewicht: Das Grundgewicht des Autos ohne Personen.
personen_liste: Eine Liste von Personen, die sich im Auto befinden.
Konstruktoren:

Auto(): Standardkonstruktor, setzt das Fahrzeuggewicht auf 1000 und initialisiert das Gesamtgewicht.
Methoden:

Einsteigen(Person pPersonFürListe): Fügt eine Person zur Personenliste hinzu.
Aussteigen(): Leert die Personenliste.
GetGesammtGewicht(): Berechnet und gibt das Gesamtgewicht des Autos zurück.
GetAllePersonennamen(): Gibt die Namen aller Personen im Auto zurück.
Verwendung
Starten Sie das Programm.
Geben Sie den Namen und das Gewicht einer Person in die entsprechenden Textfelder ein.
Klicken Sie auf den Button "Speichern", um die Person hinzuzufügen.
Klicken Sie auf den Button "Einsteigen", um das aktuelle Gewicht und die Namen aller Personen im Auto anzuzeigen.
Klicken Sie auf den Button "Aussteigen", um alle Personen aus dem Auto zu entfernen und das Gewicht zurückzusetzen.
Anmerkungen
Das Programm aktualisiert die Gewichtsanzeige und die Anzeige der Personennamen bei jeder relevanten Benutzeraktion.
Wenn Personen aussteigen, wird die Personenliste geleert und das Gewicht des Autos auf das Grundgewicht zurückgesetzt.
