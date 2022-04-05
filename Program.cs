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
        Afspeellijst legeSpeellijst = new Afspeellijst("Jouw afspeellijst");

        Gebruiker gebruiker1 = new Gebruiker(input, legeSpeellijst);

    }   
}
