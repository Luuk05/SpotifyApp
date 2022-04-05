using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class Vriendenlijst
{
    public string naam { get; private set; }
    public List<Gebruiker> vriendenlijst { get; private set; }

    public Vriendenlijst(string naam, List<Gebruiker> vriendenlijst)
    {
        this.naam = naam;
        this.vriendenlijst = vriendenlijst;
    }


}

