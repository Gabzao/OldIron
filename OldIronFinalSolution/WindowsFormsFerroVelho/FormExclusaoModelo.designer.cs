namespace WindowsFormsFerroVelho
{
    partial class FormExclusaoModelo
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lblID = new System.Windows.Forms.Label();
            this.txtNome = new MetroFramework.Controls.MetroTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnExcluir = new MetroFramework.Controls.MetroButton();
            this.cmbMarca = new MetroFramework.Controls.MetroComboBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(338, 38);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(456, 445);
            this.dataGridView1.TabIndex = 104;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblID.ForeColor = System.Drawing.Color.Teal;
            this.lblID.Location = new System.Drawing.Point(51, 48);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(26, 20);
            this.lblID.TabIndex = 112;
            this.lblID.Text = "ID";
            // 
            // txtNome
            // 
            this.txtNome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.txtNome.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtNome.Lines = new string[0];
            this.txtNome.Location = new System.Drawing.Point(53, 110);
            this.txtNome.MaxLength = 32767;
            this.txtNome.Name = "txtNome";
            this.txtNome.PasswordChar = '\0';
            this.txtNome.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtNome.SelectedText = "";
            this.txtNome.Size = new System.Drawing.Size(240, 29);
            this.txtNome.Style = MetroFramework.MetroColorStyle.Teal;
            this.txtNome.TabIndex = 107;
            this.txtNome.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtNome.UseSelectable = true;
            this.txtNome.UseStyleColors = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Teal;
            this.label4.Location = new System.Drawing.Point(49, 87);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 20);
            this.label4.TabIndex = 109;
            this.label4.Text = "Nome:";
            // 
            // btnExcluir
            // 
            this.btnExcluir.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btnExcluir.Highlight = true;
            this.btnExcluir.Location = new System.Drawing.Point(71, 256);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(176, 65);
            this.btnExcluir.Style = MetroFramework.MetroColorStyle.Teal;
            this.btnExcluir.TabIndex = 108;
            this.btnExcluir.Text = "DELETAR";
            this.btnExcluir.Theme = MetroFramework.MetroThemeStyle.Light;
            this.btnExcluir.UseSelectable = true;
            this.btnExcluir.UseStyleColors = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // cmbMarca
            // 
            this.cmbMarca.BackColor = System.Drawing.SystemColors.Window;
            this.cmbMarca.ForeColor = System.Drawing.Color.Teal;
            this.cmbMarca.FormattingEnabled = true;
            this.cmbMarca.ItemHeight = 23;
            this.cmbMarca.Location = new System.Drawing.Point(53, 178);
            this.cmbMarca.Name = "cmbMarca";
            this.cmbMarca.Size = new System.Drawing.Size(240, 29);
            this.cmbMarca.Style = MetroFramework.MetroColorStyle.Teal;
            this.cmbMarca.TabIndex = 106;
            this.cmbMarca.UseSelectable = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Teal;
            this.label1.Location = new System.Drawing.Point(49, 155);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 20);
            this.label1.TabIndex = 105;
            this.label1.Text = "Marca:";
            // 
            // FormExclusaoModelo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(843, 520);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.cmbMarca);
            this.Controls.Add(this.label1);
            this.Name = "FormExclusaoModelo";
            this.Text = "Exclusão de Modelos";
            this.Load += new System.EventHandler(this.FormExclusaoModelo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lblID;
        private MetroFramework.Controls.MetroTextBox txtNome;
        private System.Windows.Forms.Label label4;
        private MetroFramework.Controls.MetroButton btnExcluir;
        private MetroFramework.Controls.MetroComboBox cmbMarca;
        private System.Windows.Forms.Label label1;
    }
}