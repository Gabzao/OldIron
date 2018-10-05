using BusinessLogicalLayer;
using Domain;
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
    public partial class FormCadastroFuncionario : MetroForm
    {
        FuncionarioBLL bll = new FuncionarioBLL();

        public FormCadastroFuncionario()
        {
            InitializeComponent();
            FormConfig.Inicializar(this);
            txtSenha.PasswordChar = '●';
            txtConfirmeSenha.PasswordChar = '●';
        }

        private void ckMostrarSenha_CheckedChanged(object sender, EventArgs e)
        {
            if (ckMostrarSenha.Checked)
            {
                txtSenha.PasswordChar = '\0';
                txtConfirmeSenha.PasswordChar = '\0';
            }
            else
            {
                txtSenha.PasswordChar = '●';
                txtConfirmeSenha.PasswordChar = '●';
            }
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            Funcionario f = new Funcionario();
            f.Nome = txtNome.Text;
            f.Usuario = txtUsuario.Text;
            f.Senha = txtSenha.Text;
            if (txtSenha.Text == txtConfirmeSenha.Text)
            {
                string resposta = bll.Inserir(f);
                MessageBox.Show(resposta);
                FormHelpers.FormCleaner.ClearAllForm(this);
            }
            else
            {
                MessageBox.Show("As senhas devem ser iguais.");
            }
        }
    }
}