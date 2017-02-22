namespace JogoDesktop
{
    partial class Pergunta1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Pergunta1));
            this.lblPergunta = new System.Windows.Forms.Label();
            this.rdbResposta1 = new System.Windows.Forms.RadioButton();
            this.rdbResposta2 = new System.Windows.Forms.RadioButton();
            this.rdbResposta3 = new System.Windows.Forms.RadioButton();
            this.rdbResposta4 = new System.Windows.Forms.RadioButton();
            this.btnProxPergunta = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblPergunta
            // 
            this.lblPergunta.AutoSize = true;
            this.lblPergunta.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblPergunta.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblPergunta.Location = new System.Drawing.Point(58, 60);
            this.lblPergunta.Name = "lblPergunta";
            this.lblPergunta.Size = new System.Drawing.Size(272, 13);
            this.lblPergunta.TabIndex = 0;
            this.lblPergunta.Text = "Quanto ao nome da série, responda: Qual o significado?";
            this.lblPergunta.Click += new System.EventHandler(this.label1_Click);
            // 
            // rdbResposta1
            // 
            this.rdbResposta1.AutoSize = true;
            this.rdbResposta1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.rdbResposta1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.rdbResposta1.Location = new System.Drawing.Point(15, 174);
            this.rdbResposta1.Name = "rdbResposta1";
            this.rdbResposta1.Size = new System.Drawing.Size(209, 17);
            this.rdbResposta1.TabIndex = 1;
            this.rdbResposta1.TabStop = true;
            this.rdbResposta1.Text = "Livreto barato vendido na Era Vitoriana";
            this.rdbResposta1.UseVisualStyleBackColor = false;
            this.rdbResposta1.CheckedChanged += new System.EventHandler(this.rdbResposta1_CheckedChanged);
            // 
            // rdbResposta2
            // 
            this.rdbResposta2.AutoSize = true;
            this.rdbResposta2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.rdbResposta2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.rdbResposta2.Location = new System.Drawing.Point(15, 215);
            this.rdbResposta2.Name = "rdbResposta2";
            this.rdbResposta2.Size = new System.Drawing.Size(163, 17);
            this.rdbResposta2.TabIndex = 2;
            this.rdbResposta2.TabStop = true;
            this.rdbResposta2.Text = "Uma casa antiga em Londres";
            this.rdbResposta2.UseVisualStyleBackColor = false;
            this.rdbResposta2.CheckedChanged += new System.EventHandler(this.rdbResposta2_CheckedChanged);
            // 
            // rdbResposta3
            // 
            this.rdbResposta3.AutoSize = true;
            this.rdbResposta3.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.rdbResposta3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.rdbResposta3.Location = new System.Drawing.Point(15, 258);
            this.rdbResposta3.Name = "rdbResposta3";
            this.rdbResposta3.Size = new System.Drawing.Size(88, 17);
            this.rdbResposta3.TabIndex = 3;
            this.rdbResposta3.TabStop = true;
            this.rdbResposta3.Text = "Órgão genital";
            this.rdbResposta3.UseVisualStyleBackColor = false;
            // 
            // rdbResposta4
            // 
            this.rdbResposta4.AutoSize = true;
            this.rdbResposta4.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.rdbResposta4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.rdbResposta4.Location = new System.Drawing.Point(15, 295);
            this.rdbResposta4.Name = "rdbResposta4";
            this.rdbResposta4.Size = new System.Drawing.Size(58, 17);
            this.rdbResposta4.TabIndex = 4;
            this.rdbResposta4.TabStop = true;
            this.rdbResposta4.Text = "Moeda";
            this.rdbResposta4.UseVisualStyleBackColor = false;
            // 
            // btnProxPergunta
            // 
            this.btnProxPergunta.Location = new System.Drawing.Point(205, 304);
            this.btnProxPergunta.Name = "btnProxPergunta";
            this.btnProxPergunta.Size = new System.Drawing.Size(125, 33);
            this.btnProxPergunta.TabIndex = 5;
            this.btnProxPergunta.Text = "Próxima pergunta";
            this.btnProxPergunta.UseVisualStyleBackColor = true;
            this.btnProxPergunta.Click += new System.EventHandler(this.btnProxPergunta_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(136, 116);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(106, 20);
            this.textBox1.TabIndex = 6;
            this.textBox1.Text = "PENNY DREADFUL";
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Pergunta1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(386, 362);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnProxPergunta);
            this.Controls.Add(this.rdbResposta4);
            this.Controls.Add(this.rdbResposta3);
            this.Controls.Add(this.rdbResposta2);
            this.Controls.Add(this.rdbResposta1);
            this.Controls.Add(this.lblPergunta);
            this.Name = "Pergunta1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Primeira questão";
            this.Load += new System.EventHandler(this.Pergunta1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPergunta;
        private System.Windows.Forms.RadioButton rdbResposta1;
        private System.Windows.Forms.RadioButton rdbResposta2;
        private System.Windows.Forms.RadioButton rdbResposta3;
        private System.Windows.Forms.RadioButton rdbResposta4;
        private System.Windows.Forms.Button btnProxPergunta;
        private System.Windows.Forms.TextBox textBox1;
    }
}