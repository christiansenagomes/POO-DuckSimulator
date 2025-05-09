using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class MallardDuck : Duck, IFlyable, IQuackable
{
    public MallardDuck(string cor) : base(cor)
    {
        
        Name =  "Mallard Duck";
         
    }
    public override string Display()
    {
        return ("Sou um Mallard Duck");
    }

    public string Fly()
    {
        return ("voar...");
    }

    public string Quack()
    {
        return ("mallardquaaaa!!!!...");
    }
}
