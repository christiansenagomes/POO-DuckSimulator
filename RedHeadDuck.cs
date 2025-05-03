using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class RedHeadDuck : Duck, IFlyable, IQuackable
{
    public override void Display()
    {
        Console.WriteLine("Sou um Red Head Duck");
    }

    public void Fly()
    {
        Console.Write("voar...");
    }

    public void Quack()
    {
        Console.Write("quaaaa!!!!...");
    }
}
