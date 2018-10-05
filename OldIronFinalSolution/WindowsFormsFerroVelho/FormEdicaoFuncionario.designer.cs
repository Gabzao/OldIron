namespace WindowsFormsFerroVelho
{
    partial class FormEdicaoFuncionario
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
            this.txtNovaSenha = new MetroFramework.Controls.MetroTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtUsuario = new MetroFramework.Controls.MetroTextBox();
            this.ckMostrarSenha = new System.Windows.Forms.CheckBox();
            this.btnEditar = new MetroFramework.Controls.MetroButton();
            this.txtSenha = new MetroFramework.Controls.MetroTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNovoUsuario = new MetroFramework.Controls.MetroTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lblID = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNovaSenha
            // 
            this.txtNovaSenha.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.txtNovaSenha.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtNovaSenha.Lines = new string[0];
            this.txtNovaSenha.Location = new System.Drawing.Point(56, 311);
            this.txtNovaSenha.MaxLength = 32767;
            this.txtNovaSenha.Name = "txtNovaSenha";
            this.txtNovaSenha.PasswordChar = '\0';
            this.txtNovaSenha.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtNovaSenha.SelectedText = "";
            this.txtNovaSenha.Size = new System.Drawing.Size(240, 29);
            this.txtNovaSenha.Style = MetroFramework.MetroColorStyle.Teal;
            this.txtNovaSenha.TabIndex = 3;
            this.txtNovaSenha.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtNovaSenha.UseSelectable = true;
            this.txtNovaSenha.UseStyleColors = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Teal;
            this.label3.Location = new System.Drawing.Point(52, 288);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 20);
            this.label3.TabIndex = 61;
            this.label3.Text = "Nova senha:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Teal;
            this.label2.Location = new System.Drawing.Point(53, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 20);
            this.label2.TabIndex = 60;
            this.label2.Text = "Usuário:";
            // 
            // txtUsuario
            // 
            this.txtUsuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.txtUsuario.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtUsuario.Lines = new string[0];
            this.txtUsuario.Location = new System.Drawing.Point(57, 111);
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
            // ckMostrarSenha
            // 
            this.ckMostrarSenha.AutoSize = true;
            this.ckMostrarSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckMostrarSenha.ForeColor = System.Drawing.Color.Teal;
            this.ckMostrarSenha.Location = new System.Drawing.Point(56, 356);
            this.ckMostrarSenha.Name = "ckMostrarSenha";
            this.ckMostrarSenha.Size = new System.Drawing.Size(120, 21);
            this.ckMostrarSenha.TabIndex = 58;
            this.ckMostrarSenha.Text = "Mostrar Senha";
            this.ckMostrarSenha.UseVisualStyleBackColor = true;
            this.ckMostrarSenha.CheckedChanged += new System.EventHandler(this.ckMostrarSenha_CheckedChanged);
            // 
            // btnEditar
            // 
            this.btnEditar.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btnEditar.Highlight = true;
            this.btnEditar.Location = new System.Drawing.Point(73, 392);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(176, 65);
            this.btnEditar.Style = MetroFramework.MetroColorStyle.Teal;
            this.btnEditar.TabIndex = 4;
            this.btnEditar.Text = "EDITAR";
            this.btnEditar.Theme = MetroFramework.MetroThemeStyle.Light;
            this.btnEditar.UseSelectable = true;
            this.btnEditar.UseStyleColors = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // txtSenha
            // 
            this.txtSenha.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.txtSenha.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtSenha.Lines = new string[0];
            this.txtSenha.Location = new System.Drawing.Point(57, 247);
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Teal;
            this.label1.Location = new System.Drawing.Point(53, 224);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 20);
            this.label1.TabIndex = 54;
            this.label1.Text = "Senha Atual:";
            // 
            // txtNovoUsuario
            // 
            this.txtNovoUsuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.txtNovoUsuario.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtNovoUsuario.Lines = new string[0];
            this.txtNovoUsuario.Location = new System.Drawing.Point(57, 179);
            this.txtNovoUsuario.MaxLength = 32767;
            this.txtNovoUsuario.Name = "txtNovoUsuario";
            this.txtNovoUsuario.PasswordChar = '\0';
            this.txtNovoUsuario.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtNovoUsuario.SelectedText = "";
            this.txtNovoUsuario.Size = new System.Drawing.Size(240, 29);
            this.txtNovoUsuario.Style = MetroFramework.MetroColorStyle.Teal;
            this.txtNovoUsuario.TabIndex = 1;
            this.txtNovoUsuario.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtNovoUsuario.UseSelectable = true;
            this.txtNovoUsuario.UseStyleColors = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Teal;
            this.label4.Location = new System.Drawing.Point(55, 156);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 20);
            this.label4.TabIndex = 65;
            this.label4.Text = "Novo usuário:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(393, 88);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(439, 413);
            this.dataGridView1.TabIndex = 66;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblID.ForeColor = System.Drawing.Color.Teal;
            this.lblID.Location = new System.Drawing.Point(52, 54);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(26, 20);
            this.lblID.TabIndex = 67;
            this.lblID.Text = "ID";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Teal;
            this.label5.Location = new System.Drawing.Point(389, 65);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(196, 20);
            this.label5.TabIndex = 68;
            this.label5.Text = "Funcionários cadastrados:";
            // 
            // FormEdicaoFuncionario
            // 
            this.AcceptButton = this.btnEditar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(927, 533);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtNovoUsuario);
            this.Controls.Add(this.txtNovaSenha);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.ckMostrarSenha);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.txtSenha);
            this.Controls.Add(this.label1);
            this.Name = "FormEdicaoFuncionario";
            this.Text = "Edição de Funcionários";
            this.Load += new System.EventHandler(this.FormEdicaoFuncionario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroTextBox txtNovaSenha;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private MetroFramework.Controls.MetroTextBox txtUsuario;
        private System.Windows.Forms.CheckBox ckMostrarSenha;
        private MetroFramework.Controls.MetroButton btnEditar;
        private MetroFramework.Controls.MetroTextBox txtSenha;
        private System.Windows.Forms.Label label1;
        private MetroFramework.Controls.MetroTextBox txtNovoUsuario;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Label label5;
    }
}