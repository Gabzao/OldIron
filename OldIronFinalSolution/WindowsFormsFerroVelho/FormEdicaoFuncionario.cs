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
    public partial class FormEdicaoFuncionario : MetroForm
    {
        FuncionarioBLL bll = new FuncionarioBLL();
        public FormEdicaoFuncionario()
        {
            InitializeComponent();
            FormConfig.Inicializar(this);
            txtSenha.PasswordChar = '●';
            txtNovaSenha.PasswordChar = '●';


        }

        private void ckMostrarSenha_CheckedChanged(object sender, EventArgs e)
        {

            if (ckMostrarSenha.Checked)
            {
                txtSenha.PasswordChar = '\0';
                txtNovaSenha.PasswordChar = '\0';
            }
            else
            {
                txtSenha.PasswordChar = '●';
                txtNovaSenha.PasswordChar = '●';
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            Funcionario f = new Funcionario();
            f.ID = Convert.ToInt32(lblID.Text);
            f.Usuario = txtNovoUsuario.Text;
            f.Senha = txtNovaSenha.Text;
            string resposta = bll.Atualizar(f);
            MessageBox.Show(resposta);
            FormHelpers.FormCleaner.ClearAllForm(this);
            this.dataGridView1.DataSource = new FuncionarioBLL().LerTodos();

        }

        private void FormEdicaoFuncionario_Load(object sender, EventArgs e)
        {
            this.dataGridView1.DataSource = new FuncionarioBLL().LerTodos();

        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Funcionario funcionario = (Funcionario)this.dataGridView1.Rows[e.RowIndex].DataBoundItem;
            this.lblID.Text = Convert.ToString(funcionario.ID);
            this.txtUsuario.Text = funcionario.Usuario;
            this.txtSenha.Text = funcionario.Senha;
        }
    }
}
