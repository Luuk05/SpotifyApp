using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class Afspeellijst : IAfspelen
{
    public string naam { get; set; }
    public List<Nummer> nummers { get; private set; }

    public Afspeellijst(string naam, List<Nummer> nummers )
    {
        this.naam = naam;
        this.nummers = nummers;
    }

    public void speel(int index, string stylingLines)
    {
        Console.WriteLine(stylingLines);
        Console.WriteLine("Op het moment aan het afspelen: ");
        Console.WriteLine(this.nummers[index].naam + " van " + this.nummers[index].artiest);
        Console.WriteLine("1. pauzeer   |--------------------------|   2. Volgende   3. Stop");
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
        Console.WriteLine("Volgende nummer....");
        Console.WriteLine(stylingLines);
    }

    public void stop(string stylingLines)
    {
        Console.WriteLine(stylingLines);
        Console.WriteLine("Muziek gestopt");
        Console.WriteLine(stylingLines);
    }
}

