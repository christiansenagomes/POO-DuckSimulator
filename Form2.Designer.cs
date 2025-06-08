using System.Windows.Forms;

namespace DuckSimulator
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.actionTextbox = new System.Windows.Forms.RichTextBox();
            this.nomePato = new System.Windows.Forms.Label();
            this.displayButton = new System.Windows.Forms.Button();
            this.swimButton = new System.Windows.Forms.Button();
            this.flyButton = new System.Windows.Forms.Button();
            this.quackButton = new System.Windows.Forms.Button();
            this.invisibleButton = new System.Windows.Forms.Button();
            this.spitfireButton = new System.Windows.Forms.Button();
            this.speedButton = new System.Windows.Forms.Button();
            this.excavateButton = new System.Windows.Forms.Button();
            this.monsterButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // actionTextbox
            // 
            this.actionTextbox.Location = new System.Drawing.Point(192, 164);
            this.actionTextbox.Name = "actionTextbox";
            this.actionTextbox.ReadOnly = true;
            this.actionTextbox.Size = new System.Drawing.Size(375, 158);
            this.actionTextbox.TabIndex = 0;
            this.actionTextbox.Text = "";
            this.actionTextbox.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // nomePato
            // 
            this.nomePato.AutoSize = true;
            this.nomePato.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nomePato.Location = new System.Drawing.Point(285, 97);
            this.nomePato.Name = "nomePato";
            this.nomePato.Size = new System.Drawing.Size(93, 33);
            this.nomePato.TabIndex = 1;
            this.nomePato.Text = "label1";
            // 
            // displayButton
            // 
            this.displayButton.Location = new System.Drawing.Point(26, 368);
            this.displayButton.Name = "displayButton";
            this.displayButton.Size = new System.Drawing.Size(75, 23);
            this.displayButton.TabIndex = 2;
            this.displayButton.Text = "Display";
            this.displayButton.UseVisualStyleBackColor = true;
            this.displayButton.Click += new System.EventHandler(this.displayBtn_Click);
            // 
            // swimButton
            // 
            this.swimButton.Location = new System.Drawing.Point(125, 368);
            this.swimButton.Name = "swimButton";
            this.swimButton.Size = new System.Drawing.Size(75, 23);
            this.swimButton.TabIndex = 3;
            this.swimButton.Text = "Swim";
            this.swimButton.UseVisualStyleBackColor = true;
            this.swimButton.Click += new System.EventHandler(this.swimBtn_Click);
            // 
            // flyButton
            // 
            this.flyButton.Location = new System.Drawing.Point(221, 368);
            this.flyButton.Name = "flyButton";
            this.flyButton.Size = new System.Drawing.Size(75, 23);
            this.flyButton.TabIndex = 4;
            this.flyButton.Text = "Fly";
            this.flyButton.UseVisualStyleBackColor = true;
            this.flyButton.Click += new System.EventHandler(this.flyBtn_Click);
            // 
            // quackButton
            // 
            this.quackButton.Location = new System.Drawing.Point(314, 368);
            this.quackButton.Name = "quackButton";
            this.quackButton.Size = new System.Drawing.Size(75, 23);
            this.quackButton.TabIndex = 5;
            this.quackButton.Text = "Quack";
            this.quackButton.UseVisualStyleBackColor = true;
            this.quackButton.Click += new System.EventHandler(this.quackBtn_Click);
            // 
            // invisibleButton
            // 
            this.invisibleButton.Location = new System.Drawing.Point(413, 368);
            this.invisibleButton.Name = "invisibleButton";
            this.invisibleButton.Size = new System.Drawing.Size(75, 23);
            this.invisibleButton.TabIndex = 6;
            this.invisibleButton.Text = "Invisible";
            this.invisibleButton.UseVisualStyleBackColor = true;
            this.invisibleButton.Click += new System.EventHandler(this.invisibleBtn_Click);
            // 
            // spitfireButton
            // 
            this.spitfireButton.Location = new System.Drawing.Point(506, 368);
            this.spitfireButton.Name = "spitfireButton";
            this.spitfireButton.Size = new System.Drawing.Size(75, 23);
            this.spitfireButton.TabIndex = 7;
            this.spitfireButton.Text = "Spit Fire";
            this.spitfireButton.UseVisualStyleBackColor = true;
            this.spitfireButton.Click += new System.EventHandler(this.spitfireBtn_Click);
            // 
            // speedButton
            // 
            this.speedButton.Location = new System.Drawing.Point(598, 368);
            this.speedButton.Name = "speedButton";
            this.speedButton.Size = new System.Drawing.Size(75, 23);
            this.speedButton.TabIndex = 8;
            this.speedButton.Text = "I Am Speed";
            this.speedButton.UseVisualStyleBackColor = true;
            this.speedButton.Click += new System.EventHandler(this.speedBtn_Click);
            // 
            // excavateButton
            // 
            this.excavateButton.Location = new System.Drawing.Point(690, 368);
            this.excavateButton.Name = "excavateButton";
            this.excavateButton.Size = new System.Drawing.Size(75, 23);
            this.excavateButton.TabIndex = 9;
            this.excavateButton.Text = "Excavate";
            this.excavateButton.UseVisualStyleBackColor = true;
            this.excavateButton.Click += new System.EventHandler(this.excavateBtn_Click);
            // 
            // monsterButton
            // 
            this.monsterButton.Location = new System.Drawing.Point(300, 415);
            this.monsterButton.Name = "monsterButton";
            this.monsterButton.Size = new System.Drawing.Size(144, 23);
            this.monsterButton.TabIndex = 10;
            this.monsterButton.Text = "Monstro no lago!!";
            this.monsterButton.UseVisualStyleBackColor = true;
            this.monsterButton.Click += new System.EventHandler(this.monsterButton_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.monsterButton);
            this.Controls.Add(this.excavateButton);
            this.Controls.Add(this.speedButton);
            this.Controls.Add(this.spitfireButton);
            this.Controls.Add(this.invisibleButton);
            this.Controls.Add(this.quackButton);
            this.Controls.Add(this.flyButton);
            this.Controls.Add(this.swimButton);
            this.Controls.Add(this.displayButton);
            this.Controls.Add(this.nomePato);
            this.Controls.Add(this.actionTextbox);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox actionTextbox;
        private System.Windows.Forms.Label nomePato;
        private System.Windows.Forms.Button displayButton;
        private System.Windows.Forms.Button swimButton;
        private System.Windows.Forms.Button flyButton;
        private System.Windows.Forms.Button quackButton;
        private System.Windows.Forms.Button invisibleButton;
        private System.Windows.Forms.Button spitfireButton;
        private System.Windows.Forms.Button speedButton;
        private Button excavateButton;
        private Button monsterButton;
    }
}