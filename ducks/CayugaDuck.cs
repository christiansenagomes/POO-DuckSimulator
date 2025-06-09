using DuckSimulator.Behaviors;  

namespace DuckSimulator.Ducks  
{  
    public class CayugaDuck : Duck  
    {  
        public CayugaDuck()  
        {  
            FlyBehavior = new FlyWithWings();  
            QuackBehavior = new NormalQuack();  
            DigBehavior = new CanDig();  
        }  

        public override void Display() => Console.WriteLine("Sou um Cayuga Duck!");  
    }  
}  