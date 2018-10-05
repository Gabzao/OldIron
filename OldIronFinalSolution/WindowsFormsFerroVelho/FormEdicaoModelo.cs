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
    public partial class FormEdicaoModelo : MetroForm
    {
        ModeloBLL bll = new ModeloBLL();
        public FormEdicaoModelo()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Modelo modelo = (Modelo)this.dataGridView1.Rows[e.RowIndex].DataBoundItem;
            txtNome.Text = modelo.Nome;
            cmbNovaMarca.SelectedValue = modelo.IDMarca;
            lblID.Text =Convert.ToString(modelo.ID);
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            Modelo m = new Modelo();
            m.IDMarca = (int)cmbNovaMarca.SelectedValue;
            m.Nome = txtNovoNome.Text;
            m.ID = Convert.ToInt32(lblID.Text);
                
            
            try
            {
                bll.Atualizar(m);
                MessageBox.Show("Modelo editado com sucesso!");
                FormHelpers.FormCleaner.ClearAllForm(this);
                this.dataGridView1.DataSource = new ModeloBLL().LerTodos();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void FormEdicaoModelo_Load(object sender, EventArgs e)
        {
            cmbNovaMarca.ValueMember = "ID";
            cmbNovaMarca.DisplayMember = "Nome";
            cmbNovaMarca.DataSource = new MarcaBLL().LerTodos();
            this.dataGridView1.DataSource = new ModeloBLL().LerTodos();
        }
    }
}
