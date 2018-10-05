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
    public partial class FormLogin : MetroForm
    {
        public FormLogin()
        {
            InitializeComponent();

            txtSenha.PasswordChar = '●';

            //APAGAR DEPOIS
            this.txtUsuario.Text = "diuari";
            this.txtSenha.Text = "diu123";

        }

        private void btnLogar_Click(object sender, EventArgs e)
        {
            FuncionarioBLL bll = new FuncionarioBLL();
            try
            {
                bll.Autenticar(txtUsuario.Text, txtSenha.Text);
                FormMenu frm = new FormMenu();
                this.Hide();
                frm.ShowDialog();
                this.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (ckMostrarSenha.Checked)
            {
                txtSenha.PasswordChar = '\0';
            }
            else
            {
                txtSenha.PasswordChar = '●';
            }
            
        }


    }
}
