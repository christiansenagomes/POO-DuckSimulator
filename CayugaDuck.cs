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
        return ("Sou um Cayuga Duck");
    }

    public string Quack()
    {
        return("CAYUGAAAAAAAquaack!!!!...");
    }

    public string Dig ()
    {
        return("Cavandoooo...");
    }
}
