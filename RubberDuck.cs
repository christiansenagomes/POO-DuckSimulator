using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

public class RubberDuck : Duck, IQuackable
{
    public RubberDuck(string cor) : base(cor)
    {
        Name = "Rubber Duck";
    }
    public override string Display()
    {
        string afraidStr = Afraid ? "que está com medo" : "";
        return ("Sou um Rubber Duck" + afraidStr);
    }

    public string Quack()
    {
        return ("rubberquaaaa!!!!...");
    }
}
