namespace WindowsFormsFerroVelho
{
    partial class FormEdicaoPeca
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txtAno = new MetroFramework.Controls.MetroTextBox();
            this.txtPreco = new MetroFramework.Controls.MetroTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtEstoque = new MetroFramework.Controls.MetroTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDescricao = new MetroFramework.Controls.MetroTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnEditar = new MetroFramework.Controls.MetroButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lblID = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbMarca = new MetroFramework.Controls.MetroComboBox();
            this.cmbModelo = new MetroFramework.Controls.MetroComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtAno
            // 
            this.txtAno.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.txtAno.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtAno.Lines = new string[0];
            this.txtAno.Location = new System.Drawing.Point(55, 227);
            this.txtAno.MaxLength = 32767;
            this.txtAno.Name = "txtAno";
            this.txtAno.PasswordChar = '\0';
            this.txtAno.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtAno.SelectedText = "";
            this.txtAno.Size = new System.Drawing.Size(240, 29);
            this.txtAno.Style = MetroFramework.MetroColorStyle.Teal;
            this.txtAno.TabIndex = 2;
            this.txtAno.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtAno.UseSelectable = true;
            this.txtAno.UseStyleColors = true;
            // 
            // txtPreco
            // 
            this.txtPreco.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.txtPreco.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtPreco.Lines = new string[0];
            this.txtPreco.Location = new System.Drawing.Point(55, 352);
            this.txtPreco.MaxLength = 32767;
            this.txtPreco.Name = "txtPreco";
            this.txtPreco.PasswordChar = '\0';
            this.txtPreco.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtPreco.SelectedText = "";
            this.txtPreco.Size = new System.Drawing.Size(240, 29);
            this.txtPreco.Style = MetroFramework.MetroColorStyle.Teal;
            this.txtPreco.TabIndex = 4;
            this.txtPreco.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtPreco.UseSelectable = true;
            this.txtPreco.UseStyleColors = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Teal;
            this.label5.Location = new System.Drawing.Point(51, 329);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 20);
            this.label5.TabIndex = 78;
            this.label5.Text = "Preço:";
            // 
            // txtEstoque
            // 
            this.txtEstoque.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.txtEstoque.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtEstoque.Lines = new string[0];
            this.txtEstoque.Location = new System.Drawing.Point(55, 413);
            this.txtEstoque.MaxLength = 32767;
            this.txtEstoque.Name = "txtEstoque";
            this.txtEstoque.PasswordChar = '\0';
            this.txtEstoque.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtEstoque.SelectedText = "";
            this.txtEstoque.Size = new System.Drawing.Size(240, 29);
            this.txtEstoque.Style = MetroFramework.MetroColorStyle.Teal;
            this.txtEstoque.TabIndex = 5;
            this.txtEstoque.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtEstoque.UseSelectable = true;
            this.txtEstoque.UseStyleColors = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Teal;
            this.label4.Location = new System.Drawing.Point(51, 390);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 20);
            this.label4.TabIndex = 76;
            this.label4.Text = "Estoque:";
            // 
            // txtDescricao
            // 
            this.txtDescricao.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.txtDescricao.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtDescricao.Lines = new string[0];
            this.txtDescricao.Location = new System.Drawing.Point(55, 291);
            this.txtDescricao.MaxLength = 32767;
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.PasswordChar = '\0';
            this.txtDescricao.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtDescricao.SelectedText = "";
            this.txtDescricao.Size = new System.Drawing.Size(240, 29);
            this.txtDescricao.Style = MetroFramework.MetroColorStyle.Teal;
            this.txtDescricao.TabIndex = 3;
            this.txtDescricao.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtDescricao.UseSelectable = true;
            this.txtDescricao.UseStyleColors = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Teal;
            this.label3.Location = new System.Drawing.Point(51, 268);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 20);
            this.label3.TabIndex = 74;
            this.label3.Text = "Descrição";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Teal;
            this.label2.Location = new System.Drawing.Point(50, 139);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 20);
            this.label2.TabIndex = 73;
            this.label2.Text = "Modelo:";
            // 
            // btnEditar
            // 
            this.btnEditar.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btnEditar.Highlight = true;
            this.btnEditar.Location = new System.Drawing.Point(83, 457);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(155, 48);
            this.btnEditar.Style = MetroFramework.MetroColorStyle.Teal;
            this.btnEditar.TabIndex = 6;
            this.btnEditar.Text = "EDITAR";
            this.btnEditar.Theme = MetroFramework.MetroThemeStyle.Light;
            this.btnEditar.UseSelectable = true;
            this.btnEditar.UseStyleColors = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Teal;
            this.label1.Location = new System.Drawing.Point(50, 204);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 20);
            this.label1.TabIndex = 69;
            this.label1.Text = "Ano:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Teal;
            this.label9.Location = new System.Drawing.Point(52, 77);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(57, 20);
            this.label9.TabIndex = 68;
            this.label9.Text = "Marca:";
            // 
            // dataGridView1
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.Location = new System.Drawing.Point(322, 100);
            this.dataGridView1.Name = "dataGridView1";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.Size = new System.Drawing.Size(519, 342);
            this.dataGridView1.TabIndex = 81;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblID.ForeColor = System.Drawing.Color.Teal;
            this.lblID.Location = new System.Drawing.Point(23, 60);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(26, 20);
            this.lblID.TabIndex = 82;
            this.lblID.Text = "ID";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Teal;
            this.label6.Location = new System.Drawing.Point(318, 77);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(149, 20);
            this.label6.TabIndex = 83;
            this.label6.Text = "Peças cadastradas:";
            // 
            // cmbMarca
            // 
            this.cmbMarca.BackColor = System.Drawing.Color.White;
            this.cmbMarca.ForeColor = System.Drawing.Color.Transparent;
            this.cmbMarca.FormattingEnabled = true;
            this.cmbMarca.ItemHeight = 23;
            this.cmbMarca.Location = new System.Drawing.Point(55, 100);
            this.cmbMarca.Name = "cmbMarca";
            this.cmbMarca.Size = new System.Drawing.Size(239, 29);
            this.cmbMarca.Style = MetroFramework.MetroColorStyle.Teal;
            this.cmbMarca.TabIndex = 84;
            this.cmbMarca.UseSelectable = true;
            this.cmbMarca.SelectedIndexChanged += new System.EventHandler(this.cmbMarca_SelectedIndexChanged);
            // 
            // cmbModelo
            // 
            this.cmbModelo.BackColor = System.Drawing.Color.White;
            this.cmbModelo.ForeColor = System.Drawing.Color.Transparent;
            this.cmbModelo.FormattingEnabled = true;
            this.cmbModelo.ItemHeight = 23;
            this.cmbModelo.Location = new System.Drawing.Point(56, 162);
            this.cmbModelo.Name = "cmbModelo";
            this.cmbModelo.Size = new System.Drawing.Size(239, 29);
            this.cmbModelo.Style = MetroFramework.MetroColorStyle.Teal;
            this.cmbModelo.TabIndex = 85;
            this.cmbModelo.UseSelectable = true;
            // 
            // FormEdicaoPeca
            // 
            this.AcceptButton = this.btnEditar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(864, 512);
            this.Controls.Add(this.cmbModelo);
            this.Controls.Add(this.cmbMarca);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtAno);
            this.Controls.Add(this.txtPreco);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtEstoque);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtDescricao);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label9);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "FormEdicaoPeca";
            this.Style = MetroFramework.MetroColorStyle.Teal;
            this.Text = "Edição de Peças";
            this.Load += new System.EventHandler(this.FormEdicaoPeca_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroTextBox txtAno;
        private MetroFramework.Controls.MetroTextBox txtPreco;
        private System.Windows.Forms.Label label5;
        private MetroFramework.Controls.MetroTextBox txtEstoque;
        private System.Windows.Forms.Label label4;
        private MetroFramework.Controls.MetroTextBox txtDescricao;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private MetroFramework.Controls.MetroButton btnEditar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Label label6;
        private MetroFramework.Controls.MetroComboBox cmbMarca;
        private MetroFramework.Controls.MetroComboBox cmbModelo;
    }
}