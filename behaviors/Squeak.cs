namespace DuckSimulator.Behaviors  
{  
    public class Squeak : IQuackBehavior  
    {  
        public void Quack()  
        {  
            Console.WriteLine("Squeak!");  
        }  
    }  
}  