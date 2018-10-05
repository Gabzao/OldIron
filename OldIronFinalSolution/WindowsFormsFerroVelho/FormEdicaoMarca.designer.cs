namespace WindowsFormsFerroVelho
{
    partial class FormEdicaoMarca
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtOldName = new MetroFramework.Controls.MetroTextBox();
            this.btnCadastrar = new MetroFramework.Controls.MetroButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNewName = new MetroFramework.Controls.MetroTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lblID = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Teal;
            this.label1.Location = new System.Drawing.Point(37, 111);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 20);
            this.label1.TabIndex = 71;
            this.label1.Text = "Nome atual:";
            // 
            // txtOldName
            // 
            this.txtOldName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.txtOldName.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtOldName.Lines = new string[0];
            this.txtOldName.Location = new System.Drawing.Point(41, 134);
            this.txtOldName.MaxLength = 32767;
            this.txtOldName.Name = "txtOldName";
            this.txtOldName.PasswordChar = '\0';
            this.txtOldName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtOldName.SelectedText = "";
            this.txtOldName.Size = new System.Drawing.Size(240, 29);
            this.txtOldName.Style = MetroFramework.MetroColorStyle.Teal;
            this.txtOldName.TabIndex = 69;
            this.txtOldName.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtOldName.UseSelectable = true;
            this.txtOldName.UseStyleColors = true;
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btnCadastrar.Highlight = true;
            this.btnCadastrar.Location = new System.Drawing.Point(67, 285);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(176, 65);
            this.btnCadastrar.Style = MetroFramework.MetroColorStyle.Teal;
            this.btnCadastrar.TabIndex = 70;
            this.btnCadastrar.Text = "EDITAR";
            this.btnCadastrar.Theme = MetroFramework.MetroThemeStyle.Light;
            this.btnCadastrar.UseSelectable = true;
            this.btnCadastrar.UseStyleColors = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(354, 44);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(456, 445);
            this.dataGridView1.TabIndex = 72;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Teal;
            this.label2.Location = new System.Drawing.Point(37, 184);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 20);
            this.label2.TabIndex = 73;
            // 
            // txtNewName
            // 
            this.txtNewName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.txtNewName.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtNewName.Lines = new string[0];
            this.txtNewName.Location = new System.Drawing.Point(41, 207);
            this.txtNewName.MaxLength = 32767;
            this.txtNewName.Name = "txtNewName";
            this.txtNewName.PasswordChar = '\0';
            this.txtNewName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtNewName.SelectedText = "";
            this.txtNewName.Size = new System.Drawing.Size(240, 29);
            this.txtNewName.Style = MetroFramework.MetroColorStyle.Teal;
            this.txtNewName.TabIndex = 74;
            this.txtNewName.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtNewName.UseSelectable = true;
            this.txtNewName.UseStyleColors = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Teal;
            this.label3.Location = new System.Drawing.Point(38, 184);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 20);
            this.label3.TabIndex = 75;
            this.label3.Text = "Novo nome:";
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblID.ForeColor = System.Drawing.Color.Teal;
            this.lblID.Location = new System.Drawing.Point(37, 76);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(26, 20);
            this.lblID.TabIndex = 76;
            this.lblID.Text = "ID";
            // 
            // FormEdicaoMarca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(814, 512);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtNewName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtOldName);
            this.Controls.Add(this.btnCadastrar);
            this.Name = "FormEdicaoMarca";
            this.Text = "Edição de Marcas";
            this.Load += new System.EventHandler(this.FormEdicaoMarca_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private MetroFramework.Controls.MetroTextBox txtOldName;
        private MetroFramework.Controls.MetroButton btnCadastrar;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label2;
        private MetroFramework.Controls.MetroTextBox txtNewName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblID;
    }
}