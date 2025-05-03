using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class RubberDuck : Duck, IQuackable
{
    public override void Display()
    {
        Console.WriteLine("Sou um Rubber Duck");
    }

    public void Quack()
    {
        Console.Write("quaaaa!!!!...");
    }
}
