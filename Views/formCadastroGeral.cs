using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProjetoGuardaChuva.UseCases;

namespace ProjetoGuardaChuva
{
    public partial class formCadastroGeral : Form
    {
        public formCadastroGeral()
        {
            InitializeComponent();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {
        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {
        }

        private void label13_Click(object sender, EventArgs e)
        {
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            VolumeDaMicrobacia volumeDaMicrobacia = new VolumeDaMicrobacia(double.Parse(txtAreaTelhado.Text), double.Parse(txtBaseTelhado.Text), double.Parse(txtInclinacao.Text));

            double valorTotal = volumeDaMicrobacia.CalculoVolumeDaMicrobacia();
            double valorEmLitros = volumeDaMicrobacia.ConverteParaLitros(valorTotal);
            lblResultadoCalculo.Text = ("O valor é: " + valorTotal.ToString() + "M³" + " E a litragem é: " + valorEmLitros + "L");

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
        }

        private void button5_Click(object sender, EventArgs e)
        {
        }
    }
}
