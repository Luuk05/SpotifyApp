using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class Gebruiker
{
    public string naam { get; set; }
    public List<Afspeellijst> afspeellijsten { get; set; }
    public Vriendenlijst vriendenlijst { get; set; }
    public Album? album { get; set; }


    public Gebruiker(string naam)
    {
        this.naam = naam;
        this.afspeellijsten = new List<Afspeellijst>();
        afspeellijsten.Add(new Afspeellijst("Jouw afspeellijst", new List<Nummer>())) ;
        this.vriendenlijst = new Vriendenlijst(new List<Gebruiker>());
        this.album = null;
    }


}

