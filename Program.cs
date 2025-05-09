using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DuckSimulator
{
    internal static class Program
    {
        /// <summary>
        /// Ponto de entrada principal para o aplicativo.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());

            //Duck duck = new Duck();
            //duck.Swim();
            //duck.Display();

            //RedHeadDuck redHeadDuck = new RedHeadDuck();
            //redHeadDuck.Swim();
            //redHeadDuck.Fly();
            //redHeadDuck.Quack();
            //redHeadDuck.Display();

            //MallardDuck mallardDuck = new MallardDuck();
            //mallardDuck.Swim();
            //mallardDuck.Fly();
            //mallardDuck.Quack();
            //mallardDuck.Display();

            //RubberDuck rubberDuck = new RubberDuck();
            //rubberDuck.Swim();
            //rubberDuck.Quack();
            //rubberDuck.Display();
        }
    }
}
