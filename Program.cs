public class Program
{
    public static void Main()
    {
        Duck duck = new Duck();
        duck.Swim();
        duck.Display();

        RedHeadDuck redHeadDuck = new RedHeadDuck();
        redHeadDuck.Swim();
        redHeadDuck.Fly();
        redHeadDuck.Quack();
        redHeadDuck.Display();

        MallardDuck mallardDuck = new MallardDuck();
        mallardDuck.Swim();
        mallardDuck.Fly();
        mallardDuck.Quack();
        mallardDuck.Display();

        RubberDuck rubberDuck = new RubberDuck();
        rubberDuck.Swim();
        rubberDuck.Quack();
        rubberDuck.Display();
    }
}