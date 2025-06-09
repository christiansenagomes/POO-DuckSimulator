using DuckSimulator.Behaviors;  

namespace DuckSimulator.Ducks  
{  
    public class MarrecoDuck : Duck  
    {  
        public MarrecoDuck()  
        {  
            FlyBehavior = new FlyNoWay();  
            QuackBehavior = new Squeak();  
            RunBehavior = new SuperSpeed();  
        }  

        public override void Display() => Console.WriteLine("Sou um Marreco Duck!");  
    }  
}  