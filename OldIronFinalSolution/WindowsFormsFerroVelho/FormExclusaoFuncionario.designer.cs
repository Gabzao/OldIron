namespace WindowsFormsFerroVelho
{
    partial class FormExclusaoFuncionario
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
            this.btnDeletar = new MetroFramework.Controls.MetroButton();
            this.txtNome = new MetroFramework.Controls.MetroTextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lblID = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDeletar
            // 
            this.btnDeletar.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btnDeletar.Highlight = true;
            this.btnDeletar.Location = new System.Drawing.Point(114, 295);
            this.btnDeletar.Name = "btnDeletar";
            this.btnDeletar.Size = new System.Drawing.Size(135, 62);
            this.btnDeletar.Style = MetroFramework.MetroColorStyle.Teal;
            this.btnDeletar.TabIndex = 1;
            this.btnDeletar.Text = "DELETAR";
            this.btnDeletar.Theme = MetroFramework.MetroThemeStyle.Light;
            this.btnDeletar.UseSelectable = true;
            this.btnDeletar.UseStyleColors = true;
            this.btnDeletar.Click += new System.EventHandler(this.btnDeletar_Click);
            // 
            // txtNome
            // 
            this.txtNome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.txtNome.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtNome.Lines = new string[0];
            this.txtNome.Location = new System.Drawing.Point(73, 241);
            this.txtNome.MaxLength = 32767;
            this.txtNome.Name = "txtNome";
            this.txtNome.PasswordChar = '\0';
            this.txtNome.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtNome.SelectedText = "";
            this.txtNome.Size = new System.Drawing.Size(240, 29);
            this.txtNome.Style = MetroFramework.MetroColorStyle.Teal;
            this.txtNome.TabIndex = 0;
            this.txtNome.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtNome.UseSelectable = true;
            this.txtNome.UseStyleColors = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Teal;
            this.label9.Location = new System.Drawing.Point(70, 218);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(51, 20);
            this.label9.TabIndex = 43;
            this.label9.Text = "Nome";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(376, 121);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(465, 333);
            this.dataGridView1.TabIndex = 49;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblID.ForeColor = System.Drawing.Color.Teal;
            this.lblID.Location = new System.Drawing.Point(69, 185);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(26, 20);
            this.lblID.TabIndex = 50;
            this.lblID.Text = "ID";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Teal;
            this.label5.Location = new System.Drawing.Point(372, 98);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(196, 20);
            this.label5.TabIndex = 69;
            this.label5.Text = "Funcionários cadastrados:";
            // 
            // FormExclusaoFuncionario
            // 
            this.AcceptButton = this.btnDeletar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(864, 523);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnDeletar);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.label9);
            this.Name = "FormExclusaoFuncionario";
            this.Text = "Exclusão de Funcionários";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroButton btnDeletar;
        private MetroFramework.Controls.MetroTextBox txtNome;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Label label5;
    }
}