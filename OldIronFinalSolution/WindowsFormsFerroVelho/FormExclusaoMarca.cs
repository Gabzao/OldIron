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
    public partial class FormExclusaoMarca : MetroForm
    {
        MarcaBLL bll = new MarcaBLL();
        public FormExclusaoMarca()
        {
            InitializeComponent();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
           
            try
            {
                Marca m = new Marca();
                m.Nome = txtMarca.Text;
                m.ID = Convert.ToInt32(lblID.Text);
                bll.Deletar(m);
                MessageBox.Show("Marca Excluida com sucesso!");
                this.dataGridView1.DataSource = new MarcaBLL().LerTodos();
                FormHelpers.FormCleaner.ClearAllForm(this);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            

        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Marca marca = (Marca)this.dataGridView1.Rows[e.RowIndex].DataBoundItem;
            txtMarca.Text = marca.Nome;
            lblID.Text = Convert.ToString(marca.ID);

        }

        private void FormExclusaoMarca_Load(object sender, EventArgs e)
        {
            this.dataGridView1.DataSource = new MarcaBLL().LerTodos();

        }
    }
}
