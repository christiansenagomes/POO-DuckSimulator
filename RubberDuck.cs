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
        return ("Sou um Rubber Duck");
    }

    public string Quack()
    {
        return ("quaaaa!!!!...");
    }
}
