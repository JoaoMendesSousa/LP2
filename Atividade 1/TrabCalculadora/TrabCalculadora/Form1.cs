using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrabCalculadora
{
    

    public partial class Form1 : Form
    {
        double Num1, Num2, Resul;

        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void butmais_Click(object sender, EventArgs e)
        {
           
            if (double.TryParse(TextNum1.Text, out Num1) &&
                double.TryParse(TextNum2.Text, out Num2))
            {
                Resul = Num1 + Num2;
                TextResul.Text = Resul.ToString("N2");
            }
            else
                MessageBox.Show("Inserir numeros Validos");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            TextNum1.Text = "";
            TextNum2.Text = "";
            TextResul.Text= "";
        }

        private void butmenos_Click(object sender, EventArgs e)
        {
            if (double.TryParse(TextNum1.Text, out Num1) &&
                double.TryParse(TextNum2.Text, out Num2))
            {
                Resul = Num1 - Num2;
                TextResul.Text = Resul.ToString("N2");
            }
            else
                MessageBox.Show("Inserir numeros Validos");
        }

        private void butvezes_Click(object sender, EventArgs e)
        {
            if (double.TryParse(TextNum1.Text, out Num1) &&
                double.TryParse(TextNum2.Text, out Num2))
            {
                Resul = Num1 * Num2;
                TextResul.Text = Resul.ToString("N2");
            }
            else
                MessageBox.Show("Inserir numeros Validos");
        }

        private void butdivisao_Click(object sender, EventArgs e)
        {
            if (double.TryParse(TextNum1.Text, out Num1) &&
                double.TryParse(TextNum2.Text, out Num2))
                if (Num2 == 0)
                    MessageBox.Show("Impossivel dividir por zero");
                else
                {
                    Resul = Num1 / Num2;
                    TextResul.Text = Resul.ToString("N2");
                }
            else
                MessageBox.Show("Inserir numeros validos");
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void resul_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
