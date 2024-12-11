using System;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class FrmCalculadora : Form
    {
        public FrmCalculadora()
        {
            InitializeComponent();
        }

        double num1, num2;

        //Criação de um objeto da classe Metodos:
        Metodos objCalcular = new Metodos();
        private void btnSomar_Click(object sender, EventArgs e)
        {
            double.TryParse(txtNum1.Text, out num1);
            double.TryParse(txtNum2.Text, out num2);

            lblResult.Text = objCalcular.Somar(num1, num2).ToString();
        }

        private void btnSubtrair_Click(object sender, EventArgs e)
        {
            double.TryParse(txtNum1.Text, out num1);
            double.TryParse(txtNum2.Text, out num2);

            lblResult.Text = objCalcular.Subtrair(num1, num2).ToString();
        }

        private void btnMultiplicar_Click(object sender, EventArgs e)
        {
            double.TryParse(txtNum1.Text, out num1);
            double.TryParse(txtNum2.Text, out num2);

            lblResult.Text = objCalcular.Multiplicar(num1, num2).ToString();
        }

        private void btnDividir_Click(object sender, EventArgs e)
        {
            double.TryParse(txtNum1.Text, out num1);
            double.TryParse(txtNum2.Text, out num2);

            if (num2 != 0)
            {
                lblResult.Text = objCalcular.Dividir(num1, num2).ToString();
            }
            else
            {
                Limpar();
                MessageBox.Show("Não existe divisão por zero.");
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            Limpar();
        }
        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Limpar()
        {
            txtNum1.Clear();
            txtNum2.Clear();
            lblResult.Text = "0";
            txtNum1.Focus();
        }

    }
}
