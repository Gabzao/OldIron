﻿namespace WindowsFormsFerroVelho
{
    partial class FormEdicaoTag
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
            this.txtTag = new MetroFramework.Controls.MetroTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnCadastrar = new MetroFramework.Controls.MetroButton();
            this.txtID_Peca = new MetroFramework.Controls.MetroTextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Teal;
            this.label2.Location = new System.Drawing.Point(395, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(149, 20);
            this.label2.TabIndex = 79;
            this.label2.Text = "Peças cadastradas:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(399, 122);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(470, 238);
            this.dataGridView1.TabIndex = 78;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // txtTag
            // 
            this.txtTag.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.txtTag.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtTag.Lines = new string[0];
            this.txtTag.Location = new System.Drawing.Point(48, 188);
            this.txtTag.MaxLength = 32767;
            this.txtTag.Multiline = true;
            this.txtTag.Name = "txtTag";
            this.txtTag.PasswordChar = '\0';
            this.txtTag.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtTag.SelectedText = "";
            this.txtTag.Size = new System.Drawing.Size(240, 172);
            this.txtTag.Style = MetroFramework.MetroColorStyle.Teal;
            this.txtTag.TabIndex = 81;
            this.txtTag.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtTag.UseSelectable = true;
            this.txtTag.UseStyleColors = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Teal;
            this.label3.Location = new System.Drawing.Point(44, 165);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 20);
            this.label3.TabIndex = 84;
            this.label3.Text = "Tag:";
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btnCadastrar.Highlight = true;
            this.btnCadastrar.Location = new System.Drawing.Point(64, 392);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(176, 65);
            this.btnCadastrar.Style = MetroFramework.MetroColorStyle.Teal;
            this.btnCadastrar.TabIndex = 82;
            this.btnCadastrar.Text = "EDITAR";
            this.btnCadastrar.Theme = MetroFramework.MetroThemeStyle.Light;
            this.btnCadastrar.UseSelectable = true;
            this.btnCadastrar.UseStyleColors = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // txtID_Peca
            // 
            this.txtID_Peca.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.txtID_Peca.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtID_Peca.Lines = new string[0];
            this.txtID_Peca.Location = new System.Drawing.Point(48, 122);
            this.txtID_Peca.MaxLength = 32767;
            this.txtID_Peca.Name = "txtID_Peca";
            this.txtID_Peca.PasswordChar = '\0';
            this.txtID_Peca.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtID_Peca.SelectedText = "";
            this.txtID_Peca.Size = new System.Drawing.Size(240, 29);
            this.txtID_Peca.Style = MetroFramework.MetroColorStyle.Teal;
            this.txtID_Peca.TabIndex = 80;
            this.txtID_Peca.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtID_Peca.UseSelectable = true;
            this.txtID_Peca.UseStyleColors = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Teal;
            this.label1.Location = new System.Drawing.Point(44, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 20);
            this.label1.TabIndex = 83;
            this.label1.Text = "ID da peça:";
            // 
            // FormEdicaoTag
            // 
            this.AcceptButton = this.btnCadastrar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(892, 529);
            this.Controls.Add(this.txtTag);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.txtID_Peca);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FormEdicaoTag";
            this.Text = "Edição de tags";
            this.Load += new System.EventHandler(this.FormEdicaoTag_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private MetroFramework.Controls.MetroTextBox txtTag;
        private System.Windows.Forms.Label label3;
        private MetroFramework.Controls.MetroButton btnCadastrar;
        private MetroFramework.Controls.MetroTextBox txtID_Peca;
        private System.Windows.Forms.Label label1;
    }
}