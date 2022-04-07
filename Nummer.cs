using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class Nummer
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


}

