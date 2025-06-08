using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class MuteDuck : Duck, IFlyable, Iinvisible
{
    public MuteDuck(string cor) : base(cor)
    {
        Name = "Mute Duck";
    }

    public override string Display()
    {
        string afraidStr = Afraid ? "..........." : "";
        return "..." + afraidStr;
    }
    public string Fly()
    {
        string afraidStr = Afraid ? " ... ..." : "";
        return ("voando..." + afraidStr);
    }
    

    public string Disappear ()
    {
        string afraidStr = Afraid ? " :)" : "";
        return "..." + afraidStr;
    }

}