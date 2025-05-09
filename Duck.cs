using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Duck
{
    public string Name { get; set; }
    private string Cor {  get; set; }

    public Duck(string cor)
    {
    Cor = cor;
    }
    public string Swim()
    {
        return ("Nadando...");
    }

    public virtual string Display()
    {
        return ("Sou um Pato.");
    }
}
