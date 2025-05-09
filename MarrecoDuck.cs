using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class MarrecoDuck : Duck, IFlyable, IQuackable
{
    public MarrecoDuck(string cor) : base(cor)
    {
        Name =  "Marreco Duck";
    }

   
    public override string Display()
    {
        return ("Sou um Marreco Duck");
    }

    public void Fly()
    {
        Console.Write("Voagem MARRECOOOO...");
    }

    public void Quack()
    {
        Console.Write("Marrecooooquaaaa!!!!...");
    }
}
