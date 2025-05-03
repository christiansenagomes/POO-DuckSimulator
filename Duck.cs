using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Duck
{
    //private string Cor {  get; set; }

    //public Duck(string cor)
    //{
    //    //Cor = cor;
    //}
    public void Swim()
    {
        Console.WriteLine("Nadando...");
    }

    public virtual void Display()
    {
        Console.WriteLine("Sou um Pato.");
    }
}
