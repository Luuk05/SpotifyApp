using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public interface IAfspelen
{
    void speel(int index = 0, string stylingLines = "");
    void pauzeer(string stylingLines = "");
    void volgende(string stylingLines = "");
    void stop(string stylingLines = "");
}
