﻿using System;
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
        List<Label> acoesLabel = new List<Label>();
        private int[] LabelCoords = { 340, 177 };

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
            ShowActions(ducks[index]);
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
                labelAcao.Name = "label1";
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
            ShowActions(ducks[index]);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (index > 0)
            {
                index--;
            }
            label1.Text = ducks[index].Name;
            ShowActions(ducks[index]);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form form2 = new Form2(ducks[index]);
            form2.ShowDialog();
        }
    }
}
