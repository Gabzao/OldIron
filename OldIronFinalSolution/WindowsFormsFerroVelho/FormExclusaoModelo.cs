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
    public partial class FormExclusaoModelo : MetroForm
    {
        ModeloBLL bll = new ModeloBLL();
        public FormExclusaoModelo()
        {
            InitializeComponent();
        }

        private void FormExclusaoModelo_Load(object sender, EventArgs e)
        {
            cmbMarca.ValueMember = "ID";
            cmbMarca.DisplayMember = "Nome";
            cmbMarca.DataSource = new MarcaBLL().LerTodos();
            this.dataGridView1.DataSource = new ModeloBLL().LerTodos();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Modelo modelo = (Modelo)this.dataGridView1.Rows[e.RowIndex].DataBoundItem;
            txtNome.Text = modelo.Nome;
            cmbMarca.SelectedValue = modelo.IDMarca;
            lblID.Text = Convert.ToString(modelo.ID);
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            Modelo m = new Modelo();
            m.ID = Convert.ToInt32(lblID.Text);
            m.IDMarca = (int)cmbMarca.SelectedValue;
            try
            {
                bll.Deletar(m);
                MessageBox.Show("Modelo deletado com sucesso!");
                FormHelpers.FormCleaner.ClearAllForm(this);
                this.dataGridView1.DataSource = new ModeloBLL().LerTodos();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}
