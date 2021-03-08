using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Classificador_de_triangulo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void maskedTextBox3_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
               

        }

        private void BtnIdentificar_Click(object sender, EventArgs e)
        {
            double A, B, C;

            if (double.TryParse(txtBa.Text, out A) && (double.TryParse(txtBb.Text, out B)
                && (double.TryParse(txtBc.Text, out C))))
            {
                A = Convert.ToDouble(txtBa.Text);
                B = Convert.ToDouble(txtBb.Text);
                C = Convert.ToDouble(txtBc.Text);

                if (((B - C < A) && (A < B + C)) && ((A - C < A) && (A < A + C)) && ((A - B < C) && (C < A + B)))
                {
                    if ((A == B) && (B == C))
                        txtBtriangulo.Text = ("Equilatero");
                    else
                     if ((A == B) || (A == C))
                        txtBtriangulo.Text = ("Isoceles");

                    else
                        txtBtriangulo.Text = ("escaleno");

                }
                else
                    MessageBox.Show("Essas medias não formam um triangulo");


            }
            else
                MessageBox.Show("inserir dados validos");
        }
    }
}
