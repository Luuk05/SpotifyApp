using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class Gebruiker
{
    public string naam { get; private set; }
    public Afspeellijst afspeellijst { get; private set; }
    public Vriendenlijst vriendenlijst { get; private set; }

    public Gebruiker(string naam)
    {
        this.naam = naam;
        this.afspeellijst = new Afspeellijst("Jouw afspeellijst");
        this.vriendenlijst = new Vriendenlijst(new List<Gebruiker>());
    }


}

