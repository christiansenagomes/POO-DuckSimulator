using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class CayugaDuck : Duck, IQuackable, IExcavate
{
    public CayugaDuck(string cor) : base(cor)
    {
        Name =  "Cayuga Duck";
        
    }

   
    public override string Display()
    {
        string afraidStr = Afraid ? " que está com muito medo" : "";
        return ("Sou um Cayuga Duck" + afraidStr);
    }

    public string Quack()
    {
        return("CAYUGAAAAAAAquaack!!!!...");
    }

    public string Dig ()
    {
        string afraidStr = Afraid ? "pra esconder, to morrendo de medo" : "";
        return ("Cavandoooo..." + afraidStr);
    }
}
