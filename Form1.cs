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
        List<Duck> ducks = Lake.GetInstance().GetDucks();
        List<Label> acoesLabel = new List<Label>();
        private int[] LabelCoords = { 340, 177 };

        int index = 0;
        public Form1()
        {
            InitializeComponent();

            nomePato.Text = ducks[index].Name;
            ShowActions(ducks[index]);
            HideArrowButton();
        }

        private void ShowActions(Duck duck)
        {
            HideActions();

            List<string> actions = GetDuckActions(duck);
            for(int i = 0; i < actions.Count; i++)
            {
                Label labelAcao = new Label();
                labelAcao.AutoSize = true;
                labelAcao.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.0F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                labelAcao.Location = new System.Drawing.Point(LabelCoords[0], LabelCoords[1] + (20 * i));
                labelAcao.Name = "labelAcaoPato";
                labelAcao.Size = new System.Drawing.Size(93, 33);
                labelAcao.TabIndex = 1;
                labelAcao.Text = actions[i];
                labelAcao.ForeColor = System.Drawing.Color.Green;
                Controls.Add(labelAcao);
                acoesLabel.Add(labelAcao);
            }
        }

        private void HideActions()
        {
            for(int i = 0; i < acoesLabel.Count; i++)
            {
                acoesLabel[i].Visible = false;
            }
            acoesLabel.Clear();
        }

        private void HideArrowButton()
        {
            if (index == ducks.Count - 1)
            {
                arrowRight.Visible = false;
            }

            if (index == 0)
            {
                arrowLeft.Visible = false;
            }
        }

        private List<string> GetDuckActions(Duck duck)
        {
            List<string> actions = new List<string>();

            if (duck is IFlyable flyableDuck) actions.Add("Voador");
            if (duck is IQuackable quackableDuck) actions.Add("Faz Quack");
            if (duck is Iinvisible invisibilityDuck) actions.Add("Invisibilidade");
            if (duck is ISpitfire spitterDuck) actions.Add("Cospe Fogo");
            if (duck is ISuperspeed fastDuck) actions.Add("Super Velocidade");
            if (duck is IExcavate excavatorDuck) actions.Add("Escavador");

            return actions;
        }

        private void arrowRight_Click(object sender, EventArgs e)
        {
            if(index < ducks.Count - 1)
            {
                index++;
                HideArrowButton();
            }

            if (index == 1)
            {
                arrowLeft.Visible = true;
            }
            
            nomePato.Text = ducks[index].Name;
            ShowActions(ducks[index]);
        }

        private void arrowLeft_Click(object sender, EventArgs e)
        {
            if (index > 0)
            {
                index--;
                HideArrowButton();
            }

            if(index == ducks.Count - 2)
            {
                arrowRight.Visible = true;
            }

            nomePato.Text = ducks[index].Name;
            ShowActions(ducks[index]);
        }

        private void selectDuck_Click(object sender, EventArgs e)
        {
            Form formDuckActions = new Form2(ducks[index]);
            formDuckActions.ShowDialog();
        }
    }
}
