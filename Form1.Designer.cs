namespace DuckSimulator
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.nomePato = new System.Windows.Forms.Label();
            this.arrowRight = new System.Windows.Forms.Button();
            this.arrowLeft = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(280, 331);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(185, 54);
            this.button1.TabIndex = 0;
            this.button1.Text = "Selecionar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.selectDuck_Click);
            // 
            // nomePato
            // 
            this.nomePato.AutoSize = true;
            this.nomePato.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nomePato.Location = new System.Drawing.Point(329, 143);
            this.nomePato.Name = "nomePato";
            this.nomePato.Size = new System.Drawing.Size(51, 20);
            this.nomePato.TabIndex = 1;
            this.nomePato.Text = "label1";
            // 
            // arrowRight
            // 
            this.arrowRight.Location = new System.Drawing.Point(529, 133);
            this.arrowRight.Name = "arrowRight";
            this.arrowRight.Size = new System.Drawing.Size(31, 94);
            this.arrowRight.TabIndex = 2;
            this.arrowRight.Text = ">";
            this.arrowRight.UseVisualStyleBackColor = true;
            this.arrowRight.Click += new System.EventHandler(this.arrowRight_Click);
            // 
            // arrowLeft
            // 
            this.arrowLeft.Location = new System.Drawing.Point(199, 133);
            this.arrowLeft.Name = "arrowLeft";
            this.arrowLeft.Size = new System.Drawing.Size(31, 94);
            this.arrowLeft.TabIndex = 3;
            this.arrowLeft.Text = "<";
            this.arrowLeft.UseVisualStyleBackColor = true;
            this.arrowLeft.Click += new System.EventHandler(this.arrowLeft_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.arrowLeft);
            this.Controls.Add(this.arrowRight);
            this.Controls.Add(this.nomePato);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label nomePato;
        private System.Windows.Forms.Button arrowRight;
        private System.Windows.Forms.Button arrowLeft;
    }
}

