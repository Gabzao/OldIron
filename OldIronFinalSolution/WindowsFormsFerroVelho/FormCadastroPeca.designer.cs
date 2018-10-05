namespace WindowsFormsFerroVelho
{
    partial class FormCadastroPeca
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
            this.txtDescricao = new MetroFramework.Controls.MetroTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCadastrar = new MetroFramework.Controls.MetroButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtEstoque = new MetroFramework.Controls.MetroTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPreco = new MetroFramework.Controls.MetroTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtAno = new MetroFramework.Controls.MetroTextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbMarca = new MetroFramework.Controls.MetroComboBox();
            this.cmbModelo = new MetroFramework.Controls.MetroComboBox();
            this.SuspendLayout();
            // 
            // txtDescricao
            // 
            this.txtDescricao.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.txtDescricao.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtDescricao.Lines = new string[0];
            this.txtDescricao.Location = new System.Drawing.Point(410, 111);
            this.txtDescricao.MaxLength = 32767;
            this.txtDescricao.Multiline = true;
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.PasswordChar = '\0';
            this.txtDescricao.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtDescricao.SelectedText = "";
            this.txtDescricao.Size = new System.Drawing.Size(240, 155);
            this.txtDescricao.Style = MetroFramework.MetroColorStyle.Teal;
            this.txtDescricao.TabIndex = 4;
            this.txtDescricao.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtDescricao.UseSelectable = true;
            this.txtDescricao.UseStyleColors = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Teal;
            this.label3.Location = new System.Drawing.Point(406, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 20);
            this.label3.TabIndex = 61;
            this.label3.Text = "Descrição";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Teal;
            this.label2.Location = new System.Drawing.Point(119, 150);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 20);
            this.label2.TabIndex = 60;
            this.label2.Text = "Modelo:";
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btnCadastrar.Highlight = true;
            this.btnCadastrar.Location = new System.Drawing.Point(301, 368);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(176, 65);
            this.btnCadastrar.Style = MetroFramework.MetroColorStyle.Teal;
            this.btnCadastrar.TabIndex = 6;
            this.btnCadastrar.Text = "CADASTRAR";
            this.btnCadastrar.Theme = MetroFramework.MetroThemeStyle.Light;
            this.btnCadastrar.UseSelectable = true;
            this.btnCadastrar.UseStyleColors = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Teal;
            this.label1.Location = new System.Drawing.Point(119, 214);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 20);
            this.label1.TabIndex = 54;
            this.label1.Text = "Ano:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Teal;
            this.label9.Location = new System.Drawing.Point(121, 88);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(57, 20);
            this.label9.TabIndex = 53;
            this.label9.Text = "Marca:";
            // 
            // txtEstoque
            // 
            this.txtEstoque.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.txtEstoque.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtEstoque.Lines = new string[0];
            this.txtEstoque.Location = new System.Drawing.Point(124, 309);
            this.txtEstoque.MaxLength = 32767;
            this.txtEstoque.Name = "txtEstoque";
            this.txtEstoque.PasswordChar = '\0';
            this.txtEstoque.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtEstoque.SelectedText = "";
            this.txtEstoque.Size = new System.Drawing.Size(240, 29);
            this.txtEstoque.Style = MetroFramework.MetroColorStyle.Teal;
            this.txtEstoque.TabIndex = 3;
            this.txtEstoque.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtEstoque.UseSelectable = true;
            this.txtEstoque.UseStyleColors = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Teal;
            this.label4.Location = new System.Drawing.Point(120, 286);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 20);
            this.label4.TabIndex = 63;
            this.label4.Text = "Estoque:";
            // 
            // txtPreco
            // 
            this.txtPreco.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.txtPreco.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtPreco.Lines = new string[0];
            this.txtPreco.Location = new System.Drawing.Point(410, 309);
            this.txtPreco.MaxLength = 32767;
            this.txtPreco.Name = "txtPreco";
            this.txtPreco.PasswordChar = '\0';
            this.txtPreco.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtPreco.SelectedText = "";
            this.txtPreco.Size = new System.Drawing.Size(240, 29);
            this.txtPreco.Style = MetroFramework.MetroColorStyle.Teal;
            this.txtPreco.TabIndex = 5;
            this.txtPreco.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtPreco.UseSelectable = true;
            this.txtPreco.UseStyleColors = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Teal;
            this.label5.Location = new System.Drawing.Point(406, 286);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 20);
            this.label5.TabIndex = 65;
            this.label5.Text = "Preço:";
            // 
            // txtAno
            // 
            this.txtAno.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.txtAno.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtAno.Lines = new string[0];
            this.txtAno.Location = new System.Drawing.Point(123, 237);
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
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(679, 111);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(180, 160);
            this.listBox1.TabIndex = 84;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(865, 111);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 83;
            this.button1.Text = "Adicionar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Teal;
            this.label6.Location = new System.Drawing.Point(675, 88);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 20);
            this.label6.TabIndex = 85;
            this.label6.Text = "Imagens";
            // 
            // cmbMarca
            // 
            this.cmbMarca.BackColor = System.Drawing.SystemColors.Window;
            this.cmbMarca.ForeColor = System.Drawing.Color.Teal;
            this.cmbMarca.FormattingEnabled = true;
            this.cmbMarca.ItemHeight = 23;
            this.cmbMarca.Location = new System.Drawing.Point(123, 109);
            this.cmbMarca.Name = "cmbMarca";
            this.cmbMarca.Size = new System.Drawing.Size(240, 29);
            this.cmbMarca.Style = MetroFramework.MetroColorStyle.Teal;
            this.cmbMarca.TabIndex = 86;
            this.cmbMarca.UseSelectable = true;
            this.cmbMarca.SelectedIndexChanged += new System.EventHandler(this.cmbMarca_SelectedIndexChanged);
            // 
            // cmbModelo
            // 
            this.cmbModelo.BackColor = System.Drawing.SystemColors.Window;
            this.cmbModelo.ForeColor = System.Drawing.Color.Teal;
            this.cmbModelo.FormattingEnabled = true;
            this.cmbModelo.ItemHeight = 23;
            this.cmbModelo.Location = new System.Drawing.Point(123, 173);
            this.cmbModelo.Name = "cmbModelo";
            this.cmbModelo.Size = new System.Drawing.Size(240, 29);
            this.cmbModelo.Style = MetroFramework.MetroColorStyle.Teal;
            this.cmbModelo.TabIndex = 87;
            this.cmbModelo.UseSelectable = true;
            // 
            // FormCadastroPeca
            // 
            this.AcceptButton = this.btnCadastrar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(964, 568);
            this.Controls.Add(this.cmbModelo);
            this.Controls.Add(this.cmbMarca);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtAno);
            this.Controls.Add(this.txtPreco);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtEstoque);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtDescricao);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label9);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "FormCadastroPeca";
            this.Style = MetroFramework.MetroColorStyle.Teal;
            this.Text = "Cadastro de Peças";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.FormCadastroPeca_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroTextBox txtDescricao;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private MetroFramework.Controls.MetroButton btnCadastrar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label9;
        private MetroFramework.Controls.MetroTextBox txtEstoque;
        private System.Windows.Forms.Label label4;
        private MetroFramework.Controls.MetroTextBox txtPreco;
        private System.Windows.Forms.Label label5;
        private MetroFramework.Controls.MetroTextBox txtAno;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label6;
        private MetroFramework.Controls.MetroComboBox cmbMarca;
        private MetroFramework.Controls.MetroComboBox cmbModelo;
    }
}