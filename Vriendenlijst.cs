using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class Vriendenlijst
{
    public List<Gebruiker> vrienden { get; private set; }


    public Vriendenlijst(List<Gebruiker> vrienden)
    {
        this.vrienden = vrienden;
    }


}

