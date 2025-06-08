using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class RedHeadDuck : Duck, IFlyable, IQuackable
{
    public RedHeadDuck(string cor) : base(cor)
    {
        Name = "RedHead Duck";
    }
    public override string Display()
    {
        string afraidStr = Afraid ? " com bastante medo" : "";
        return ("Sou um Red Head Duck" + afraidStr);
    }

    public string Fly()
    {
        string afraidStr = Afraid ? "pra longe daqui" : "";
        return ("voar...");
    }

    public string Quack()
    {
        return ("redheadquaaaa!!!!...");
    }
}
