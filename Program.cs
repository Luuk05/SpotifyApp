using System;


public class Program
{
    static void Main(string[] args)
    {
        Nummer nummer1 = new Nummer("Bohemian Rhapsody", "Queen", 5.55);
        Nummer nummer2 = new Nummer("Under pressure", "Queen", 4.08);
        Nummer nummer3 = new Nummer("Radio Ga Ga", "Queen", 5.48);
        Nummer nummer4 = new Nummer("I want to break free", "Queen", 4.18);

        Console.WriteLine("Welkom bij deze muziek app, wat is jouw naam? ");
        string input = Console.ReadLine();

        Gebruiker gebruiker = new Gebruiker(input);
        Console.WriteLine("Gebruiker aangemaakt met naam " + gebruiker.naam + "\r");

        input = "";

        while (!input.Equals("exit")) {
            Console.WriteLine("==========================================================================");
            Console.WriteLine("Jouw afspeellijst:  " + gebruiker.afspeellijst.naam);
            //Console.WriteLine("Jouw album:         " + gebruiker.album.naam + "\r");
            Console.WriteLine("Jouw vriendenlijst: " + (gebruiker.vriendenlijst.vrienden.Any() ? gebruiker.vriendenlijst : "Er staat nog niemand in jouw vriendenlijst."));
            Console.WriteLine("==========================================================================");

            Console.WriteLine("\r \r \r \r");


            Console.WriteLine("==========================================================================");
            Console.WriteLine("Menu: Druk cijfer om resultaat te krijgen.");
            Console.WriteLine("1 : Speel nummer af");
            Console.WriteLine("2 : Speel afspeellijst af");
            Console.WriteLine("3 : Bekijk vriendenlijst");
            Console.WriteLine("4 : Instellingen");
            Console.WriteLine("==========================================================================");

            input = Console.ReadLine();
        }
    }   
}
