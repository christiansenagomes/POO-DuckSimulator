using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class CayugaDuck : Duck, IFlyable, IQuackable
{
    public CayugaDuck(string cor) : base(cor)
    {
        Name =  "Cayuga Duck";
        
    }

   
    public override string Display()
    {
        return ("Sou um Cayuga Duck");
    }

    public string Fly()
    {
        return("Voação CayugaAAAAaaAAAA...");
    }

    public string Quack()
    {
        return("CAYUGAAAAAAAquaack!!!!...");
    }
}
