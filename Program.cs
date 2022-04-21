using System;


public class Program
{
    static void Main(string[] args)
    {
        Nummer exploreNummer1 = new Nummer("Bohemian Rhapsody", "Queen", 5.55, "rock");
        Nummer exploreNummer2 = new Nummer("Circles", "Post Malone", 3.13, "pop");
        Nummer exploreNummer3 = new Nummer("Lose yourself", "Eminem", 5.22, "hip hop");
        Nummer exploreNummer4 = new Nummer("Dancing Queen", "ABBA", 5.22, "dance");

        List<Nummer> exploreNummers = new List<Nummer>();
        exploreNummers.Add(exploreNummer1);
        exploreNummers.Add(exploreNummer2);
        exploreNummers.Add(exploreNummer3);
        exploreNummers.Add(exploreNummer4);
        Afspeellijst exploreAfspeellijst = new Afspeellijst("Explore afspeellijst", exploreNummers);




        Nummer nummer1 = new Nummer("Bohemian Rhapsody", "Queen", 5.55, "rock");
        Nummer nummer2 = new Nummer("Under pressure", "Queen", 4.08, "rock");
        Nummer nummer3 = new Nummer("Radio Ga Ga", "Queen", 5.48, "rock");
        Nummer nummer4 = new Nummer("I want to break free", "Queen", 4.18, "rock");

        List<Nummer> rockNummers = new List<Nummer>();
        rockNummers.Add(nummer1);
        rockNummers.Add(nummer2);
        rockNummers.Add(nummer3);
        rockNummers.Add(nummer4);
        Afspeellijst rockAfspeellijst = new Afspeellijst("Rock afspeellijst", rockNummers);


        Nummer nummer5 = new Nummer("Circles", "Post Malone", 3.13, "pop");
        Nummer nummer6 = new Nummer("Sunflower", "Post Malone", 2.37, "pop");
        Nummer nummer7 = new Nummer("Rockstar", "Post Malone", 3.38, "pop");
        Nummer nummer8 = new Nummer("Congratulations", "Post Malone", 3.40, "pop");
        Nummer nummer9 = new Nummer("Better now", "Post Malone", 3.51, "pop");

        List<Nummer> popNummers = new List<Nummer>();
        popNummers.Add(nummer5);
        popNummers.Add(nummer6);
        popNummers.Add(nummer7);
        popNummers.Add(nummer8);
        popNummers.Add(nummer9);
        Afspeellijst popAfspeellijst = new Afspeellijst("Pop afspeellijst", popNummers);


        Nummer nummer10 = new Nummer("Lose yourself", "Eminem", 5.22, "hip hop");
        Nummer nummer11 = new Nummer("Without me", "Eminem", 4.50, "hip hop");
        Nummer nummer12 = new Nummer("The Real Slim Shady", "Eminem", 4.44, "hip hop");
        Nummer nummer13 = new Nummer("Stan", "Eminem", 6.44, "hip hop");
        Nummer nummer14 = new Nummer("Mockingbird", "Eminem", 4.10, "hip hop");

        List<Nummer> hipHopNummers = new List<Nummer>();
        hipHopNummers.Add(nummer10);
        hipHopNummers.Add(nummer11);
        hipHopNummers.Add(nummer12);
        hipHopNummers.Add(nummer13);
        hipHopNummers.Add(nummer14);
        Afspeellijst hipHopAfspeellijst = new Afspeellijst("Hip hop afspeellijst", hipHopNummers);


        Nummer nummer15 = new Nummer("Dancing Queen", "ABBA", 5.22, "dance");
        Nummer nummer16 = new Nummer("I’m So Excited", "The Pointer Sisters", 4.50, "dance");
        Nummer nummer17 = new Nummer("I Will Survive ", "Gloria Gaynor", 4.44, "dance");
        Nummer nummer18 = new Nummer("Stayin’ Alive", " Bee Gees", 6.44, "dance");
        Nummer nummer19 = new Nummer("Billie Jean", "Michael Jackson", 4.10, "dance");
        List<Nummer> danceNummers = new List<Nummer>();
        danceNummers.Add(nummer15);
        danceNummers.Add(nummer16);
        danceNummers.Add(nummer17);
        danceNummers.Add(nummer18);
        danceNummers.Add(nummer19);
        Afspeellijst danceAfspeellijst = new Afspeellijst("Dance afspeellijst", danceNummers);




        string input = "";
        Console.WriteLine("Welkom bij deze muziek app, wat is jouw naam? ");
        while (input.Replace(" ", "").Equals(""))
        {     //zolang je input spaties is vraag dan naar nieuwe input zodat gebruiker altijd een naam moet invoeren
            input = Console.ReadLine();
        }

        Gebruiker gebruiker = new Gebruiker(input);
        Console.WriteLine("Gebruiker aangemaakt met naam " + gebruiker.naam + "\r");

        List<Afspeellijst> alleAfspeellijsten = new List<Afspeellijst>() { rockAfspeellijst, popAfspeellijst, hipHopAfspeellijst, danceAfspeellijst };

        input = "";
        bool? pauze = null;
        int afspeellijstNummerIndex = 0;

        string stylingLines = new String('=', 78);

        while (!input.Equals("exit"))
        {
            Console.WriteLine(stylingLines);
            Console.WriteLine("Jouw naam:          " + gebruiker.naam);
            Console.WriteLine("Jouw afspeellijst:  " + gebruiker.afspeellijst.naam);
            Console.WriteLine("Jouw album:         " + (gebruiker.album.naam == null ? "Je hebt nog geen album" : gebruiker.album.naam) + "\r");
            Console.WriteLine("Jouw vriendenlijst: " + (gebruiker.vriendenlijst.vrienden.Any() ? gebruiker.vriendenlijst : "Er staat nog niemand in jouw vriendenlijst."));
            Console.WriteLine(stylingLines);

            Console.WriteLine("\r \r \r \r");

            Console.WriteLine(stylingLines);
            Console.WriteLine("Menu: Druk cijfer om resultaat te krijgen.");
            Console.WriteLine("1 : Bekijk willekeurige nummer(s)");
            Console.WriteLine("2 : Bekijk afspeellijst(en)");
            Console.WriteLine("3 : Bekijk album(s)");
            Console.WriteLine("4 : Bekijk vriendenlijst");
            Console.WriteLine("5 : Instellingen");
            Console.WriteLine(stylingLines);

            input = Console.ReadLine();

            Console.WriteLine("\r \r \r \r");

            if (input == "1")
            {
                while (!input.Equals("-"))
                {
                    if (pauze.HasValue && pauze.Value)
                    {
                        string speelVerder = Console.ReadLine();
                        pauze = false;
                    }
                    else
                    {
                        Console.WriteLine(stylingLines);
                        Console.WriteLine("Dit zijn de nummers waar je uit kunt kiezen: ");
                        Console.WriteLine("- (min teken) : Ga terug");
                        Console.WriteLine("");
                        for (int i = 0; i < exploreAfspeellijst.nummers.Count; i++)
                        {
                            Console.WriteLine(i + " : " + exploreAfspeellijst.nummers[i].naam);
                        }
                        Console.WriteLine("Welk nummer zou je willen afspelen? Druk cijfer om resultaat te krijgen. ");
                        Console.WriteLine(stylingLines);

                        input = Console.ReadLine();
                        bool succes = int.TryParse(input, out int number);
                        if (!succes)
                        {
                            break;
                        }
                        else if (Convert.ToInt32(input) >= exploreAfspeellijst.nummers.Count)
                        {
                            break;
                        }

                    }

                    Nummer huidigNummer = exploreAfspeellijst.nummers[Convert.ToInt32(input)];

                    huidigNummer.speel(0, stylingLines);
                    pauze = false;
                    input = Console.ReadLine();

                    if (input == "1")
                    {
                        huidigNummer.pauzeer(stylingLines);
                        pauze = true;
                        continue;
                    }
                    else if (input == "2")
                    {
                        huidigNummer.volgende(stylingLines);
                        continue;
                    }
                    else if (input == "3")
                    {
                        huidigNummer.stop(stylingLines);
                        break;
                    }
                }
            }
            else if (input == "2")
            {
                while (!input.Equals("-"))
                {
                    Console.WriteLine(stylingLines);
                    Console.WriteLine("Dit zijn de afspeellijsten waar je uit kunt kiezen: ");
                    Console.WriteLine("- (min teken) : Ga terug");
                    Console.WriteLine("");
                    for (int i = 0; i < alleAfspeellijsten.Count; i++)
                    {
                        Console.WriteLine(i + " : " + alleAfspeellijsten[i].naam);
                    }
                    Console.WriteLine("Welke afspeellijst zou je willen afspelen? Druk cijfer om resultaat te krijgen. ");
                    Console.WriteLine(stylingLines);
                    input = Console.ReadLine();
                    bool succes = int.TryParse(input, out int number);
                    if (!succes)
                    {
                        break;
                    }
                    else if (Convert.ToInt32(input) >= alleAfspeellijsten.Count)
                    {
                        break;
                    }
                    
                    Afspeellijst huidigeAfspeellijst = alleAfspeellijsten[Convert.ToInt32(input)];
                    input = "";

                    while (input != "3") {
                        if (pauze.HasValue && pauze.Value)
                        {
                            string speelVerder = Console.ReadLine();
                            pauze = false;
                        }
                        else
                        {
                            huidigeAfspeellijst.speel(afspeellijstNummerIndex, stylingLines);
                            pauze = false;
                            input = Console.ReadLine();

                            if (input == "1")
                            {
                                huidigeAfspeellijst.pauzeer(stylingLines);
                                pauze = true;
                                continue;
                            }
                            else if (input == "2")
                            {
                                if (afspeellijstNummerIndex == huidigeAfspeellijst.nummers.Count - 1)
                                {
                                    break;
                                }
                                afspeellijstNummerIndex += 1;
                                huidigeAfspeellijst.volgende(stylingLines);
                                continue;
                            }
                            else if (input == "3")
                            {
                                huidigeAfspeellijst.stop(stylingLines);
                                break;
                            }
                        }
                    }

                }







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
                    Thread.Sleep(1400);
                    Console.Clear();
                }

            }
            else
            {
                if (input.Equals("exit", StringComparison.InvariantCultureIgnoreCase))
                {
                    break;
                }
                else
                {
                    Console.WriteLine("==========================================================================");
                    Console.WriteLine("Ongeldige invoer!");
                    Console.WriteLine("==========================================================================");
                    Thread.Sleep(1000);
                    Console.Clear();
                }
            }



        }

    }
}

