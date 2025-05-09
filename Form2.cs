using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DuckSimulator
{
    public partial class Form2 : Form
    {
        Duck Duck;
        MallardDuck MallardDuck;
        RedHeadDuck RedHeadDuck;
        RubberDuck RubberDuck;
        public Form2(Duck duck)
        {
            InitializeComponent();
            Duck = duck;
            label1.Text = Duck.Name;
        }

        private void checkDuck(Duck duck)
        {
            switch (duck.Name)
            {
                case "Mallard Duck":
                    Duck = (MallardDuck)Duck;
                    break;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = Duck.Display();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = Duck.Swim();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //try
            //{
            //    //richTextBox1.Text = Duck.Fly();
            //}
        }
    }
}
