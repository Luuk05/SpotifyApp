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


        Nummer nummer20 = new Nummer("Love of my life", "Queen", 3.37, "rock");
        Nummer nummer21 = new Nummer("Bohemian Rhapsody", "Queen", 5.54, "rock");
        Nummer nummer22 = new Nummer("Death on two legs", "Queen", 3.43, "rock");
        Nummer nummer23 = new Nummer("Lazing on a sunday afternoon", "Queen", 1.07, "rock");
        List<Nummer> album1NummersQueen = new List<Nummer>();
        album1NummersQueen.Add(nummer20);
        album1NummersQueen.Add(nummer21);
        album1NummersQueen.Add(nummer22);
        album1NummersQueen.Add(nummer23);
        Album album1Queen = new Album("A night at the opera", album1NummersQueen, "Queen");


        Nummer nummer24 = new Nummer("You're my best friend", "Queen", 2.50, "rock");
        Nummer nummer25 = new Nummer("I'm in love with my best friend", "Queen", 2.50, "rock");
        Nummer nummer26 = new Nummer("'39", "Queen", 3.30, "rock");
        Nummer nummer27 = new Nummer("Sweet lady", "Queen", 3.30, "rock");
        List<Nummer> album2NummersQueen = new List<Nummer>();
        album2NummersQueen.Add(nummer24);
        album2NummersQueen.Add(nummer25);
        album2NummersQueen.Add(nummer26);
        album2NummersQueen.Add(nummer27);
        Album album2Queen = new Album("A night at the opera - tweede deel", album2NummersQueen, "Queen");


        Nummer nummer28 = new Nummer("Welcome to the jungle", "Guns N' Roses", 2.50, "rock");
        Nummer nummer29 = new Nummer("Paradise city", "Guns N' Roses", 2.50, "rock");
        Nummer nummer30 = new Nummer("Sweet child o' mine", "Guns N' Roses", 3.30, "rock");
        Nummer nummer31 = new Nummer("It's so easy", "Guns N' Roses", 3.30, "rock");
        List<Nummer> album1NummersGunsNRoses = new List<Nummer>();
        album1NummersGunsNRoses.Add(nummer28);
        album1NummersGunsNRoses.Add(nummer29);
        album1NummersGunsNRoses.Add(nummer30);
        album1NummersGunsNRoses.Add(nummer31);
        Album album1GunsNRoses = new Album("Appetite for destruction", album1NummersGunsNRoses, "Guns N' Roses");




        string input = "";
        Console.WriteLine("Welkom bij deze muziek app, wat is jouw naam? ");
        while (input.Replace(" ", "").Equals(""))
        {     //zolang je input spaties is vraag dan naar nieuwe input zodat gebruiker altijd een naam moet invoeren
            input = Console.ReadLine();
        }

        Gebruiker gebruiker = new Gebruiker(input);
        Console.WriteLine("Gebruiker aangemaakt met naam " + gebruiker.naam + "\r");

        List<Afspeellijst> alleAfspeellijsten = new List<Afspeellijst>() { rockAfspeellijst, popAfspeellijst, hipHopAfspeellijst, danceAfspeellijst };
        Console.WriteLine(gebruiker.afspeellijsten[0]);
        for (int i = 0; i < gebruiker.afspeellijsten.Count; i++)
        {
            alleAfspeellijsten.Add(gebruiker.afspeellijsten[i]);
        }
        List<Album> alleAlbums = new List<Album>() { gebruiker.album, album1Queen, album2Queen, album1GunsNRoses };

        input = "";
        bool? pauze = null;
        int afspeellijstNummerIndex = 0;

        string stylingLines = new String('=', 80);

        while (!input.Equals("exit"))
        {
            Console.WriteLine(stylingLines);
            Console.WriteLine("Jouw naam:          " + gebruiker.naam);
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
                        if (i == alleAfspeellijsten.Count - 1)
                        {
                            Console.WriteLine(alleAfspeellijsten.Count + " : " + "Voeg afspeellijst toe");
                        }
                    }
                    Console.WriteLine("Welke afspeellijst zou je willen afspelen? Druk cijfer om resultaat te krijgen. ");
                    Console.WriteLine(stylingLines);
                    input = Console.ReadLine();
                    bool succes = int.TryParse(input, out int number);
                    if (!succes)
                    {
                        break;
                    }
                    else if (Convert.ToInt32(input) > alleAfspeellijsten.Count)
                    {
                        break;
                    }
                    else if (Convert.ToInt32(input) == alleAfspeellijsten.Count) 
                    {
                        Console.WriteLine(stylingLines);
                        Console.WriteLine("Wat wil je als afspeellijst naam?");
                        Console.WriteLine(stylingLines);
                        input = Console.ReadLine();
                        Afspeellijst nieuweAfspeellijst = new Afspeellijst(input, new List<Nummer>());
                        alleAfspeellijsten.Add(nieuweAfspeellijst);
                        gebruiker.afspeellijsten.Add(nieuweAfspeellijst);
                        Console.WriteLine(stylingLines);
                        Console.WriteLine("Afspeellijst aangemaakt met naam " + nieuweAfspeellijst.naam);
                        Console.WriteLine(stylingLines);
                        input = "";
                        break;
                    }

                    Afspeellijst huidigeAfspeellijst = alleAfspeellijsten[Convert.ToInt32(input)];

                    if (huidigeAfspeellijst.nummers.Count == 0)
                    {
                        Console.WriteLine(stylingLines);
                        Console.WriteLine("Er staat nog geen nummers in jouw speellijst");
                        Console.WriteLine("Dit zijn de nummers die je kunt toevoegen:");
                        for (int i = 0; i < exploreAfspeellijst.nummers.Count; i++)
                        {
                            Console.WriteLine(i + " : " + exploreAfspeellijst.nummers[i].naam);
                        }
                        Console.WriteLine("Welk nummer zou je willen toevoegen? Druk cijfer om resultaat te krijgen.");
                        Console.WriteLine(stylingLines);
                        input = Console.ReadLine();
                        bool succes2 = int.TryParse(input, out int number2);
                        if (!succes2)
                        {
                            break;
                        }
                        else if (Convert.ToInt32(input) >= alleAfspeellijsten.Count)
                        {
                            break;
                        }
                        Nummer gekozenNummer = exploreAfspeellijst.nummers[Convert.ToInt32(input)];
                        huidigeAfspeellijst.nummers.Add(gekozenNummer);
                    }
                    else
                    {
                        bool eigenAfspeellijst = false;
                        for (int i = 0; i < gebruiker.afspeellijsten.Count; i++)
                        {
                            if (huidigeAfspeellijst.naam.Equals(gebruiker.afspeellijsten[i].naam)) {
                                eigenAfspeellijst=true;
                            }
                        }
                        if (eigenAfspeellijst)
                        {
                            eigenAfspeellijst = false;
                            Console.WriteLine(stylingLines);
                            Console.WriteLine("Wat wil je doen? ");
                            Console.WriteLine("- (min teken) : Ga terug");
                            Console.WriteLine("");
                            Console.WriteLine("1. : Afspeellijst afspelen");
                            Console.WriteLine("2. : Nummer toevoegen");
                            input = Console.ReadLine();

                            if (input == "1")
                            {
                                input = "";

                                while (input != "3")
                                {
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
                                                afspeellijstNummerIndex = 0;
                                                break;
                                            }
                                            afspeellijstNummerIndex += 1;
                                            huidigeAfspeellijst.volgende(stylingLines);
                                            continue;
                                        }
                                        else if (input == "3")
                                        {
                                            afspeellijstNummerIndex = 0;
                                            huidigeAfspeellijst.stop(stylingLines);
                                            break;
                                        }
                                    }
                                }
                            }
                            else if (input == "2")
                            {
                                Console.WriteLine(stylingLines);
                                Console.WriteLine("Dit zijn de nummers die je kunt toevoegen:");
                                for (int i = 0; i < exploreAfspeellijst.nummers.Count; i++)
                                {
                                    Console.WriteLine(i + " : " + exploreAfspeellijst.nummers[i].naam);
                                }
                                Console.WriteLine("Welk nummer zou je willen toevoegen? Druk cijfer om resultaat te krijgen.");
                                Console.WriteLine(stylingLines);
                                input = Console.ReadLine();
                                bool succes2 = int.TryParse(input, out int number2);
                                if (!succes2)
                                {
                                    break;
                                }
                                else if (Convert.ToInt32(input) >= alleAfspeellijsten.Count)
                                {
                                    break;
                                }
                                Nummer gekozenNummer = exploreAfspeellijst.nummers[Convert.ToInt32(input)];
                                huidigeAfspeellijst.nummers.Add(gekozenNummer);
                            }
                            else
                            {
                                input = "1";
                            }
                        }
                        else
                        {
                            input = "";

                            while (input != "3")
                            {
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
                                            afspeellijstNummerIndex = 0;
                                            break;
                                        }
                                        afspeellijstNummerIndex += 1;
                                        huidigeAfspeellijst.volgende(stylingLines);
                                        continue;
                                    }
                                    else if (input == "3")
                                    {
                                        afspeellijstNummerIndex = 0;
                                        huidigeAfspeellijst.stop(stylingLines);
                                        break;
                                    }
                                }
                            }
                        }
                    }
                }
            }
            else if (input == "3")
            {
                if (gebruiker.album == null)
                {
                    Console.WriteLine(stylingLines);
                    Console.WriteLine("Je hebt nog geen album toegevoegd");
                    while (!input.Equals("-"))
                    {
                        Console.WriteLine(stylingLines);
                        Console.WriteLine("Dit zijn de albums waar je uit kunt kiezen: ");
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
                    }
                }
            }
            else if (input == "4")
            {
            }
            else if (input.Equals("5"))
            {
                Console.WriteLine(stylingLines);
                Console.WriteLine("Menu: Druk cijfer om resultaat te krijgen.");
                Console.WriteLine("1 : Verander gebruikersnaam");
                Console.WriteLine(stylingLines);

                input = Console.ReadLine();
                if (input.Equals("1"))
                {
                    Console.WriteLine("\r \r \r \r");
                    Console.WriteLine(stylingLines);
                    Console.WriteLine("Je huidige gebruikersnaam is: " + gebruiker.naam);
                    Console.WriteLine("Waar wil je jouw naam naar veranderen?");
                    Console.WriteLine(stylingLines);

                    input = Console.ReadLine();
                    gebruiker.naam = input;

                    Console.WriteLine("\r \r \r \r");
                    Console.WriteLine(stylingLines);
                    Console.WriteLine("Gebruikersnaam veranderd naar: " + gebruiker.naam);
                    Console.WriteLine(stylingLines);
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
                    Console.WriteLine(stylingLines);
                    Console.WriteLine("Ongeldige invoer!");
                    Console.WriteLine(stylingLines);
                    Thread.Sleep(1000);
                    Console.Clear();
                }
            }



        }

    }
}

