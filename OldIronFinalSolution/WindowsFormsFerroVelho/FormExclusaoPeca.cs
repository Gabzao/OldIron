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
    public partial class FormExclusaoPeca : MetroForm

    {
        PecaBLL bll = new PecaBLL();
        public FormExclusaoPeca()
        {
            InitializeComponent();
            FormConfig.Inicializar(this);

        }

        private void btnDeletar_Click(object sender, EventArgs e)
        {
            Peca p = new Peca();
            p.Modelo.Nome = txtModelo.Text;
            p.Ano = Convert.ToInt32(txtAno.Text);
            p.ID = Convert.ToInt32(lblID.Text);

            string resposta = bll.Deletar(p);
            MessageBox.Show(resposta);
            FormHelpers.FormCleaner.ClearAllForm(this);
            this.dataGridView1.DataSource = new PecaBLL().LerTodos();

        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Peca peca = (Peca)this.dataGridView1.Rows[e.RowIndex].DataBoundItem;
            txtAno.Text = Convert.ToString(peca.Ano);
            txtModelo.Text = peca.Modelo.Nome;
            lblID.Text = Convert.ToString(peca.ID);
        }

        private void FormExclusaoPeca_Load(object sender, EventArgs e)
        {
            this.dataGridView1.DataSource = new PecaBLL().LerTodos();

        }
    }
}
