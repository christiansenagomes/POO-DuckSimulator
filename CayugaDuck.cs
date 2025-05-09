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

    public void Fly()
    {
        Console.Write("Voação CayugaAAAAaaAAAA...");
    }

    public void Quack()
    {
        Console.Write("CAYUGAAAAAAAquaaaa!!!!...");
    }
}
