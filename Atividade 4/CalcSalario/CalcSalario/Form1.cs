using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalcSalario
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void maskedTextBox3_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void maskedTextBox4_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void maskedTextBox2_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Double SalarioBruto, SalarioLiquido, INSS, INSSliquota, IRRF, IRRFliquota, salarioFamilia;
            INSSliquota = 0;
            IRRFliquota = 0;
            salarioFamilia = 0;

            if (Double.TryParse(maskTxtsalarioBruto.Text, out SalarioBruto) && (!(txtBNome.Text == String.Empty))
                && ((cBoxestadoCivil.Text == "Solteiro" || cBoxestadoCivil.Text == "Casado"))
                && ((Convert.ToInt32(cmbBxnFilhos.Text) >= 0)) && (((cmbBxsexo.Text == "Masculino") || (cmbBxsexo.Text == "Feminino"))))
            {
                SalarioBruto = Convert.ToDouble(maskTxtsalarioBruto.Text);

                //Liquota do INSS
                if (SalarioBruto <= 800.47)
                {
                    INSSliquota = 0.0765;
                    maskTxtaliquotaInss.Text = "07,65";
                }
                else if (SalarioBruto <= 1050.00)
                {
                    INSSliquota = 0.0865;
                    maskTxtaliquotaInss.Text = "08,65";
                }
                else if (SalarioBruto <= 1400.77)
                {
                    INSSliquota = 0.09;
                    maskTxtaliquotaInss.Text = "09,00";
                }
                else if (SalarioBruto <= 2801.56)
                {
                    INSSliquota = 0.11;
                    maskTxtaliquotaInss.Text = "11,00";
                }
                else
                    maskTxtaliquotaInss.Text = "";

                //Liquota do IRRF
                if (SalarioBruto <= 1257.12)
                {
                    IRRFliquota = 0;
                    maskTxtbxAliquotairrf.Text = "0";
                }
                else if (SalarioBruto <= 2512.08)
                {
                    IRRFliquota = 0.15;
                    maskTxtbxAliquotairrf.Text = "15,00";

                }
                else
                {
                    IRRFliquota = 0.2750;
                    maskTxtbxAliquotairrf.Text = "27,50";
                }

                //Salario Familia
                if (Convert.ToInt32(cmbBxnFilhos.Text) > 0)
                    if (SalarioBruto < 435.52)
                    {
                        salarioFamilia = (Convert.ToDouble(cmbBxnFilhos.Text) * 22.33);
                        maskTxtsalarioFamilia.Text = (Convert.ToString(salarioFamilia));
                    }
                    else if (SalarioBruto < 654.61)
                    {
                        salarioFamilia = (Convert.ToDouble(cmbBxnFilhos.Text) * 15.71);
                        maskTxtsalarioFamilia.Text = Convert.ToString(salarioFamilia);
                    }
                // Desconto INSS
                if (SalarioBruto < 2801.56)
                    INSS = SalarioBruto * INSSliquota;
                else
                    INSS = SalarioBruto - 308.17;

                maskTxtDescontoINSS.Text = Convert.ToString(INSS);

                // Desconto IRRF
                IRRF = SalarioBruto * IRRFliquota;
                maskTxtdescontoIrrf.Text= Convert.ToString(IRRF);

                //salario liquido
                SalarioLiquido = SalarioBruto - INSS - IRRF + salarioFamilia;
                masktxtSalarioLiquido.Text= Convert.ToString(SalarioLiquido);

                if (cmbBxsexo.Text == "Masculino")
                    txtBoxinformação.Text = "Os descontos do salario do Sr. " + txtBNome.Text + " que e" + cBoxestadoCivil.Text + " e tem " + cmbBxnFilhos.Text + " filhos, sao:";
                else
                    txtBoxinformação.Text = "Os descontos do salario do Sra. " + txtBNome.Text + " que e" + cBoxestadoCivil.Text + " e tem " + cmbBxnFilhos.Text + "filhos sao:";

               
            }
            else
                MessageBox.Show("Preencher todos os requisitos");


            
        }
}   }
