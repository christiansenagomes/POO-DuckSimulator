using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class MuteDuck : Duck, IFlyable, IQuackable
{
    public MuteDuck(string cor) : base(cor)
    {
        Name = "Mute Duck";
    }

    public override string Display()
    {
        return "...";
    }
        public string Fly()
    {
        return("voando...");
    }
        public string Quack()
    {
        return("...");
    }

}