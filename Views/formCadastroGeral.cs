using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.EntityFrameworkCore.Infrastructure;
using ProjetoGuardaChuva.Models;
using ProjetoGuardaChuva.Repository.Interface;
using ProjetoGuardaChuva.UseCases;

namespace ProjetoGuardaChuva
{
    public partial class formCadastroGeral : Form
    {
        private readonly ISetorRepository setorRepository;
        public formCadastroGeral()
        {
            InitializeComponent();
            CarregarDadosCadastroGeral();
        }

        private void CarregarDadosCadastroGeral()
        {
            cmbIDArea.Enabled = true;
            txtNomeArea.Enabled = false;
            btnGravar.Enabled = false;
            btnCancelar.Enabled = false;
            btnInserir.Enabled = true;

            //

            cmbIdDomicilio.Enabled = true;
            txtNumeroContrato.Enabled = false;
            cmbSetor.Enabled = false;
            txtCEP.Enabled = false;
            txtEstado.Enabled = false;
            txtCidade.Enabled = false;
            txtBairro.Enabled = false;
            txtRua.Enabled = false;
            txtInclinacao.Enabled = false;
            txtNumeroContrato.Enabled = false;
            txtBaseTelhado.Enabled = false;
            txtAreaTelhado.Enabled = false;
            btnCalcular.Enabled = false;
            txtCoordenadas.Enabled = false;
            lblResultadoCalculo.Enabled = false;
            btnInserirDomicilio.Enabled = true;
            btnGravarDomicilio.Enabled = false;
            btnCancelarDomicilio.Enabled = false;

            //


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

        private void btnInserirDomicilio_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
        }

        private void button5_Click(object sender, EventArgs e)
        {
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            cmbIDArea.Enabled = true;
            txtNomeArea.Enabled = true;
            btnGravar.Enabled = true;
            btnCancelar.Enabled = true;
            btnInserir.Enabled = false;
        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            Setor setor = new Setor(txtNomeArea.Text);
            setorRepository.Add(setor.ApelidoSetor);

        }
    }
}
