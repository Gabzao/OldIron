namespace WindowsFormsFerroVelho
{
    partial class FormCadastroMarca
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
            this.txtNomeMarca = new MetroFramework.Controls.MetroTextBox();
            this.btnCadastrar = new MetroFramework.Controls.MetroButton();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtNomeMarca
            // 
            this.txtNomeMarca.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.txtNomeMarca.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtNomeMarca.Lines = new string[0];
            this.txtNomeMarca.Location = new System.Drawing.Point(232, 157);
            this.txtNomeMarca.MaxLength = 32767;
            this.txtNomeMarca.Name = "txtNomeMarca";
            this.txtNomeMarca.PasswordChar = '\0';
            this.txtNomeMarca.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtNomeMarca.SelectedText = "";
            this.txtNomeMarca.Size = new System.Drawing.Size(240, 29);
            this.txtNomeMarca.Style = MetroFramework.MetroColorStyle.Teal;
            this.txtNomeMarca.TabIndex = 64;
            this.txtNomeMarca.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtNomeMarca.UseSelectable = true;
            this.txtNomeMarca.UseStyleColors = true;
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btnCadastrar.Highlight = true;
            this.btnCadastrar.Location = new System.Drawing.Point(271, 219);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(176, 65);
            this.btnCadastrar.Style = MetroFramework.MetroColorStyle.Teal;
            this.btnCadastrar.TabIndex = 66;
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
            this.label1.Location = new System.Drawing.Point(228, 134);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 20);
            this.label1.TabIndex = 68;
            this.label1.Text = "Marca";
            // 
            // FormCadastroMarca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(720, 475);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNomeMarca);
            this.Controls.Add(this.btnCadastrar);
            this.Name = "FormCadastroMarca";
            this.Text = "Cadastro de Marcas";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroTextBox txtNomeMarca;
        private MetroFramework.Controls.MetroButton btnCadastrar;
        private System.Windows.Forms.Label label1;
    }
}