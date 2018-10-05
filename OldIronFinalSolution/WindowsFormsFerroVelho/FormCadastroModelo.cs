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
    public partial class FormCadastroModelo : MetroForm
    {
        ModeloBLL bll = new ModeloBLL();
        public FormCadastroModelo()
        {
            InitializeComponent();

           
        }

       

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
                Modelo m = new Modelo();
                m.Nome = txtNome.Text;
                m.IDMarca = (int)cmbMarca.SelectedValue;
                 try
             {
                bll.Inserir(m);
                MessageBox.Show("Modelo cadastrado com sucesso!");
                FormHelpers.FormCleaner.ClearAllForm(this);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
           

        }

        private void FormCadastroModelo_Load(object sender, EventArgs e)
        {
            cmbMarca.ValueMember = "ID";
            cmbMarca.DisplayMember = "Nome";
            cmbMarca.DataSource = new MarcaBLL().LerTodos();
        }
    }
}
