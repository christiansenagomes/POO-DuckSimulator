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
        string afraidStr = Afraid ? " e to com medo demais slc" : "";
        return ("Sou um Marreco Duck" + afraidStr);
    }

    public string Fly()
    {
        string afraidStr = Afraid ? "pra longe daqui" : "";
        return ("Voagem MARRECOOOO..." + afraidStr);
    }

    public string Quack()
    {
        return("Marrecooooquaaaa!!!!...");
    }

     public string Spit()
    {
        string afraidStr = Afraid ? "🔥🔥🔥🔥🔥🔥" : "";
        return ("🔥🔥🔥" + afraidStr);
    }
}
