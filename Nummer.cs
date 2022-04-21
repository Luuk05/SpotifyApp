using System;
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

    public void speel(int index, string stylingLines)
    {
        Console.WriteLine(stylingLines);
        Console.WriteLine("Op het moment aan het afspelen: ");
        Console.WriteLine(this.naam + " van " + this.artiest);
        Console.WriteLine("1. pauzeer    |--------------------------|   2. Volgende / Ander nummer   3. Stop");
        Console.WriteLine(stylingLines);
    }

    public void pauzeer(string stylingLines)
    {
        Console.WriteLine(stylingLines);
        Console.WriteLine("Afspelen gepauzeerd...");
        Console.WriteLine("1. Afspelen");
        Console.WriteLine(stylingLines);
    }

    public void volgende(string stylingLines)
    {
        Console.WriteLine(stylingLines);
        Console.WriteLine("Kies nieuw nummer");
        Console.WriteLine(stylingLines);
    }

    public void stop(string stylingLines)
    {
        Console.WriteLine(stylingLines);
        Console.WriteLine("Muziek gestopt");
        Console.WriteLine(stylingLines);
    }
}

