using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class Afspeellijst : IAfspelen
{
    public string naam { get; set; }
    public List<Nummer> nummers { get; private set; }

    public Afspeellijst(string naam, List<Nummer> nummers=null)
    {
        this.naam = naam;
        this.nummers = nummers;
    }

    public void speel(int index)
    {
        Console.WriteLine("==========================================================================");
        Console.WriteLine("Op het moment aan het afspelen: ");
        Console.WriteLine(this.nummers[index].naam + " van " + this.nummers[index].artiest);
        Console.WriteLine("1. pauzeer   |--------------------------|  2. Volgende / Ander nummer  3. Stop");
        Console.WriteLine("==========================================================================");
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

