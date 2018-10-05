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
    public partial class FormCadastroMarca : MetroForm
    {
        MarcaBLL bll = new MarcaBLL();
        public FormCadastroMarca()
        {
            InitializeComponent();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            Marca m = new Marca();
            m.Nome = txtNomeMarca.Text;
            try
            {
                bll.Inserir(m);
                MessageBox.Show("Marca cadastrada com sucesso!");
                FormHelpers.FormCleaner.ClearAllForm(this);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }




    }  
}       