namespace WindowsFormsFerroVelho
{
    partial class FormEdicaoModelo
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
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtNome = new MetroFramework.Controls.MetroTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnEditar = new MetroFramework.Controls.MetroButton();
            this.cmbNovaMarca = new MetroFramework.Controls.MetroComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNovoNome = new MetroFramework.Controls.MetroTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lblID = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Teal;
            this.label2.Location = new System.Drawing.Point(-32, 154);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 20);
            this.label2.TabIndex = 81;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(314, 51);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(456, 445);
            this.dataGridView1.TabIndex = 80;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // txtNome
            // 
            this.txtNome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.txtNome.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtNome.Lines = new string[0];
            this.txtNome.Location = new System.Drawing.Point(31, 127);
            this.txtNome.MaxLength = 32767;
            this.txtNome.Name = "txtNome";
            this.txtNome.PasswordChar = '\0';
            this.txtNome.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtNome.SelectedText = "";
            this.txtNome.Size = new System.Drawing.Size(240, 29);
            this.txtNome.Style = MetroFramework.MetroColorStyle.Teal;
            this.txtNome.TabIndex = 98;
            this.txtNome.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtNome.UseSelectable = true;
            this.txtNome.UseStyleColors = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Teal;
            this.label4.Location = new System.Drawing.Point(27, 104);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 20);
            this.label4.TabIndex = 100;
            this.label4.Text = "Nome:";
            // 
            // btnEditar
            // 
            this.btnEditar.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btnEditar.Highlight = true;
            this.btnEditar.Location = new System.Drawing.Point(46, 344);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(176, 65);
            this.btnEditar.Style = MetroFramework.MetroColorStyle.Teal;
            this.btnEditar.TabIndex = 99;
            this.btnEditar.Text = "EDITAR";
            this.btnEditar.Theme = MetroFramework.MetroThemeStyle.Light;
            this.btnEditar.UseSelectable = true;
            this.btnEditar.UseStyleColors = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // cmbNovaMarca
            // 
            this.cmbNovaMarca.BackColor = System.Drawing.SystemColors.Window;
            this.cmbNovaMarca.ForeColor = System.Drawing.Color.Teal;
            this.cmbNovaMarca.FormattingEnabled = true;
            this.cmbNovaMarca.ItemHeight = 23;
            this.cmbNovaMarca.Location = new System.Drawing.Point(31, 277);
            this.cmbNovaMarca.Name = "cmbNovaMarca";
            this.cmbNovaMarca.Size = new System.Drawing.Size(240, 29);
            this.cmbNovaMarca.Style = MetroFramework.MetroColorStyle.Teal;
            this.cmbNovaMarca.TabIndex = 97;
            this.cmbNovaMarca.UseSelectable = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Teal;
            this.label1.Location = new System.Drawing.Point(27, 254);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 20);
            this.label1.TabIndex = 96;
            this.label1.Text = "Marca:";
            // 
            // txtNovoNome
            // 
            this.txtNovoNome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.txtNovoNome.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtNovoNome.Lines = new string[0];
            this.txtNovoNome.Location = new System.Drawing.Point(31, 201);
            this.txtNovoNome.MaxLength = 32767;
            this.txtNovoNome.Name = "txtNovoNome";
            this.txtNovoNome.PasswordChar = '\0';
            this.txtNovoNome.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtNovoNome.SelectedText = "";
            this.txtNovoNome.Size = new System.Drawing.Size(240, 29);
            this.txtNovoNome.Style = MetroFramework.MetroColorStyle.Teal;
            this.txtNovoNome.TabIndex = 101;
            this.txtNovoNome.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtNovoNome.UseSelectable = true;
            this.txtNovoNome.UseStyleColors = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Teal;
            this.label3.Location = new System.Drawing.Point(27, 178);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 20);
            this.label3.TabIndex = 102;
            this.label3.Text = "Novo nome:";
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblID.ForeColor = System.Drawing.Color.Teal;
            this.lblID.Location = new System.Drawing.Point(29, 65);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(26, 20);
            this.lblID.TabIndex = 103;
            this.lblID.Text = "ID";
            // 
            // FormEdicaoModelo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(806, 519);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.txtNovoNome);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.cmbNovaMarca);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Name = "FormEdicaoModelo";
            this.Text = "Edição de Modelos";
            this.Load += new System.EventHandler(this.FormEdicaoModelo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private MetroFramework.Controls.MetroTextBox txtNome;
        private System.Windows.Forms.Label label4;
        private MetroFramework.Controls.MetroButton btnEditar;
        private MetroFramework.Controls.MetroComboBox cmbNovaMarca;
        private System.Windows.Forms.Label label1;
        private MetroFramework.Controls.MetroTextBox txtNovoNome;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblID;
    }
}