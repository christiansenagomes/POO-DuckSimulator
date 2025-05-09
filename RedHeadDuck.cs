using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class RedHeadDuck : Duck, IFlyable, IQuackable
{
    public RedHeadDuck()
    {
        Name = "RedHead Duck";
    }
    public override string Display()
    {
        return ("Sou um Red Head Duck");
    }

    public string Fly()
    {
        return ("voar...");
    }

    public string Quack()
    {
        return ("quaaaa!!!!...");
    }
}
