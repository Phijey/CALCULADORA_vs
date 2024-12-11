namespace Calculadora
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.btnSoma = new System.Windows.Forms.Button();
            this.btnMed = new System.Windows.Forms.Button();
            this.btnMax = new System.Windows.Forms.Button();
            this.btnMin = new System.Windows.Forms.Button();
            this.btnElev = new System.Windows.Forms.Button();
            this.txtResul = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(159, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Digite Cinco Números";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(177, 51);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 22);
            this.textBox1.TabIndex = 1;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(177, 79);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 22);
            this.textBox2.TabIndex = 2;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(177, 107);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 22);
            this.textBox3.TabIndex = 3;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(177, 135);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 22);
            this.textBox4.TabIndex = 4;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(177, 163);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(100, 22);
            this.textBox5.TabIndex = 5;
            // 
            // btnSoma
            // 
            this.btnSoma.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnSoma.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.btnSoma.Location = new System.Drawing.Point(539, 36);
            this.btnSoma.Name = "btnSoma";
            this.btnSoma.Size = new System.Drawing.Size(65, 65);
            this.btnSoma.TabIndex = 6;
            this.btnSoma.Text = "+";
            this.btnSoma.UseVisualStyleBackColor = false;
            this.btnSoma.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnMed
            // 
            this.btnMed.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnMed.Location = new System.Drawing.Point(610, 36);
            this.btnMed.Name = "btnMed";
            this.btnMed.Size = new System.Drawing.Size(65, 65);
            this.btnMed.TabIndex = 7;
            this.btnMed.Text = "Média";
            this.btnMed.UseVisualStyleBackColor = false;
            this.btnMed.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnMax
            // 
            this.btnMax.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnMax.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.btnMax.Location = new System.Drawing.Point(539, 107);
            this.btnMax.Name = "btnMax";
            this.btnMax.Size = new System.Drawing.Size(65, 65);
            this.btnMax.TabIndex = 8;
            this.btnMax.Text = ">";
            this.btnMax.UseVisualStyleBackColor = false;
            this.btnMax.Click += new System.EventHandler(this.btnMax_Click);
            // 
            // btnMin
            // 
            this.btnMin.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnMin.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.btnMin.Location = new System.Drawing.Point(610, 107);
            this.btnMin.Name = "btnMin";
            this.btnMin.Size = new System.Drawing.Size(65, 65);
            this.btnMin.TabIndex = 9;
            this.btnMin.Text = "<";
            this.btnMin.UseVisualStyleBackColor = false;
            this.btnMin.Click += new System.EventHandler(this.button4_Click);
            // 
            // btnElev
            // 
            this.btnElev.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnElev.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.btnElev.Location = new System.Drawing.Point(577, 178);
            this.btnElev.Name = "btnElev";
            this.btnElev.Size = new System.Drawing.Size(65, 65);
            this.btnElev.TabIndex = 10;
            this.btnElev.Text = "^";
            this.btnElev.UseVisualStyleBackColor = false;
            this.btnElev.Click += new System.EventHandler(this.btnElev_Click);
            // 
            // txtResul
            // 
            this.txtResul.Location = new System.Drawing.Point(308, 322);
            this.txtResul.Name = "txtResul";
            this.txtResul.Size = new System.Drawing.Size(100, 22);
            this.txtResul.TabIndex = 11;
            this.txtResul.TextChanged += new System.EventHandler(this.textBox6_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(233, 325);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 16);
            this.label2.TabIndex = 12;
            this.label2.Text = "Resposta:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtResul);
            this.Controls.Add(this.btnElev);
            this.Controls.Add(this.btnMin);
            this.Controls.Add(this.btnMax);
            this.Controls.Add(this.btnMed);
            this.Controls.Add(this.btnSoma);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Button btnSoma;
        private System.Windows.Forms.Button btnMed;
        private System.Windows.Forms.Button btnMax;
        private System.Windows.Forms.Button btnMin;
        private System.Windows.Forms.Button btnElev;
        private System.Windows.Forms.TextBox txtResul;
        private System.Windows.Forms.Label label2;
    }
}

