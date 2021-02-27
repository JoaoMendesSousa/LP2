
namespace TrabCalculadora
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
            this.label2 = new System.Windows.Forms.Label();
            this.TextNum2 = new System.Windows.Forms.TextBox();
            this.TextNum1 = new System.Windows.Forms.TextBox();
            this.TextResul = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.butmais = new System.Windows.Forms.Button();
            this.butmenos = new System.Windows.Forms.Button();
            this.butvezes = new System.Windows.Forms.Button();
            this.butdivisao = new System.Windows.Forms.Button();
            this.butSair = new System.Windows.Forms.Button();
            this.ButLimpar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 161);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Numero 1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 228);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Numero 2";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // TextNum2
            // 
            this.TextNum2.Location = new System.Drawing.Point(133, 228);
            this.TextNum2.Name = "TextNum2";
            this.TextNum2.Size = new System.Drawing.Size(300, 20);
            this.TextNum2.TabIndex = 3;
            this.TextNum2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // TextNum1
            // 
            this.TextNum1.Location = new System.Drawing.Point(133, 165);
            this.TextNum1.Name = "TextNum1";
            this.TextNum1.Size = new System.Drawing.Size(300, 20);
            this.TextNum1.TabIndex = 4;
            this.TextNum1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // TextResul
            // 
            this.TextResul.Enabled = false;
            this.TextResul.Location = new System.Drawing.Point(133, 295);
            this.TextResul.Name = "TextResul";
            this.TextResul.Size = new System.Drawing.Size(300, 20);
            this.TextResul.TabIndex = 5;
            this.TextResul.TextChanged += new System.EventHandler(this.resul_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 295);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 24);
            this.label3.TabIndex = 6;
            this.label3.Text = "Resultado";
            // 
            // butmais
            // 
            this.butmais.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butmais.Location = new System.Drawing.Point(466, 153);
            this.butmais.Name = "butmais";
            this.butmais.Size = new System.Drawing.Size(150, 80);
            this.butmais.TabIndex = 7;
            this.butmais.Text = "+";
            this.butmais.UseVisualStyleBackColor = true;
            this.butmais.Click += new System.EventHandler(this.butmais_Click);
            // 
            // butmenos
            // 
            this.butmenos.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butmenos.Location = new System.Drawing.Point(466, 239);
            this.butmenos.Name = "butmenos";
            this.butmenos.Size = new System.Drawing.Size(150, 80);
            this.butmenos.TabIndex = 8;
            this.butmenos.Text = "-";
            this.butmenos.UseVisualStyleBackColor = true;
            this.butmenos.Click += new System.EventHandler(this.butmenos_Click);
            // 
            // butvezes
            // 
            this.butvezes.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butvezes.Location = new System.Drawing.Point(622, 153);
            this.butvezes.Name = "butvezes";
            this.butvezes.Size = new System.Drawing.Size(150, 80);
            this.butvezes.TabIndex = 9;
            this.butvezes.Text = "*";
            this.butvezes.UseVisualStyleBackColor = true;
            this.butvezes.Click += new System.EventHandler(this.butvezes_Click);
            // 
            // butdivisao
            // 
            this.butdivisao.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butdivisao.Location = new System.Drawing.Point(622, 239);
            this.butdivisao.Name = "butdivisao";
            this.butdivisao.Size = new System.Drawing.Size(150, 80);
            this.butdivisao.TabIndex = 10;
            this.butdivisao.Text = "/";
            this.butdivisao.UseVisualStyleBackColor = true;
            this.butdivisao.Click += new System.EventHandler(this.butdivisao_Click);
            // 
            // butSair
            // 
            this.butSair.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butSair.Location = new System.Drawing.Point(318, 460);
            this.butSair.Name = "butSair";
            this.butSair.Size = new System.Drawing.Size(150, 80);
            this.butSair.TabIndex = 11;
            this.butSair.Text = "Sair";
            this.butSair.UseVisualStyleBackColor = true;
            this.butSair.Click += new System.EventHandler(this.button1_Click);
            // 
            // ButLimpar
            // 
            this.ButLimpar.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButLimpar.Location = new System.Drawing.Point(547, 325);
            this.ButLimpar.Name = "ButLimpar";
            this.ButLimpar.Size = new System.Drawing.Size(150, 80);
            this.ButLimpar.TabIndex = 12;
            this.ButLimpar.Text = "Limpar";
            this.ButLimpar.UseVisualStyleBackColor = true;
            this.ButLimpar.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.ButLimpar);
            this.Controls.Add(this.butSair);
            this.Controls.Add(this.butdivisao);
            this.Controls.Add(this.butvezes);
            this.Controls.Add(this.butmenos);
            this.Controls.Add(this.butmais);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TextResul);
            this.Controls.Add(this.TextNum1);
            this.Controls.Add(this.TextNum2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "Form1";
            this.Text = "Calculadora";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TextNum2;
        private System.Windows.Forms.TextBox TextNum1;
        private System.Windows.Forms.TextBox TextResul;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button butmais;
        private System.Windows.Forms.Button butmenos;
        private System.Windows.Forms.Button butvezes;
        private System.Windows.Forms.Button butdivisao;
        private System.Windows.Forms.Button butSair;
        private System.Windows.Forms.Button ButLimpar;
    }
}

