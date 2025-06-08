using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class MallardDuck : Duck, IFlyable, IQuackable, ISuperspeed
{
    public MallardDuck(string cor) : base(cor)
    {
        
        Name =  "Mallard Duck";
         
    }
    public override string Display()
    {
        string afraidStr = Afraid ? " com medo" : "";
        return ("Sou um Mallard Duck" + afraidStr);
    }

    public string Fly()
    {
        string afraidStr = Afraid ? "pra longe daqui" : "";
        return ("voar..." + afraidStr);
    }

    public string Quack()
    {
        return ("mallardquaaaa!!!!...");
    }

     public string Speed()
    {
        string afraidStr = Afraid ? "💨💨💨💨💨💨💨💨💨💨💨💨💨" : "";
        return ("🦆💨" + afraidStr);
    }
}
