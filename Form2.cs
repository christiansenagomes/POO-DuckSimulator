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
            nomePato.Text = _Duck.Name;

            if(_Duck.Afraid)
            {
                monsterButton.Text = "Monstro vai embora";
            }

            hideUnusedButtons();
        }

        private void hideUnusedButtons()
        {
            if (!(_Duck is IFlyable flyableDuck)) this.flyButton.Hide();
            if (!(_Duck is IQuackable quackableDuck)) this.quackButton.Hide();
            if (!(_Duck is Iinvisible invisibilityDuck)) this.invisibleButton.Hide();
            if (!(_Duck is ISpitfire spitterDuck)) this.spitfireButton.Hide();
            if (!(_Duck is ISuperspeed fastDuck)) this.speedButton.Hide();
            if (!(_Duck is IExcavate excavatorDuck)) this.excavateButton.Hide();
        }

        private void displayBtn_Click(object sender, EventArgs e)
        {
            actionTextbox.Text = _Duck.Display();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void swimBtn_Click(object sender, EventArgs e)
        {
            actionTextbox.Text = _Duck.Swim();
        }

        private void flyBtn_Click(object sender, EventArgs e)
        {
            if (_Duck is IFlyable flyableDuck)
            {
                actionTextbox.Text = flyableDuck.Fly();
            } else
            {
                MessageBox.Show("Ação não Disponível");
            }
        }

        private void quackBtn_Click(object sender, EventArgs e)
        {
            if (_Duck is IQuackable quackableDuck)
            {
                actionTextbox.Text = quackableDuck.Quack();
            } else
            {
                MessageBox.Show("Ação não Disponível");
            }
        }

        private void invisibleBtn_Click(object sender, EventArgs e)
        {
            if (_Duck is Iinvisible invisibleDuck)
            {
                actionTextbox.Text = invisibleDuck.Disappear();
            }
            else
            {
                MessageBox.Show("Ação não Disponível");
            }
        }

        private void spitfireBtn_Click(object sender, EventArgs e)
        {
            if (_Duck is ISpitfire spitterDuck)
            {
                actionTextbox.Text = spitterDuck.Spit();
            }
            else
            {
                MessageBox.Show("Ação não Disponível");
            }
        }

        private void speedBtn_Click(object sender, EventArgs e)
        {
            if (_Duck is ISuperspeed fastDuck)
            {
                actionTextbox.Text = fastDuck.Speed();
            }
            else
            {
                MessageBox.Show("Ação não Disponível");
            }
        }

        private void excavateBtn_Click(object sender, EventArgs e)
        {
            if (_Duck is IExcavate excavatorDuck)
            {
                actionTextbox.Text = excavatorDuck.Dig();
            }
            else
            {
                MessageBox.Show("Ação não Disponível");
            }
        }

        private void monsterButton_Click(object sender, EventArgs e)
        {
            Lake.GetInstance().Notify(!_Duck.Afraid);
            if(_Duck.Afraid)
            {
                monsterButton.Text = "Monstro vai embora";
            }
            else
            {
                monsterButton.Text = "Monstro no lago!!";
            }
        }
    }
}
