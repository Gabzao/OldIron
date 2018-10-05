namespace WindowsFormsFerroVelho
{
    partial class FormLogin
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
            this.label9 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtUsuario = new MetroFramework.Controls.MetroTextBox();
            this.txtSenha = new MetroFramework.Controls.MetroTextBox();
            this.btnLogar = new MetroFramework.Controls.MetroButton();
            this.ckMostrarSenha = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Teal;
            this.label9.Location = new System.Drawing.Point(166, 77);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(64, 20);
            this.label9.TabIndex = 35;
            this.label9.Text = "Usuário";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Teal;
            this.label1.Location = new System.Drawing.Point(165, 164);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 20);
            this.label1.TabIndex = 36;
            this.label1.Text = "Senha";
            // 
            // txtUsuario
            // 
            this.txtUsuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.txtUsuario.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtUsuario.Lines = new string[0];
            this.txtUsuario.Location = new System.Drawing.Point(169, 100);
            this.txtUsuario.MaxLength = 32767;
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.PasswordChar = '\0';
            this.txtUsuario.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtUsuario.SelectedText = "";
            this.txtUsuario.Size = new System.Drawing.Size(240, 29);
            this.txtUsuario.Style = MetroFramework.MetroColorStyle.Teal;
            this.txtUsuario.TabIndex = 0;
            this.txtUsuario.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtUsuario.UseSelectable = true;
            this.txtUsuario.UseStyleColors = true;
            // 
            // txtSenha
            // 
            this.txtSenha.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.txtSenha.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtSenha.Lines = new string[0];
            this.txtSenha.Location = new System.Drawing.Point(169, 187);
            this.txtSenha.MaxLength = 32767;
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.PasswordChar = '\0';
            this.txtSenha.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtSenha.SelectedText = "";
            this.txtSenha.Size = new System.Drawing.Size(240, 29);
            this.txtSenha.Style = MetroFramework.MetroColorStyle.Teal;
            this.txtSenha.TabIndex = 1;
            this.txtSenha.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtSenha.UseSelectable = true;
            this.txtSenha.UseStyleColors = true;
            // 
            // btnLogar
            // 
            this.btnLogar.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btnLogar.Highlight = true;
            this.btnLogar.Location = new System.Drawing.Point(198, 269);
            this.btnLogar.Name = "btnLogar";
            this.btnLogar.Size = new System.Drawing.Size(176, 65);
            this.btnLogar.Style = MetroFramework.MetroColorStyle.Teal;
            this.btnLogar.TabIndex = 2;
            this.btnLogar.Text = "Logar";
            this.btnLogar.Theme = MetroFramework.MetroThemeStyle.Light;
            this.btnLogar.UseSelectable = true;
            this.btnLogar.UseStyleColors = true;
            this.btnLogar.Click += new System.EventHandler(this.btnLogar_Click);
            // 
            // ckMostrarSenha
            // 
            this.ckMostrarSenha.AutoSize = true;
            this.ckMostrarSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckMostrarSenha.ForeColor = System.Drawing.Color.Teal;
            this.ckMostrarSenha.Location = new System.Drawing.Point(169, 222);
            this.ckMostrarSenha.Name = "ckMostrarSenha";
            this.ckMostrarSenha.Size = new System.Drawing.Size(120, 21);
            this.ckMostrarSenha.TabIndex = 42;
            this.ckMostrarSenha.Text = "Mostrar Senha";
            this.ckMostrarSenha.UseVisualStyleBackColor = true;
            this.ckMostrarSenha.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // FormLogin
            // 
            this.AcceptButton = this.btnLogar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(611, 426);
            this.Controls.Add(this.ckMostrarSenha);
            this.Controls.Add(this.btnLogar);
            this.Controls.Add(this.txtSenha);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label9);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "FormLogin";
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label1;
        private MetroFramework.Controls.MetroTextBox txtUsuario;
        private MetroFramework.Controls.MetroTextBox txtSenha;
        private MetroFramework.Controls.MetroButton btnLogar;
        private System.Windows.Forms.CheckBox ckMostrarSenha;
    }
}

