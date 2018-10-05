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
    public partial class FormCadastroPeca : MetroForm
    {
        PecaBLL bll = new PecaBLL();
        public FormCadastroPeca()
        {
            InitializeComponent();
            FormConfig.Inicializar(this);
            
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            Peca p = new Peca();
            p.Ano = Convert.ToInt32(txtAno.Text);
            p.Descricao = txtDescricao.Text;
            p.Estoque = Convert.ToInt32(txtEstoque.Text);
            p.Marca.ID = (int)cmbMarca.SelectedValue;
            p.Modelo.ID = Convert.ToInt32(cmbModelo.SelectedValue);
            p.Preco = Convert.ToDouble(txtPreco.Text);

            for (int i = 0; i < listBox1.Items.Count; i++)
            {
                ImagemPeca imagem = new ImagemPeca();
                imagem.Imagem = ImageHelper.GetPhoto(listBox1.Items[i].ToString());
                p.AddImagem(imagem);
            }
            try
            {
                bll.Inserir(p);
                listBox1.ClearSelected();
                MessageBox.Show("Cadastrado com sucesso!");
                FormHelpers.FormCleaner.ClearAllForm(this);

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            DialogResult result = ofd.ShowDialog();
            if (result != System.Windows.Forms.DialogResult.OK)
            {
                return;
            }
            this.listBox1.Items.Add(ofd.FileName);
        }

        private void FormCadastroPeca_Load(object sender, EventArgs e)
        {
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
