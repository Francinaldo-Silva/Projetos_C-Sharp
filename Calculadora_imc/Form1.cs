using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora_imc
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnVerificar_Click(object sender, EventArgs e)
        {
            double peso, altura, imc;
            peso = Convert.ToDouble(txtPeso.Text);
            altura = Convert.ToDouble(txtAltura.Text);
            imc = peso / (altura * altura);
            txtImc.Text = imc.ToString("0.00");
            if( imc < 18.49)
            
                MessageBox.Show("SITUAÇÃO: você está abaixo do peso", "Cálculo do IMC", MessageBoxButtons.OK, MessageBoxIcon.Exclamation );

            
            else if(imc < 24.99){
                MessageBox.Show("SITUAÇÃO: você está com peso detro da normalidade", "Cálculo do IMC", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

             }
            else if (imc < 29.99){
                MessageBox.Show("SITUAÇÃO: você está acima do peso", "Cálculo do IMC", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }
            else if (imc < 34.99){
                MessageBox.Show("ATENÇÃO: você está com obesidade grau 1", "Cálculo do IMC", MessageBoxButtons.OK, MessageBoxIcon.Stop);

            }
            else if (imc < 39.99){
                MessageBox.Show("ATENÇÃO: você está com obesidade grau 2", "Cálculo do IMC", MessageBoxButtons.OK, MessageBoxIcon.Stop);

            }
            else
            
                MessageBox.Show("ATENÇÃO! você está com grau de obesidade 3 (Vai morrer parcero)", "Cálculo de IMC", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            



        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtAltura.Text = " ";
            txtPeso.Text = " ";
            txtImc.Text = " ";

        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
