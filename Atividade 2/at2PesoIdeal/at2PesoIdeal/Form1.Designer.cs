
namespace at2PesoIdeal
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
            this.lablAltura = new System.Windows.Forms.Label();
            this.lablPeso = new System.Windows.Forms.Label();
            this.lablSexo = new System.Windows.Forms.Label();
            this.radBtonMasculino = new System.Windows.Forms.RadioButton();
            this.radBtonFeminino = new System.Windows.Forms.RadioButton();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.lblPesoIdeal = new System.Windows.Forms.Label();
            this.txtbPesoIdeal = new System.Windows.Forms.TextBox();
            this.MaskBxaltura = new System.Windows.Forms.MaskedTextBox();
            this.maskBoxpeso = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // lablAltura
            // 
            this.lablAltura.AutoSize = true;
            this.lablAltura.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lablAltura.Location = new System.Drawing.Point(23, 88);
            this.lablAltura.Name = "lablAltura";
            this.lablAltura.Size = new System.Drawing.Size(70, 24);
            this.lablAltura.TabIndex = 0;
            this.lablAltura.Text = "Altura";
            // 
            // lablPeso
            // 
            this.lablPeso.AutoSize = true;
            this.lablPeso.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lablPeso.Location = new System.Drawing.Point(23, 127);
            this.lablPeso.Name = "lablPeso";
            this.lablPeso.Size = new System.Drawing.Size(61, 24);
            this.lablPeso.TabIndex = 1;
            this.lablPeso.Text = "Peso";
            // 
            // lablSexo
            // 
            this.lablSexo.AutoSize = true;
            this.lablSexo.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lablSexo.Location = new System.Drawing.Point(23, 172);
            this.lablSexo.Name = "lablSexo";
            this.lablSexo.Size = new System.Drawing.Size(61, 24);
            this.lablSexo.TabIndex = 2;
            this.lablSexo.Text = "Sexo";
            // 
            // radBtonMasculino
            // 
            this.radBtonMasculino.AutoSize = true;
            this.radBtonMasculino.Location = new System.Drawing.Point(99, 178);
            this.radBtonMasculino.Name = "radBtonMasculino";
            this.radBtonMasculino.Size = new System.Drawing.Size(73, 17);
            this.radBtonMasculino.TabIndex = 5;
            this.radBtonMasculino.Text = "Masculino";
            this.radBtonMasculino.UseVisualStyleBackColor = true;
            this.radBtonMasculino.CheckedChanged += new System.EventHandler(this.radBtonMasculino_CheckedChanged);
            // 
            // radBtonFeminino
            // 
            this.radBtonFeminino.AutoSize = true;
            this.radBtonFeminino.Location = new System.Drawing.Point(190, 179);
            this.radBtonFeminino.Name = "radBtonFeminino";
            this.radBtonFeminino.Size = new System.Drawing.Size(67, 17);
            this.radBtonFeminino.TabIndex = 6;
            this.radBtonFeminino.Text = "Feminino";
            this.radBtonFeminino.UseVisualStyleBackColor = true;
            this.radBtonFeminino.CheckedChanged += new System.EventHandler(this.radBtonFeminino_CheckedChanged);
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(328, 348);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(129, 90);
            this.btnCalcular.TabIndex = 7;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // lblPesoIdeal
            // 
            this.lblPesoIdeal.AutoSize = true;
            this.lblPesoIdeal.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPesoIdeal.Location = new System.Drawing.Point(23, 258);
            this.lblPesoIdeal.Name = "lblPesoIdeal";
            this.lblPesoIdeal.Size = new System.Drawing.Size(114, 24);
            this.lblPesoIdeal.TabIndex = 8;
            this.lblPesoIdeal.Text = "Peso Ideal";
            // 
            // txtbPesoIdeal
            // 
            this.txtbPesoIdeal.AcceptsReturn = true;
            this.txtbPesoIdeal.AcceptsTab = true;
            this.txtbPesoIdeal.Enabled = false;
            this.txtbPesoIdeal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbPesoIdeal.ForeColor = System.Drawing.Color.Red;
            this.txtbPesoIdeal.Location = new System.Drawing.Point(143, 258);
            this.txtbPesoIdeal.Name = "txtbPesoIdeal";
            this.txtbPesoIdeal.Size = new System.Drawing.Size(215, 22);
            this.txtbPesoIdeal.TabIndex = 9;
            this.txtbPesoIdeal.TextChanged += new System.EventHandler(this.txtbPesoIdeal_TextChanged);
            // 
            // MaskBxaltura
            // 
            this.MaskBxaltura.Location = new System.Drawing.Point(105, 92);
            this.MaskBxaltura.Mask = "9.99";
            this.MaskBxaltura.Name = "MaskBxaltura";
            this.MaskBxaltura.Size = new System.Drawing.Size(151, 20);
            this.MaskBxaltura.TabIndex = 10;
            this.MaskBxaltura.ValidatingType = typeof(System.DateTime);
            // 
            // maskBoxpeso
            // 
            this.maskBoxpeso.Location = new System.Drawing.Point(106, 132);
            this.maskBoxpeso.Mask = "999";
            this.maskBoxpeso.Name = "maskBoxpeso";
            this.maskBoxpeso.Size = new System.Drawing.Size(151, 20);
            this.maskBoxpeso.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.maskBoxpeso);
            this.Controls.Add(this.MaskBxaltura);
            this.Controls.Add(this.txtbPesoIdeal);
            this.Controls.Add(this.lblPesoIdeal);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.radBtonFeminino);
            this.Controls.Add(this.radBtonMasculino);
            this.Controls.Add(this.lablSexo);
            this.Controls.Add(this.lablPeso);
            this.Controls.Add(this.lablAltura);
            this.Name = "Form1";
            this.Text = "Peso";
      
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lablAltura;
        private System.Windows.Forms.Label lablPeso;
        private System.Windows.Forms.Label lablSexo;
        private System.Windows.Forms.RadioButton radBtonMasculino;
        private System.Windows.Forms.RadioButton radBtonFeminino;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Label lblPesoIdeal;
        private System.Windows.Forms.TextBox txtbPesoIdeal;
        private System.Windows.Forms.MaskedTextBox MaskBxaltura;
        private System.Windows.Forms.MaskedTextBox maskBoxpeso;
    }
}

