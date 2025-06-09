using DuckSimulator.Ducks;  
using DuckSimulator.Behaviors;  

class Program  
{  
    static void Main(string[] args)  
    {  
        Duck mallard = new MallardDuck();  
        mallard.Display();  
        mallard.PerformFly();  
        mallard.PerformQuack();  

        Duck rubberDuck = new RubberDuck();  
        rubberDuck.Display();  
        rubberDuck.PerformFly();  

        CayugaDuck cayuga = new CayugaDuck();  
        cayuga.Display();  
        cayuga.PerformDig();  

        MuteDuck muteDuck = new MuteDuck();  
        muteDuck.PerformShootFire();  

        MarrecoDuck marreco = new MarrecoDuck();  
        marreco.PerformRun();  
        
        rubberDuck.SetFlyBehavior(new FlyWithWings());  
        Console.WriteLine("\nPato de borracha agora pode voar!");  
        rubberDuck.PerformFly();  
    }  
}  