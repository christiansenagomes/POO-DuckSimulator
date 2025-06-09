using DuckSimulator.Behaviors;  

namespace DuckSimulator.Ducks  
{  
    public class MallardDuck : Duck  
    {  
        public MallardDuck()  
        {  
            FlyBehavior = new FlyWithWings();  
            QuackBehavior = new NormalQuack();  
        }  

        public override void Display() => Console.WriteLine("Sou um Mallard Duck!");  
    }  
}  