using BusinessLogicalLayer;
using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsFerroVelho
{
    public partial class FormMenu : MetroForm
    {
        public FormMenu()
        {
            InitializeComponent();
            FormConfig.Inicializar(this);

        }

        private void cadastrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormCadastroFuncionario frm = new FormCadastroFuncionario();
            this.Hide();
            frm.ShowDialog();
            this.Show();
        }

        private void FormMenu_Load(object sender, EventArgs e)
        {
            lblBemVindo.Text = "Bem-vindo " + Parametros.FuncionarioLogado.Nome + "!";

        }

        private void cadastrarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FormCadastroPeca frm = new FormCadastroPeca();
            this.Hide();
            frm.ShowDialog();
            this.Show();
        }

        private void atualizarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FormEdicaoPeca frm = new FormEdicaoPeca();
            this.Hide();
            frm.ShowDialog();
            this.Show();
        }

        private void deletarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormExclusaoPeca frm = new FormExclusaoPeca();
            this.Hide();
            frm.ShowDialog();
            this.Show();
        }

        private void atualizarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormEdicaoFuncionario frm = new FormEdicaoFuncionario();
            this.Hide();
            frm.ShowDialog();
            this.Show();
        }

        private void excluirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormExclusaoFuncionario frm = new FormExclusaoFuncionario();
            this.Hide();
            frm.ShowDialog();
            this.Show();
        }

        private void cadastrarToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            FormCadastroTag frm = new FormCadastroTag();
            this.Hide();
            frm.ShowDialog();
            this.Show();
        }

        private void atualizarToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            FormEdicaoTag frm = new FormEdicaoTag();
            this.Hide();
            frm.ShowDialog();
            this.Show();
        }

        private void pesquisarPorTagToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormPesquisaTag frm = new FormPesquisaTag();
            this.Hide();
            frm.ShowDialog();
            this.Show();
        }

        private void cadastroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormCadastroMarca frm = new FormCadastroMarca();
            this.Hide();
            frm.ShowDialog();
            this.Show();
        }

        private void editarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormEdicaoMarca frm = new FormEdicaoMarca();
            this.Hide();
            frm.ShowDialog();
            this.Show();
        }

        private void deletarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FormExclusaoMarca frm = new FormExclusaoMarca();
            this.Hide();
            frm.ShowDialog();
            this.Show();
        }

        private void cadastrarToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            FormCadastroModelo frm = new FormCadastroModelo();
            this.Hide();
            frm.ShowDialog();
            this.Show();
        }

        private void editarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FormEdicaoModelo frm = new FormEdicaoModelo();
            this.Hide();
            frm.ShowDialog();
            this.Show();
        }

        private void deletarToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            FormExclusaoModelo frm = new FormExclusaoModelo();
            this.Hide();
            frm.ShowDialog();
            this.Show();
        }


    }
}
