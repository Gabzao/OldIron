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
    public partial class FormEdicaoTag : MetroForm
    {
        TagBLL bll = new TagBLL();
        public FormEdicaoTag()
        {
            InitializeComponent();
            FormConfig.Inicializar(this);

        }

        private void FormEdicaoTag_Load(object sender, EventArgs e)
        {
            this.dataGridView1.DataSource = new PecaBLL().LerTodos();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txtTag.Clear();
            Peca peca = (Peca)this.dataGridView1.Rows[e.RowIndex].DataBoundItem;
            txtID_Peca.Text = Convert.ToString(peca.ID);
            List<string> lista = bll.LerTodasTags(peca.ID);

            for (int i = 0; i < lista.Count; i++)
            {
                if (lista.Count - 1 == i)
                {
                    txtTag.Text += lista[i];
                }
                else
	            {
                    txtTag.Text += lista[i] + "\r\n";
	            }
            }
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            try
            {
                CadastroTag t = new CadastroTag();
                t.ID_Peca = Convert.ToInt32(txtID_Peca.Text);
                t.Tags = txtTag.Text.Split('\n').ToList();
                bll.Editar(t);
                MessageBox.Show("Cadastrado com sucesso!");
                FormHelpers.FormCleaner.ClearAllForm(this);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
