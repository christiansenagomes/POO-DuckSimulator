using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DuckSimulator
{
    public partial class Form1 : Form
    {
        List<Duck> ducks = new List<Duck>();
        int index = 0;
        public Form1()
        {
            ducks.Add(new MallardDuck("verde"));
            ducks.Add(new RedHeadDuck("vermelho"));
            ducks.Add(new RubberDuck("amarelo"));
            ducks.Add(new MarrecoDuck("marrom"));
            ducks.Add(new MuteDuck("..."));
            ducks.Add(new CayugaDuck("verde-água"));
            InitializeComponent();
            label1.Text = ducks[index].Name;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(index < ducks.Count - 1)
            {
                index++;
            }
            label1.Text = ducks[index].Name;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (index > 0)
            {
                index--;
            }
            label1.Text = ducks[index].Name;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form form2 = new Form2(ducks[index]);
            form2.ShowDialog();
        }
    }
}
