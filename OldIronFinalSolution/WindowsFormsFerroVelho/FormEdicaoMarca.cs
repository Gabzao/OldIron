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
    public partial class FormEdicaoMarca : MetroForm
    {
        MarcaBLL bll = new MarcaBLL();
        public FormEdicaoMarca()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Marca marca = (Marca)this.dataGridView1.Rows[e.RowIndex].DataBoundItem;
            txtOldName.Text = marca.Nome;
            lblID.Text = Convert.ToString(marca.ID);


        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            Marca m = new Marca();
            m.Nome = txtNewName.Text;
            m.ID = Convert.ToInt32(lblID.Text);
            try
            {
                bll.Editar(m);
                MessageBox.Show("Marca editada com sucesso!");
                FormHelpers.FormCleaner.ClearAllForm(this);
                this.dataGridView1.DataSource = new MarcaBLL().LerTodos();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void FormEdicaoMarca_Load(object sender, EventArgs e)
        {
            this.dataGridView1.DataSource = new MarcaBLL().LerTodos();

        }
    }
}
