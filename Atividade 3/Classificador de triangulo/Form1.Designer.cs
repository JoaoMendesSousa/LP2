
namespace Classificador_de_triangulo
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
            this.label4 = new System.Windows.Forms.Label();
            this.txtBtriangulo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBc = new System.Windows.Forms.TextBox();
            this.txtBb = new System.Windows.Forms.TextBox();
            this.txtBa = new System.Windows.Forms.TextBox();
            this.BtnIdentificar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 353);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(144, 23);
            this.label4.TabIndex = 6;
            this.label4.Text = "Tipo de Triangulo";
            // 
            // txtBtriangulo
            // 
            this.txtBtriangulo.Enabled = false;
            this.txtBtriangulo.Location = new System.Drawing.Point(162, 358);
            this.txtBtriangulo.Name = "txtBtriangulo";
            this.txtBtriangulo.Size = new System.Drawing.Size(251, 20);
            this.txtBtriangulo.TabIndex = 7;
            this.txtBtriangulo.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(120, 122);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 23);
            this.label1.TabIndex = 8;
            this.label1.Text = "A";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(120, 175);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(21, 23);
            this.label2.TabIndex = 9;
            this.label2.Text = "B";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(120, 233);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(21, 23);
            this.label3.TabIndex = 10;
            this.label3.Text = "C";
            // 
            // txtBc
            // 
            this.txtBc.Location = new System.Drawing.Point(162, 238);
            this.txtBc.Name = "txtBc";
            this.txtBc.Size = new System.Drawing.Size(251, 20);
            this.txtBc.TabIndex = 11;
            // 
            // txtBb
            // 
            this.txtBb.Location = new System.Drawing.Point(162, 180);
            this.txtBb.Name = "txtBb";
            this.txtBb.Size = new System.Drawing.Size(251, 20);
            this.txtBb.TabIndex = 12;
            // 
            // txtBa
            // 
            this.txtBa.Location = new System.Drawing.Point(162, 127);
            this.txtBa.Name = "txtBa";
            this.txtBa.Size = new System.Drawing.Size(251, 20);
            this.txtBa.TabIndex = 13;
            // 
            // BtnIdentificar
            // 
            this.BtnIdentificar.Location = new System.Drawing.Point(255, 283);
            this.BtnIdentificar.Name = "BtnIdentificar";
            this.BtnIdentificar.Size = new System.Drawing.Size(66, 54);
            this.BtnIdentificar.TabIndex = 14;
            this.BtnIdentificar.Text = "Iniciar";
            this.BtnIdentificar.UseVisualStyleBackColor = true;
            this.BtnIdentificar.Click += new System.EventHandler(this.BtnIdentificar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(586, 470);
            this.Controls.Add(this.BtnIdentificar);
            this.Controls.Add(this.txtBa);
            this.Controls.Add(this.txtBb);
            this.Controls.Add(this.txtBc);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtBtriangulo);
            this.Controls.Add(this.label4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Form1";
            this.Text = "Classificador de triangulo";
            this.TransparencyKey = System.Drawing.Color.DarkMagenta;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtBtriangulo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtBc;
        private System.Windows.Forms.TextBox txtBb;
        private System.Windows.Forms.TextBox txtBa;
        private System.Windows.Forms.Button BtnIdentificar;
    }
}

