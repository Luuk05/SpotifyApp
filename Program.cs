using System;


public class Program
{
    static void Main(string[] args)
    {
        Nummer nummer1 = new Nummer("Bohemian Rhapsody", "Queen", 5.55, "rock");
        Nummer nummer2 = new Nummer("Under pressure", "Queen", 4.08, "rock");
        Nummer nummer3 = new Nummer("Radio Ga Ga", "Queen", 5.48, "rock");
        Nummer nummer4 = new Nummer("I want to break free", "Queen", 4.18, "rock");


        Nummer nummer5 = new Nummer("Circles", "Post Malone", 3.13, "pop");
        Nummer nummer6 = new Nummer("Sunflower", "Post Malone", 2.37, "pop");
        Nummer nummer7 = new Nummer("Rockstar", "Post Malone", 3.38, "pop");
        Nummer nummer8 = new Nummer("Congratulations", "Post Malone", 3.40, "pop");
        Nummer nummer9 = new Nummer("Better now", "Post Malone", 3.51, "pop");

        List<Nummer> randomNummers = new List<Nummer>();
        randomNummers.Add(nummer5);
        randomNummers.Add(nummer6);
        randomNummers.Add(nummer7);
        randomNummers.Add(nummer8);
        Afspeellijst algemeneNummerSpeler = new Afspeellijst("Random afspeellijst", randomNummers);



        string input = "";
        Console.WriteLine("Welkom bij deze muziek app, wat is jouw naam? ");
        while (input.Replace(" ", "").Equals(""))
        {     //zolang je input spaties is vraag dan naar nieuwe input zodat gebruiker altijd een naam moet invoeren
            input = Console.ReadLine();
        }

        Gebruiker gebruiker = new Gebruiker(input);
        Console.WriteLine("Gebruiker aangemaakt met naam " + gebruiker.naam + "\r");

        input = "";

        while (!input.Equals("exit"))
        {
            Console.WriteLine("==========================================================================");
            Console.WriteLine("Jouw naam:          " + gebruiker.naam);
            Console.WriteLine("Jouw afspeellijst:  " + gebruiker.afspeellijst.naam);
            Console.WriteLine("Jouw album:         " + (gebruiker.album.naam == null ? "Je hebt nog geen album" : gebruiker.album.naam) + "\r");
            Console.WriteLine("Jouw vriendenlijst: " + (gebruiker.vriendenlijst.vrienden.Any() ? gebruiker.vriendenlijst : "Er staat nog niemand in jouw vriendenlijst."));
            Console.WriteLine("==========================================================================");

            Console.WriteLine("\r \r \r \r");

            Console.WriteLine("==========================================================================");
            Console.WriteLine("Menu: Druk cijfer om resultaat te krijgen.");
            Console.WriteLine("1 : Bekijk nummer(s)");
            Console.WriteLine("2 : Bekijk afspeellijst(en) af");
            Console.WriteLine("3 : Bekijk album(s)");
            Console.WriteLine("4 : Bekijk vriendenlijst");
            Console.WriteLine("5 : Instellingen");
            Console.WriteLine("==========================================================================");

            input = Console.ReadLine();

            Console.WriteLine("\r \r \r \r");

            if (input == "1")
            {
                while (!input.Equals(0))
                {
                    Console.WriteLine("Dit zijn de nummers waar je uit kunt kiezen: ");
                    Console.WriteLine("0 : Ga terug");
                    for (int i = 1; i < algemeneNummerSpeler.nummers.Count; i++)
                    {
                        Console.WriteLine(i + " : " + algemeneNummerSpeler.nummers[i].naam);
                    }
                    Console.WriteLine("Welk nummer zou je willen afspelen? Druk cijfer om resultaat te krijgen. ");
                    input = Console.ReadLine();

                    if (Convert.ToInt32(input) == 0)
                    {
                        break;
                    }

                    Nummer huidigNummer = algemeneNummerSpeler.nummers[Convert.ToInt32(input)];
                                       
                    huidigNummer.speel();
                    input = Console.ReadLine();

                    if (input == "1")
                    {
                        huidigNummer.pauzeer();
                        input = Console.ReadLine();
                        huidigNummer.speel();
                    }
                    else if (input == "2")
                    {
                        huidigNummer.volgende();
                        continue;
                    }
                    else if (input == "3") 
                    {
                        huidigNummer.stop();
                        break;
                    }
                }
            }
            else if (input == "2")
            {

            }
            else if (input == "3")
            {

            }
            else if (input == "2")
            {

            }
            else if (input == "3")
            {
            }
            else if (input == "4")
            {
            }
            else if (input.Equals("5"))
            {
                Console.WriteLine("==========================================================================");
                Console.WriteLine("Menu: Druk cijfer om resultaat te krijgen.");
                Console.WriteLine("1 : Verander gebruikersnaam");
                Console.WriteLine("==========================================================================");

                input = Console.ReadLine();
                if (input.Equals("1"))
                {
                    Console.WriteLine("\r \r \r \r");
                    Console.WriteLine("==========================================================================");
                    Console.WriteLine("Je huidige gebruikersnaam is: " + gebruiker.naam);
                    Console.WriteLine("Waar wil je jouw naam naar veranderen?");
                    Console.WriteLine("==========================================================================");

                    input = Console.ReadLine();
                    gebruiker.naam = input;

                    Console.WriteLine("\r \r \r \r");
                    Console.WriteLine("==========================================================================");
                    Console.WriteLine("Gebruikersnaam veranderd naar: " + gebruiker.naam);
                    Console.WriteLine("==========================================================================");
                }

            }



        }

    }
}

