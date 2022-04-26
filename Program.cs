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


        Nummer nummer20 = new Nummer("Three little birds", "Bob Marley", 3.00, "reggae");
        Nummer nummer21 = new Nummer("Jamming", "Bob Marley", 3.31, "reggae");
        Nummer nummer22 = new Nummer("Buffalo soldier", "Bob Marley", 4.15, "reggae");
        Nummer nummer23 = new Nummer("Waiting in vain", "Bob Marley", 4.16, "reggae");
        Nummer nummer24 = new Nummer("Redemption song", "Bob Marley", 3.53, "reggae");
        List<Nummer> reggaeNummers = new List<Nummer>();
        reggaeNummers.Add(nummer20);
        reggaeNummers.Add(nummer21);
        reggaeNummers.Add(nummer22);
        reggaeNummers.Add(nummer23);
        reggaeNummers.Add(nummer24);
        Afspeellijst reggaeAfspeellijst = new Afspeellijst("Reggae afspeellijst", reggaeNummers);
        




        Nummer albumNummer1 = new Nummer("Love of my life", "Queen", 3.37, "rock");
        Nummer albumNummer2 = new Nummer("Bohemian Rhapsody", "Queen", 5.54, "rock");
        Nummer albumNummer3 = new Nummer("Death on two legs", "Queen", 3.43, "rock");
        Nummer albumNummer4 = new Nummer("Lazing on a sunday afternoon", "Queen", 1.07, "rock");
        List<Nummer> album1NummersQueen = new List<Nummer>();
        album1NummersQueen.Add(albumNummer1);
        album1NummersQueen.Add(albumNummer2);
        album1NummersQueen.Add(albumNummer3);
        album1NummersQueen.Add(albumNummer4);
        Album album1Queen = new Album("A night at the opera", album1NummersQueen, "Queen");


        Nummer albumNummer5 = new Nummer("You're my best friend", "Queen", 2.50, "rock");
        Nummer albumNummer6 = new Nummer("I'm in love with my best friend", "Queen", 2.50, "rock");
        Nummer albumNummer7 = new Nummer("'39", "Queen", 3.30, "rock");
        Nummer albumNummer8 = new Nummer("Sweet lady", "Queen", 3.30, "rock");
        List<Nummer> album2NummersQueen = new List<Nummer>();
        album2NummersQueen.Add(albumNummer5);
        album2NummersQueen.Add(albumNummer6);
        album2NummersQueen.Add(albumNummer7);
        album2NummersQueen.Add(albumNummer8);
        Album album2Queen = new Album("A night at the opera - tweede deel", album2NummersQueen, "Queen");


        Nummer albumNummer9 = new Nummer("Welcome to the jungle", "Guns N' Roses", 2.50, "rock");
        Nummer albumNummer10 = new Nummer("Paradise city", "Guns N' Roses", 2.50, "rock");
        Nummer albumNummer11 = new Nummer("Sweet child o' mine", "Guns N' Roses", 3.30, "rock");
        Nummer albumNummer12 = new Nummer("It's so easy", "Guns N' Roses", 3.30, "rock");
        List<Nummer> album1NummersGunsNRoses = new List<Nummer>();
        album1NummersGunsNRoses.Add(albumNummer9);
        album1NummersGunsNRoses.Add(albumNummer10);
        album1NummersGunsNRoses.Add(albumNummer11);
        album1NummersGunsNRoses.Add(albumNummer12);
        Album album1GunsNRoses = new Album("Appetite for destruction", album1NummersGunsNRoses, "Guns N' Roses");




        string input = "";
        Console.WriteLine("Welkom bij deze muziek app, wat is jouw naam? ");
        while (input.Replace(" ", "").Equals(""))
        {     //zolang je input spaties is vraag dan naar nieuwe input zodat gebruiker altijd een naam moet invoeren
            input = Console.ReadLine();
        }

        Gebruiker gebruiker = new Gebruiker(input);
        Console.WriteLine("Gebruiker aangemaakt met naam " + gebruiker.naam + "\r");

        List<Afspeellijst> alleAfspeellijsten = new List<Afspeellijst>() { rockAfspeellijst, popAfspeellijst, hipHopAfspeellijst, danceAfspeellijst, reggaeAfspeellijst };
        Console.WriteLine(gebruiker.afspeellijsten[0]);
        for (int i = 0; i < gebruiker.afspeellijsten.Count; i++)
        {
            alleAfspeellijsten.Add(gebruiker.afspeellijsten[i]);
        }

        List<Album> alleAlbums = new List<Album>() { album1Queen, album2Queen, album1GunsNRoses };


        Gebruiker vriend1 = new Gebruiker("Piet");
        vriend1.afspeellijsten.Add(reggaeAfspeellijst);
        Gebruiker vriend2 = new Gebruiker("Willem");
        vriend2.afspeellijsten.Add(reggaeAfspeellijst);
        Gebruiker vriend3 = new Gebruiker("Frederik");
        vriend3.afspeellijsten.Add(reggaeAfspeellijst);

        Vriendenlijst vriendenlijst = new Vriendenlijst( new List<Gebruiker>() { vriend1, vriend2, vriend3 } );
        gebruiker.vriendenlijst = vriendenlijst;


        input = "";
        bool? pauze = null;
        int afspeellijstNummerIndex = 0;
        int albumNummerIndex = 0;

        string stylingLines = new String('=', 80);








        while (!input.Equals("exit"))
        {
            Console.WriteLine(stylingLines);
            Console.WriteLine("Jouw naam:          " + gebruiker.naam);
            if (gebruiker.vriendenlijst.vrienden.Any())
            {
                Console.Write("Jouw vriendenlijst: ");
                gebruiker.vriendenlijst.vrienden.ForEach(vriend => Console.Write(vriend.naam + " "));
                Console.WriteLine("");
            }
            else
            {
                Console.WriteLine("Jouw vriendenlijst: Er staat nog niemand in jouw vriendenlijst.");
            }
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
                            Console.WriteLine("");
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
                        Thread.Sleep(2000);
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
                        Console.WriteLine("Dit zijn de albums waar je uit kunt kiezen: ");
                        Console.WriteLine("- (min teken) : Ga terug");
                        Console.WriteLine("");
                        for (int i = 0; i < alleAlbums.Count; i++)
                        {
                            Console.WriteLine(i + " : " + alleAlbums[i].naam);
                        }
                        Console.WriteLine("Welk album zou je willen afspelen? Druk cijfer om resultaat te krijgen. ");
                        Console.WriteLine(stylingLines);
                        input = Console.ReadLine();
                        bool succes = int.TryParse(input, out int number);
                        if (!succes)
                        {
                            break;
                        }
                        else if (Convert.ToInt32(input) >= alleAlbums.Count)
                        {
                            break;
                        }
                    }
                    Album huidigeAlbum = alleAlbums[Convert.ToInt32(input)];

                    while (input != "3")
                    {
                        if (pauze.HasValue && pauze.Value)
                        {
                            string speelVerder = Console.ReadLine();
                            pauze = false;
                        }
                        else
                        {
                            huidigeAlbum.speel(albumNummerIndex, stylingLines);
                            pauze = false;
                            input = Console.ReadLine();

                            if (input == "1")
                            {
                                huidigeAlbum.pauzeer(stylingLines);
                                pauze = true;
                                continue;
                            }
                            else if (input == "2")
                            {
                                if (albumNummerIndex == huidigeAlbum.nummers.Count - 1)
                                {
                                    albumNummerIndex = 0;
                                    break;
                                }
                                albumNummerIndex += 1;
                                huidigeAlbum.volgende(stylingLines);
                                continue;
                            }
                            else if (input == "3")
                            {
                                albumNummerIndex = 0;
                                huidigeAlbum.stop(stylingLines);
                                break;
                            }
                        }
                    }
                }
                
            }
            else if (input == "4")
            {
                while (!input.Equals("-"))
                {
                    Console.WriteLine(stylingLines);
                    Console.WriteLine("Dit zijn de vrienden in jouw vriendenlijst.");
                    Console.WriteLine("- (min teken) : Ga terug");
                    Console.WriteLine("");
                    for (int i = 0; i < gebruiker.vriendenlijst.vrienden.Count; i++)
                    {
                        Console.WriteLine(i + " : " + gebruiker.vriendenlijst.vrienden[i].naam);
                    }
                    Console.WriteLine("Van wie wil jij een afspeellijst af willen spelen? Druk cijfer om resultaat te krijgen.");
                    Console.WriteLine(stylingLines);
                    input = Console.ReadLine();

                    bool succes = int.TryParse(input, out int number);
                    if (!succes)
                    {
                        break;
                    }
                    else if (Convert.ToInt32(input) > gebruiker.vriendenlijst.vrienden.Count)
                    {
                        break;
                    }

                    Console.WriteLine(gebruiker.vriendenlijst.vrienden[1].afspeellijsten[1]);

                    Afspeellijst huidigeVriendenAfspeellijst = gebruiker.vriendenlijst.vrienden[Convert.ToInt32(input)].afspeellijsten[1];

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
                            huidigeVriendenAfspeellijst.speel(afspeellijstNummerIndex, stylingLines);
                            pauze = false;
                            input = Console.ReadLine();

                            if (input == "1")
                            {
                                huidigeVriendenAfspeellijst.pauzeer(stylingLines);
                                pauze = true;
                                continue;
                            }
                            else if (input == "2")
                            {
                                if (afspeellijstNummerIndex == huidigeVriendenAfspeellijst.nummers.Count - 1)
                                {
                                    afspeellijstNummerIndex = 0;
                                    break;
                                }
                                afspeellijstNummerIndex += 1;
                                huidigeVriendenAfspeellijst.volgende(stylingLines);
                                continue;
                            }
                            else if (input == "3")
                            {
                                afspeellijstNummerIndex = 0;
                                huidigeVriendenAfspeellijst.stop(stylingLines);
                                break;
                            }
                        }
                    }

                }
                


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

