using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace at2PesoIdeal
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void radBtonMasculino_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void txtbAltura_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtbPesoIdeal_TextChanged(object sender, EventArgs e)
        {
            

        }

        private void radBtonFeminino_CheckedChanged(object sender, EventArgs e)
        {
           
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double altura, peso, pesoIdeal;

            if (maskBoxpeso.Text == "" && MaskBxaltura.Text == "" && (radBtonFeminino.Checked == false || radBtonMasculino.Checked == false ))
                MessageBox.Show("inserir todos os requisitos");
            else
            {
                altura = Convert.ToDouble(MaskBxaltura.Text);
                peso = Convert.ToDouble(maskBoxpeso.Text);


                if (radBtonMasculino.Checked == true)
                {
                    pesoIdeal = Math.Round((72.7 * altura) - 58);
                    txtbPesoIdeal.Text = Convert.ToString(pesoIdeal);
                }
                else 
                {
                    pesoIdeal = Math.Round((62.1 * altura) - 44.7);

                    txtbPesoIdeal.Text = Convert.ToString(pesoIdeal);
                }

                if (peso == pesoIdeal)
                    MessageBox.Show("Seu peso esta ideal");
                if (peso > pesoIdeal)
                    MessageBox.Show("você está acima do ideal,coma menos");
                if (peso < pesoIdeal)
                    MessageBox.Show("você está abaixo do ideal,coma mais");

                }

            }
        }

       
    
}
