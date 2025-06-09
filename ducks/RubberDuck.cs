using DuckSimulator.Behaviors;  

namespace DuckSimulator.Ducks  
{  
    public class RubberDuck : Duck  
    {  
        public RubberDuck()  
        {  
            FlyBehavior = new FlyNoWay();  
            QuackBehavior = new Squeak();  
        }  

        public override void Display() => Console.WriteLine("Sou um pato de borracha!");  
    }  
}  