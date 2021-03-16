
namespace CalcSalario
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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.maskTxtsalarioBruto = new System.Windows.Forms.MaskedTextBox();
            this.cmbBxsexo = new System.Windows.Forms.ComboBox();
            this.cBoxestadoCivil = new System.Windows.Forms.ComboBox();
            this.txtBNome = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.maskTxtaliquotaInss = new System.Windows.Forms.MaskedTextBox();
            this.maskTxtdescontoIrrf = new System.Windows.Forms.MaskedTextBox();
            this.maskTxtDescontoINSS = new System.Windows.Forms.MaskedTextBox();
            this.maskTxtsalarioFamilia = new System.Windows.Forms.MaskedTextBox();
            this.maskTxtbxAliquotairrf = new System.Windows.Forms.MaskedTextBox();
            this.masktxtSalarioLiquido = new System.Windows.Forms.MaskedTextBox();
            this.cmbBxnFilhos = new System.Windows.Forms.ComboBox();
            this.txtBoxinformação = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(27, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome do Funcionario";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(27, 176);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Salario Bruto";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(27, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "Numero de filhos";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(27, 146);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "Sexo";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(27, 87);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 20);
            this.label5.TabIndex = 10;
            this.label5.Text = "Estado Civil";
            // 
            // maskTxtsalarioBruto
            // 
            this.maskTxtsalarioBruto.Location = new System.Drawing.Point(124, 178);
            this.maskTxtsalarioBruto.Mask = "0000.00";
            this.maskTxtsalarioBruto.Name = "maskTxtsalarioBruto";
            this.maskTxtsalarioBruto.Size = new System.Drawing.Size(203, 20);
            this.maskTxtsalarioBruto.TabIndex = 13;
            // 
            // cmbBxsexo
            // 
            this.cmbBxsexo.FormattingEnabled = true;
            this.cmbBxsexo.Items.AddRange(new object[] {
            "Masculino",
            "Feminino"});
            this.cmbBxsexo.Location = new System.Drawing.Point(72, 146);
            this.cmbBxsexo.Name = "cmbBxsexo";
            this.cmbBxsexo.Size = new System.Drawing.Size(203, 21);
            this.cmbBxsexo.TabIndex = 14;
            this.cmbBxsexo.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // cBoxestadoCivil
            // 
            this.cBoxestadoCivil.FormattingEnabled = true;
            this.cBoxestadoCivil.Items.AddRange(new object[] {
            "Solteiro",
            "Casado"});
            this.cBoxestadoCivil.Location = new System.Drawing.Point(117, 86);
            this.cBoxestadoCivil.Name = "cBoxestadoCivil";
            this.cBoxestadoCivil.Size = new System.Drawing.Size(203, 21);
            this.cBoxestadoCivil.TabIndex = 15;
            // 
            // txtBNome
            // 
            this.txtBNome.Location = new System.Drawing.Point(177, 57);
            this.txtBNome.Name = "txtBNome";
            this.txtBNome.Size = new System.Drawing.Size(203, 20);
            this.txtBNome.TabIndex = 16;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(31, 229);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(170, 38);
            this.button1.TabIndex = 17;
            this.button1.Text = "Verificar Desconto";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(11, 372);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(96, 20);
            this.label6.TabIndex = 18;
            this.label6.Text = "Aliquota INSS";
            this.label6.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(12, 405);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(95, 20);
            this.label7.TabIndex = 19;
            this.label7.Text = "Aliquota IRRF";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(539, 374);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(103, 20);
            this.label8.TabIndex = 20;
            this.label8.Text = "Salário Familia";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(537, 407);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(105, 20);
            this.label9.TabIndex = 21;
            this.label9.Text = "Salario Liquido";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(269, 405);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(102, 20);
            this.label10.TabIndex = 22;
            this.label10.Text = "Desconto INSS";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(269, 370);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(101, 20);
            this.label11.TabIndex = 23;
            this.label11.Text = "Desconto IRRF";
            // 
            // maskTxtaliquotaInss
            // 
            this.maskTxtaliquotaInss.Enabled = false;
            this.maskTxtaliquotaInss.Location = new System.Drawing.Point(113, 372);
            this.maskTxtaliquotaInss.Mask = "00,00%";
            this.maskTxtaliquotaInss.Name = "maskTxtaliquotaInss";
            this.maskTxtaliquotaInss.Size = new System.Drawing.Size(140, 20);
            this.maskTxtaliquotaInss.TabIndex = 24;
            // 
            // maskTxtdescontoIrrf
            // 
            this.maskTxtdescontoIrrf.Enabled = false;
            this.maskTxtdescontoIrrf.Location = new System.Drawing.Point(376, 374);
            this.maskTxtdescontoIrrf.Mask = "9999,00";
            this.maskTxtdescontoIrrf.Name = "maskTxtdescontoIrrf";
            this.maskTxtdescontoIrrf.Size = new System.Drawing.Size(140, 20);
            this.maskTxtdescontoIrrf.TabIndex = 26;
            // 
            // maskTxtDescontoINSS
            // 
            this.maskTxtDescontoINSS.Enabled = false;
            this.maskTxtDescontoINSS.Location = new System.Drawing.Point(377, 407);
            this.maskTxtDescontoINSS.Mask = "9999,99";
            this.maskTxtDescontoINSS.Name = "maskTxtDescontoINSS";
            this.maskTxtDescontoINSS.Size = new System.Drawing.Size(140, 20);
            this.maskTxtDescontoINSS.TabIndex = 27;
            // 
            // maskTxtsalarioFamilia
            // 
            this.maskTxtsalarioFamilia.Enabled = false;
            this.maskTxtsalarioFamilia.Location = new System.Drawing.Point(648, 374);
            this.maskTxtsalarioFamilia.Mask = "9999,99";
            this.maskTxtsalarioFamilia.Name = "maskTxtsalarioFamilia";
            this.maskTxtsalarioFamilia.Size = new System.Drawing.Size(140, 20);
            this.maskTxtsalarioFamilia.TabIndex = 28;
            // 
            // maskTxtbxAliquotairrf
            // 
            this.maskTxtbxAliquotairrf.Enabled = false;
            this.maskTxtbxAliquotairrf.Location = new System.Drawing.Point(113, 405);
            this.maskTxtbxAliquotairrf.Mask = "00.00%";
            this.maskTxtbxAliquotairrf.Name = "maskTxtbxAliquotairrf";
            this.maskTxtbxAliquotairrf.Size = new System.Drawing.Size(140, 20);
            this.maskTxtbxAliquotairrf.TabIndex = 29;
            // 
            // masktxtSalarioLiquido
            // 
            this.masktxtSalarioLiquido.Enabled = false;
            this.masktxtSalarioLiquido.Location = new System.Drawing.Point(648, 409);
            this.masktxtSalarioLiquido.Mask = "9999,99";
            this.masktxtSalarioLiquido.Name = "masktxtSalarioLiquido";
            this.masktxtSalarioLiquido.Size = new System.Drawing.Size(140, 20);
            this.masktxtSalarioLiquido.TabIndex = 30;
            // 
            // cmbBxnFilhos
            // 
            this.cmbBxnFilhos.FormattingEnabled = true;
            this.cmbBxnFilhos.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12"});
            this.cmbBxnFilhos.Location = new System.Drawing.Point(149, 119);
            this.cmbBxnFilhos.Name = "cmbBxnFilhos";
            this.cmbBxnFilhos.Size = new System.Drawing.Size(203, 21);
            this.cmbBxnFilhos.TabIndex = 31;
            // 
            // txtBoxinformação
            // 
            this.txtBoxinformação.Enabled = false;
            this.txtBoxinformação.Location = new System.Drawing.Point(31, 292);
            this.txtBoxinformação.Multiline = true;
            this.txtBoxinformação.Name = "txtBoxinformação";
            this.txtBoxinformação.Size = new System.Drawing.Size(279, 55);
            this.txtBoxinformação.TabIndex = 32;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtBoxinformação);
            this.Controls.Add(this.cmbBxnFilhos);
            this.Controls.Add(this.masktxtSalarioLiquido);
            this.Controls.Add(this.maskTxtbxAliquotairrf);
            this.Controls.Add(this.maskTxtsalarioFamilia);
            this.Controls.Add(this.maskTxtDescontoINSS);
            this.Controls.Add(this.maskTxtdescontoIrrf);
            this.Controls.Add(this.maskTxtaliquotaInss);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtBNome);
            this.Controls.Add(this.cBoxestadoCivil);
            this.Controls.Add(this.cmbBxsexo);
            this.Controls.Add(this.maskTxtsalarioBruto);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.MaskedTextBox maskTxtsalarioBruto;
        private System.Windows.Forms.ComboBox cmbBxsexo;
        private System.Windows.Forms.ComboBox cBoxestadoCivil;
        private System.Windows.Forms.TextBox txtBNome;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.MaskedTextBox maskTxtaliquotaInss;
        private System.Windows.Forms.MaskedTextBox maskTxtdescontoIrrf;
        private System.Windows.Forms.MaskedTextBox maskTxtDescontoINSS;
        private System.Windows.Forms.MaskedTextBox maskTxtsalarioFamilia;
        private System.Windows.Forms.MaskedTextBox maskTxtbxAliquotairrf;
        private System.Windows.Forms.MaskedTextBox masktxtSalarioLiquido;
        private System.Windows.Forms.ComboBox cmbBxnFilhos;
        private System.Windows.Forms.TextBox txtBoxinformação;
    }
}

