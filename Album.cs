using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class Album
{
    public string naam { get; private set; }
    public string artiest { get; private set; }
    public List<Nummer> nummers { get; private set; }

    public Album(string naam=null, string artiest=null, List<Nummer> nummers=null)
    {
        this.naam = naam;
        this.artiest = artiest;
        this.nummers = nummers;
    }


}

