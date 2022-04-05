using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class Afspeellijst
{
    public string naam { get; set; }
    public List<Nummer> nummers { get; private set; }

    public Afspeellijst(string naam, List<Nummer> nummers=null)
    {
        this.naam = naam;
        this.nummers = nummers;
    }


}

