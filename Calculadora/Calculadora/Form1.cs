using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Metodos calcular = new Metodos();

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            double n1 = double.Parse(textBox1.Text);
            double n2 = double.Parse(textBox2.Text);
            double n3 = double.Parse(textBox3.Text);
            double n4 = double.Parse(textBox4.Text);
            double n5 = double.Parse(textBox5.Text);

            double cal = calcular.Min(n1, n2, n3, n4, n5);

            txtResul.Text = cal.ToString();
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double n1 = double.Parse(textBox1.Text);
            double n2 = double.Parse(textBox2.Text);
            double n3 = double.Parse(textBox3.Text);
            double n4 = double.Parse(textBox4.Text);
            double n5 = double.Parse(textBox5.Text);

            double cal = calcular.Soma(n1, n2, n3, n4, n5);

            txtResul.Text = cal.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double n1 = double.Parse(textBox1.Text);
            double n2 = double.Parse(textBox2.Text);
            double n3 = double.Parse(textBox3.Text);
            double n4 = double.Parse(textBox4.Text);
            double n5 = double.Parse(textBox5.Text);

            double cal = calcular.Med(n1, n2, n3, n4, n5);

            txtResul.Text = cal.ToString();
        }

        private void btnMax_Click(object sender, EventArgs e)
        {
            double n1 = double.Parse(textBox1.Text);
            double n2 = double.Parse(textBox2.Text);
            double n3 = double.Parse(textBox3.Text);
            double n4 = double.Parse(textBox4.Text);
            double n5 = double.Parse(textBox5.Text);

            double cal = calcular.Max(n1, n2, n3, n4, n5);

            txtResul.Text = cal.ToString();
        }

        private void btnElev_Click(object sender, EventArgs e)
        {
            double n1 = double.Parse(textBox2.Text);
            double n2 = double.Parse(textBox3.Text);

            double cal = calcular.Elev(n1, n2);

            txtResul.Text = cal.ToString();
        }
    }
}
