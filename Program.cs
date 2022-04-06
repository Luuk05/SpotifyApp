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
            Console.WriteLine("=================================================== \r");
            Console.WriteLine("Jouw afspeellijst:  " + gebruiker.afspeellijst.naam + "\r");
            //Console.WriteLine("Jouw album:         " + gebruiker.album.naam + "\r");
            Console.WriteLine("Jouw vriendenlijst: " + (gebruiker.vriendenlijst.vrienden.Any() ? gebruiker.vriendenlijst : "Er staat nog niemand in jouw vriendenlijst.") + "\r");
            Console.WriteLine("=================================================== \r");

            input = Console.ReadLine();
        }
    }   
}
