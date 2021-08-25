using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OneApp
{
    public partial class Form1 : Form
    {
        //declarando variáveis globalmente
        float v1, v2, somar, subtrair, dividir, multiplicar;

        //Inicializando o componente
        public Form1()
        {
            InitializeComponent();
        }

        private void resultado_TextChanged(object sender, EventArgs e)
        {

        }

        //bloco de Divisão
        private void btnDividir_Click(object sender, EventArgs e)
        {
            float.TryParse(txtValor1.Text, out v1);
            float.TryParse(txtValor2.Text, out v2);
            dividir = v1 / v2;
            resultado.Text = dividir.ToString();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        //bloco de Subtração
        private void btnSubtrair_Click(object sender, EventArgs e)
        {
            float.TryParse(txtValor1.Text, out v1);
            float.TryParse(txtValor2.Text, out v2);
            subtrair = v1 - v2;
            resultado.Text = subtrair.ToString();
        }

        //bloco de Multiplicação
        private void btnMultiplicar_Click(object sender, EventArgs e)
        {
            float.TryParse(txtValor1.Text, out v1);
            float.TryParse(txtValor2.Text, out v2);
            multiplicar = v1 * v2;
            resultado.Text = multiplicar.ToString();
        }

        //bloco de Soma
        private void btnSomar_Click(object sender, EventArgs e)
        {

            float.TryParse(txtValor1.Text, out v1);
            float.TryParse(txtValor2.Text, out v2);
            somar = v1 + v2;
            resultado.Text = somar.ToString();

        }

        //Limpar
        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtValor1.Clear();
            txtValor2.Clear();
            resultado.Clear();
            txtValor1.Focus();
        }

        private void txtValor1_TextChanged(object sender, EventArgs e)
        {

        }

    }
}
