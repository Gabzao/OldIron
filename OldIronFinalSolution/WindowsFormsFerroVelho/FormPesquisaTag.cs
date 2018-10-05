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
    public partial class FormPesquisaTag : MetroForm
    {
        TagBLL bll = new TagBLL();  
        public FormPesquisaTag()
        {
            InitializeComponent();
        }


        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            string tag = txtTag.Text;
            List<Peca> listaRetorno = null;
            if(checkBox1.Checked)
            {
                var tags = tag.Split(' ').ToList();
                listaRetorno = bll.LerPecasInterseccaoTags(tags);
            }
            else
            {
                listaRetorno = bll.LerPecasComATag(tag);
            }
            this.dataGridView1.DataSource = listaRetorno;
        }
    }
}
