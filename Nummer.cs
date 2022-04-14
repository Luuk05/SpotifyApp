﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class Nummer : IAfspelen
{
    public string naam { get; private set; }
    public string artiest { get; private set; }
    public double duratie { get; private set; }
    public string genre { get; private set; }

    public Nummer(string naam, string artiest, double duratie, string genre)
    {
        this.naam = naam;
        this.artiest = artiest;
        this.duratie = duratie;
        this.genre = genre;
    }

    public void speel()
    {
        Console.WriteLine("Op het moment aan het afspelen: ");
        Console.WriteLine(this.naam + " van " + this.artiest);
        Console.WriteLine("1. pauzeer   |--------------------------|  2. Volgende / Ander nummer  3. Stop");

    }

    public void pauzeer()
    {
        Console.WriteLine("==========================================================================");
        Console.WriteLine("Afspelen gepauzeerd...");
        Console.WriteLine("1. Afspelen");
        Console.WriteLine("==========================================================================");
    }

    public void volgende()
    {
        Console.WriteLine("==========================================================================");
        Console.WriteLine("Kies nieuw nummer");
        Console.WriteLine("==========================================================================");
    }

    public void stop()
    {
        Console.WriteLine("==========================================================================");
        Console.WriteLine("Muziek gestopt");
        Console.WriteLine("==========================================================================");
    }
}

