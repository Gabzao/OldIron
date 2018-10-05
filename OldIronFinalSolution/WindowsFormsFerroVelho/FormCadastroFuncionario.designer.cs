namespace WindowsFormsFerroVelho
{
    partial class FormCadastroFuncionario
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
            this.ckMostrarSenha = new System.Windows.Forms.CheckBox();
            this.btnCadastrar = new MetroFramework.Controls.MetroButton();
            this.txtSenha = new MetroFramework.Controls.MetroTextBox();
            this.txtNome = new MetroFramework.Controls.MetroTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtUsuario = new MetroFramework.Controls.MetroTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtConfirmeSenha = new MetroFramework.Controls.MetroTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ckMostrarSenha
            // 
            this.ckMostrarSenha.AutoSize = true;
            this.ckMostrarSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckMostrarSenha.ForeColor = System.Drawing.Color.Teal;
            this.ckMostrarSenha.Location = new System.Drawing.Point(249, 384);
            this.ckMostrarSenha.Name = "ckMostrarSenha";
            this.ckMostrarSenha.Size = new System.Drawing.Size(120, 21);
            this.ckMostrarSenha.TabIndex = 48;
            this.ckMostrarSenha.Text = "Mostrar Senha";
            this.ckMostrarSenha.UseVisualStyleBackColor = true;
            this.ckMostrarSenha.CheckedChanged += new System.EventHandler(this.ckMostrarSenha_CheckedChanged);
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btnCadastrar.Highlight = true;
            this.btnCadastrar.Location = new System.Drawing.Point(278, 431);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(176, 65);
            this.btnCadastrar.Style = MetroFramework.MetroColorStyle.Teal;
            this.btnCadastrar.TabIndex = 4;
            this.btnCadastrar.Text = "CADASTRAR";
            this.btnCadastrar.Theme = MetroFramework.MetroThemeStyle.Light;
            this.btnCadastrar.UseSelectable = true;
            this.btnCadastrar.UseStyleColors = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // txtSenha
            // 
            this.txtSenha.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.txtSenha.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtSenha.Lines = new string[0];
            this.txtSenha.Location = new System.Drawing.Point(249, 276);
            this.txtSenha.MaxLength = 32767;
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.PasswordChar = '\0';
            this.txtSenha.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtSenha.SelectedText = "";
            this.txtSenha.Size = new System.Drawing.Size(240, 29);
            this.txtSenha.Style = MetroFramework.MetroColorStyle.Teal;
            this.txtSenha.TabIndex = 2;
            this.txtSenha.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtSenha.UseSelectable = true;
            this.txtSenha.UseStyleColors = true;
            // 
            // txtNome
            // 
            this.txtNome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.txtNome.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtNome.Lines = new string[0];
            this.txtNome.Location = new System.Drawing.Point(250, 136);
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Teal;
            this.label1.Location = new System.Drawing.Point(245, 253);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 20);
            this.label1.TabIndex = 44;
            this.label1.Text = "Senha:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Teal;
            this.label9.Location = new System.Drawing.Point(247, 113);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(55, 20);
            this.label9.TabIndex = 43;
            this.label9.Text = "Nome:";
            // 
            // txtUsuario
            // 
            this.txtUsuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.txtUsuario.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtUsuario.Lines = new string[0];
            this.txtUsuario.Location = new System.Drawing.Point(249, 211);
            this.txtUsuario.MaxLength = 32767;
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.PasswordChar = '\0';
            this.txtUsuario.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtUsuario.SelectedText = "";
            this.txtUsuario.Size = new System.Drawing.Size(240, 29);
            this.txtUsuario.Style = MetroFramework.MetroColorStyle.Teal;
            this.txtUsuario.TabIndex = 1;
            this.txtUsuario.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtUsuario.UseSelectable = true;
            this.txtUsuario.UseStyleColors = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Teal;
            this.label2.Location = new System.Drawing.Point(245, 188);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 20);
            this.label2.TabIndex = 50;
            this.label2.Text = "Usuário:";
            // 
            // txtConfirmeSenha
            // 
            this.txtConfirmeSenha.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.txtConfirmeSenha.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtConfirmeSenha.Lines = new string[0];
            this.txtConfirmeSenha.Location = new System.Drawing.Point(249, 349);
            this.txtConfirmeSenha.MaxLength = 32767;
            this.txtConfirmeSenha.Name = "txtConfirmeSenha";
            this.txtConfirmeSenha.PasswordChar = '\0';
            this.txtConfirmeSenha.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtConfirmeSenha.SelectedText = "";
            this.txtConfirmeSenha.Size = new System.Drawing.Size(240, 29);
            this.txtConfirmeSenha.Style = MetroFramework.MetroColorStyle.Teal;
            this.txtConfirmeSenha.TabIndex = 3;
            this.txtConfirmeSenha.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtConfirmeSenha.UseSelectable = true;
            this.txtConfirmeSenha.UseStyleColors = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Teal;
            this.label3.Location = new System.Drawing.Point(245, 326);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(138, 20);
            this.label3.TabIndex = 51;
            this.label3.Text = "Confirme a senha:";
            // 
            // FormCadastroFuncionario
            // 
            this.AcceptButton = this.btnCadastrar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(849, 519);
            this.Controls.Add(this.txtConfirmeSenha);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.ckMostrarSenha);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.txtSenha);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label9);
            this.Name = "FormCadastroFuncionario";
            this.Text = "Cadastro de Funcionários";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox ckMostrarSenha;
        private MetroFramework.Controls.MetroButton btnCadastrar;
        private MetroFramework.Controls.MetroTextBox txtSenha;
        private MetroFramework.Controls.MetroTextBox txtNome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label9;
        private MetroFramework.Controls.MetroTextBox txtUsuario;
        private System.Windows.Forms.Label label2;
        private MetroFramework.Controls.MetroTextBox txtConfirmeSenha;
        private System.Windows.Forms.Label label3;
    }
}