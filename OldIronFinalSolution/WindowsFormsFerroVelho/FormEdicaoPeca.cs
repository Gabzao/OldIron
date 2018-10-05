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
    public partial class FormEdicaoPeca : MetroForm
    {
        PecaBLL bll = new PecaBLL();
        public FormEdicaoPeca()
        {
            InitializeComponent();
            FormConfig.Inicializar(this);

        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Peca peca = (Peca)this.dataGridView1.Rows[e.RowIndex].DataBoundItem;
            txtAno.Text = Convert.ToString(peca.Ano);
            txtDescricao.Text = peca.Descricao;
            txtEstoque.Text = Convert.ToString(peca.Estoque);

            for (int i = 0; i < cmbMarca.Items.Count; i++)
            {
                if(cmbMarca.Items[i].ToString() == peca.Marca.Nome)
                {
                    cmbMarca.SelectedIndex = i;
                    break;
                }
            }

            for (int i = 0; i < cmbModelo.Items.Count; i++)
            {
                if (cmbModelo.Items[i].ToString() == peca.Modelo.Nome)
                {
                    cmbModelo.SelectedIndex = i;
                    break;
                }
            }
            
            txtPreco.Text = Convert.ToString(peca.Preco);
            lblID.Text = Convert.ToString(peca.ID);
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            Peca p = new Peca();
            p.Ano = Convert.ToInt32(txtAno.Text);
            p.Descricao = txtDescricao.Text;
            p.Estoque = Convert.ToInt32(txtEstoque.Text);
            p.Marca.ID = (int)cmbMarca.SelectedValue;
            p.Modelo.ID= Convert.ToInt32(cmbModelo.SelectedValue);
            p.Preco = Convert.ToDouble(txtPreco.Text);
            p.ID = Convert.ToInt32(lblID.Text);
            string resposta = bll.Atualizar(p);
            MessageBox.Show(resposta);
            FormHelpers.FormCleaner.ClearAllForm(this);
            this.dataGridView1.DataSource = new PecaBLL().LerTodos();
        }

        private void FormEdicaoPeca_Load(object sender, EventArgs e)
        {
            this.dataGridView1.DataSource = new PecaBLL().LerTodos();
            cmbMarca.ValueMember = "ID";
            cmbMarca.DisplayMember = "Nome";
            cmbMarca.DataSource = new MarcaBLL().LerTodos();
        }

        private void cmbMarca_SelectedIndexChanged(object sender, EventArgs e)
        {
                    List<Modelo> modelosDaMarca = new ModeloBLL().LerTodosModelosDaMarca((int)cmbMarca.SelectedValue);
            cmbModelo.DataSource = null;
            cmbModelo.DataSource = modelosDaMarca;
            cmbModelo.ValueMember = "ID";
            cmbModelo.DisplayMember = "Nome";
        }


    }
}
