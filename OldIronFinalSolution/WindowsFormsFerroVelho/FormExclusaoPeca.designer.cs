namespace WindowsFormsFerroVelho
{
    partial class FormExclusaoPeca
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
            this.txtAno = new MetroFramework.Controls.MetroTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtModelo = new MetroFramework.Controls.MetroTextBox();
            this.btnDeletar = new MetroFramework.Controls.MetroButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(362, 125);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(502, 259);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblID.ForeColor = System.Drawing.Color.Teal;
            this.lblID.Location = new System.Drawing.Point(62, 150);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(26, 20);
            this.lblID.TabIndex = 96;
            this.lblID.Text = "ID";
            // 
            // txtAno
            // 
            this.txtAno.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.txtAno.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtAno.Lines = new string[0];
            this.txtAno.Location = new System.Drawing.Point(66, 269);
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Teal;
            this.label2.Location = new System.Drawing.Point(61, 181);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 20);
            this.label2.TabIndex = 88;
            this.label2.Text = "Modelo:";
            // 
            // txtModelo
            // 
            this.txtModelo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.txtModelo.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtModelo.Lines = new string[0];
            this.txtModelo.Location = new System.Drawing.Point(65, 204);
            this.txtModelo.MaxLength = 32767;
            this.txtModelo.Name = "txtModelo";
            this.txtModelo.PasswordChar = '\0';
            this.txtModelo.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtModelo.SelectedText = "";
            this.txtModelo.Size = new System.Drawing.Size(240, 29);
            this.txtModelo.Style = MetroFramework.MetroColorStyle.Teal;
            this.txtModelo.TabIndex = 1;
            this.txtModelo.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtModelo.UseSelectable = true;
            this.txtModelo.UseStyleColors = true;
            // 
            // btnDeletar
            // 
            this.btnDeletar.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btnDeletar.Highlight = true;
            this.btnDeletar.Location = new System.Drawing.Point(102, 336);
            this.btnDeletar.Name = "btnDeletar";
            this.btnDeletar.Size = new System.Drawing.Size(155, 48);
            this.btnDeletar.Style = MetroFramework.MetroColorStyle.Teal;
            this.btnDeletar.TabIndex = 3;
            this.btnDeletar.Text = "DELETAR";
            this.btnDeletar.Theme = MetroFramework.MetroThemeStyle.Light;
            this.btnDeletar.UseSelectable = true;
            this.btnDeletar.UseStyleColors = true;
            this.btnDeletar.Click += new System.EventHandler(this.btnDeletar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Teal;
            this.label1.Location = new System.Drawing.Point(61, 246);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 20);
            this.label1.TabIndex = 84;
            this.label1.Text = "Ano:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Teal;
            this.label3.Location = new System.Drawing.Point(358, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(149, 20);
            this.label3.TabIndex = 97;
            this.label3.Text = "Peças cadastradas:";
            // 
            // FormExclusaoPeca
            // 
            this.AcceptButton = this.btnDeletar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(872, 503);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.txtAno);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtModelo);
            this.Controls.Add(this.btnDeletar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FormExclusaoPeca";
            this.Text = "Exclusão de Peças";
            this.Load += new System.EventHandler(this.FormExclusaoPeca_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lblID;
        private MetroFramework.Controls.MetroTextBox txtAno;
        private System.Windows.Forms.Label label2;
        private MetroFramework.Controls.MetroTextBox txtModelo;
        private MetroFramework.Controls.MetroButton btnDeletar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
    }
}