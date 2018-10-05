namespace WindowsFormsFerroVelho
{
    partial class FormPesquisaTag
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
            this.lblID = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTag = new MetroFramework.Controls.MetroTextBox();
            this.btnPesquisar = new MetroFramework.Controls.MetroButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblID.ForeColor = System.Drawing.Color.Teal;
            this.lblID.Location = new System.Drawing.Point(231, 8);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(0, 20);
            this.lblID.TabIndex = 78;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Teal;
            this.label2.Location = new System.Drawing.Point(37, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 20);
            this.label2.TabIndex = 75;
            this.label2.Text = "Tag:";
            // 
            // txtTag
            // 
            this.txtTag.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.txtTag.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtTag.Lines = new string[0];
            this.txtTag.Location = new System.Drawing.Point(37, 104);
            this.txtTag.MaxLength = 32767;
            this.txtTag.Name = "txtTag";
            this.txtTag.PasswordChar = '\0';
            this.txtTag.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtTag.SelectedText = "";
            this.txtTag.Size = new System.Drawing.Size(240, 29);
            this.txtTag.Style = MetroFramework.MetroColorStyle.Teal;
            this.txtTag.TabIndex = 68;
            this.txtTag.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtTag.UseSelectable = true;
            this.txtTag.UseStyleColors = true;
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btnPesquisar.Highlight = true;
            this.btnPesquisar.Location = new System.Drawing.Point(41, 172);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(176, 65);
            this.btnPesquisar.Style = MetroFramework.MetroColorStyle.Teal;
            this.btnPesquisar.TabIndex = 72;
            this.btnPesquisar.Text = "PESQUISAR";
            this.btnPesquisar.Theme = MetroFramework.MetroThemeStyle.Light;
            this.btnPesquisar.UseSelectable = true;
            this.btnPesquisar.UseStyleColors = true;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(325, 26);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(486, 348);
            this.dataGridView1.TabIndex = 79;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(184, 139);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(93, 17);
            this.checkBox1.TabIndex = 80;
            this.checkBox1.Text = " Múltiplas tags";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // FormPesquisaTag
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(875, 421);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtTag);
            this.Controls.Add(this.btnPesquisar);
            this.Name = "FormPesquisaTag";
            this.Text = "Pesquisa por Tags";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Label label2;
        private MetroFramework.Controls.MetroTextBox txtTag;
        private MetroFramework.Controls.MetroButton btnPesquisar;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}