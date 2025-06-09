using DuckSimulator.Behaviors;  

namespace DuckSimulator.Ducks  
{  
    public abstract class Duck  
    {  
      
        protected IFlyBehavior FlyBehavior;  
        protected IQuackBehavior QuackBehavior;  
        protected IDigBehavior DigBehavior;  
        protected IRunBehavior RunBehavior;  
        protected IFireBehavior FireBehavior;  

     
        public void SetFlyBehavior(IFlyBehavior fb) => FlyBehavior = fb;  
        public void SetQuackBehavior(IQuackBehavior qb) => QuackBehavior = qb;  
        public void SetDigBehavior(IDigBehavior db) => DigBehavior = db;  
        public void SetRunBehavior(IRunBehavior rb) => RunBehavior = rb;  
        public void SetFireBehavior(IFireBehavior fb) => FireBehavior = fb;  


        public void PerformFly() => FlyBehavior?.Fly();  
        public void PerformQuack() => QuackBehavior?.Quack();  
        public void PerformDig() => DigBehavior?.Dig();  
        public void PerformRun() => RunBehavior?.Run();  
        public void PerformShootFire() => FireBehavior?.ShootFire();  

        public abstract void Display();  
    }  
}  