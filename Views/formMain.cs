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
    public partial class formMain : Form
    {
        public formMain()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnCadastro_Click(object sender, EventArgs e)
        {
            formCadastroGeral formCadastroGeral = new formCadastroGeral();
            formCadastroGeral.ShowDialog();
        }

        private void btnAssociacao_Click(object sender, EventArgs e)
        {
            formAssociacao formAssociacao = new formAssociacao();
            formAssociacao.ShowDialog();
        }

        private void btnAbout_Click(object sender, EventArgs e)
        {
            formAbout formAbout = new formAbout();
            formAbout.ShowDialog();
        }
    }
}
