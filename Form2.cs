using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DuckSimulator
{
    public partial class Form2 : Form
    {
        Duck _Duck;
        public Form2(Duck duck)
        {
            _Duck = duck;

            InitializeComponent();
            label1.Text = _Duck.Name;

            hideUnusedButtons();
        }

        private void hideUnusedButtons()
        {
            if (!(_Duck is IFlyable flyableDuck)) this.button3.Hide();
            if (!(_Duck is IQuackable quackableDuck)) this.button4.Hide();
            if (!(_Duck is Iinvisible invisibilityDuck)) this.button5.Hide();
            if (!(_Duck is ISpitfire spitterDuck)) this.button6.Hide();
            if (!(_Duck is ISuperspeed fastDuck)) this.button7.Hide();
            if (!(_Duck is IExcavate excavatorDuck)) this.button8.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = _Duck.Display();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = _Duck.Swim();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (_Duck is IFlyable flyableDuck)
            {
                richTextBox1.Text = flyableDuck.Fly();
            } else
            {
                MessageBox.Show("Ação não Disponível");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (_Duck is IQuackable quackableDuck)
            {
                richTextBox1.Text = quackableDuck.Quack();
            } else
            {
                MessageBox.Show("Ação não Disponível");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (_Duck is Iinvisible invisibleDuck)
            {
                richTextBox1.Text = invisibleDuck.Disappear();
            }
            else
            {
                MessageBox.Show("Ação não Disponível");
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (_Duck is ISpitfire spitterDuck)
            {
                richTextBox1.Text = spitterDuck.Spit();
            }
            else
            {
                MessageBox.Show("Ação não Disponível");
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (_Duck is ISuperspeed fastDuck)
            {
                richTextBox1.Text = fastDuck.Speed();
            }
            else
            {
                MessageBox.Show("Ação não Disponível");
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (_Duck is IExcavate excavatorDuck)
            {
                richTextBox1.Text = excavatorDuck.Dig();
            }
            else
            {
                MessageBox.Show("Ação não Disponível");
            }
        }
    }
}
