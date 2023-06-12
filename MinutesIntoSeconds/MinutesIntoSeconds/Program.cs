namespace MinutesIntoSeconds
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bitte geben Sie die Anzahl der Minuten ein:");
            string input = Console.ReadLine(); // Benutzereingabe lesen

            int minutes;
            if (int.TryParse(input, out minutes))
            {
                int seconds = minutes * 60; // Minuten in Sekunden umrechnen

                // Das Ergebnis ausgeben
                Console.WriteLine("{0} Minuten entsprechen {1} Sekunden.", minutes, seconds);
            }
            else
            {
                Console.WriteLine("Ungültige Eingabe. Bitte geben Sie eine ganze Zahl ein.");
            }

            // Warten, bis der Benutzer eine beliebige Taste drückt, um das Programm zu beenden
            Console.ReadKey();
        }
    }
}