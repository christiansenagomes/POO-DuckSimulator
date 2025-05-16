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
        Duck _Duck;
        public Form2(Duck duck)
        {
            _Duck = duck;

            InitializeComponent();
            label1.Text = _Duck.Name;
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
    }
}
