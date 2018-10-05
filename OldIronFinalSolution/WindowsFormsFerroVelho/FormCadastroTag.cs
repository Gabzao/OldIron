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
    public partial class FormCadastroTag : MetroForm
    {
        TagBLL bll = new TagBLL();
        public FormCadastroTag()
        {
            InitializeComponent();
            FormConfig.Inicializar(this);

        }
        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            CadastroTag t = new CadastroTag();

            int temp;
            int.TryParse(txtID_Peca.Text, out temp);
            t.ID_Peca = temp;
            t.Tags =  txtTag.Text.Split('\n').ToList();
            try
            {
                bll.Inserir(t);
                MessageBox.Show("TAGS cadastradas com sucesso!");
                FormHelpers.FormCleaner.ClearAllForm(this);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txtTag.Clear();
            Peca peca = (Peca)this.dataGridView1.Rows[e.RowIndex].DataBoundItem;
            txtID_Peca.Text = Convert.ToString(peca.ID);

            String[] sugestao = peca.Descricao.Split(' ');

            List<string> tags = sugestao.ToList();
            bll.TirarPreposicao(tags);


            for (int i = 0; i < tags.Count; i++)
            {
                if (tags.Count - 1 == i)
                {
                    txtTag.Text += "#" + tags[i];
                }
                else
                {
                    txtTag.Text += "#" + tags[i] + "\r\n";
                }
            }
        }

        private void FormCadastroTag_Load(object sender, EventArgs e)
        {
            this.dataGridView1.DataSource = new PecaBLL().LerTodos();
        }
    }
}
