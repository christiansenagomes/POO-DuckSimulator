using DuckSimulator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Duck : ISubscriber
{
    public string Name { get; set; }
    private string Cor {  get; set; }
    public bool Afraid { get; private set; }

    public Duck(string cor)
    {
        Cor = cor;
    }
    public string Swim()
    {
        string afraidStr = Afraid ? "lentamente pois estou com medo" : "";
        return ("Nadando...");
    }

    public virtual string Display()
    {
        string afraidStr = Afraid ? "que está com medo" : "";
        return ($"Sou um Pato de cor {Cor}.");
    }

    public void Update(bool danger)
    {
        Afraid = danger;
    }
}
