using DuckSimulator.Behaviors;  

namespace DuckSimulator.Ducks  
{  
    public class MuteDuck : Duck  
    {  
        public MuteDuck()  
        {  
            QuackBehavior = new MuteQuack();  
            FireBehavior = new Spiffire();  
        }  

        public override void Display() => Console.WriteLine("Sou um Mute Duck!");  
    }  
}  