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
    public partial class FormExclusaoFuncionario : MetroForm
    {
        FuncionarioBLL bll = new FuncionarioBLL();
        public FormExclusaoFuncionario()
        {
            InitializeComponent();
            FormConfig.Inicializar(this);
            this.dataGridView1.DataSource = new FuncionarioBLL().LerTodos();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
           Funcionario funcionario = (Funcionario)this.dataGridView1.Rows[e.RowIndex].DataBoundItem;
           this.lblID.Text = Convert.ToString(funcionario.ID);
           this.txtNome.Text = funcionario.Nome;
        }

        private void btnDeletar_Click(object sender, EventArgs e)
        {
            Funcionario f = new Funcionario();
            f.ID = Convert.ToInt32(lblID.Text);
            f.Nome = txtNome.Text;
            string resposta = bll.Deletar(f);
            MessageBox.Show(resposta);
            FormHelpers.FormCleaner.ClearAllForm(this);
            this.dataGridView1.DataSource = new FuncionarioBLL().LerTodos();
        }
    }
}
