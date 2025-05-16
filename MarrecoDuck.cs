using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class MarrecoDuck : Duck, IFlyable, IQuackable, ISpitfire
{
    public MarrecoDuck(string cor) : base(cor)
    {
        Name =  "Marreco Duck";
    }

   
    public override string Display()
    {
        return ("Sou um Marreco Duck");
    }

    public string Fly()
    {
        return("Voagem MARRECOOOO...");
    }

    public string Quack()
    {
        return("Marrecooooquaaaa!!!!...");
    }

     public string Spit()
    {
        return("🔥🔥🔥");
    }
}
