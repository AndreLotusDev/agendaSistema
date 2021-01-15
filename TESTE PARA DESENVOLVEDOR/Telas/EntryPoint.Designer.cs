
namespace TESTE_PARA_DESENVOLVEDOR
{
    partial class EntryPoint
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
            this.BtnLogin = new System.Windows.Forms.Button();
            this.LblNome = new System.Windows.Forms.Label();
            this.TxtNome = new System.Windows.Forms.TextBox();
            this.LblSenha = new System.Windows.Forms.Label();
            this.TxtSenha = new System.Windows.Forms.TextBox();
            this.BtnCadastrar = new System.Windows.Forms.Button();
            this.CheckSenhaLogin = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // BtnLogin
            // 
            this.BtnLogin.Font = new System.Drawing.Font("Corbel Light", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnLogin.Location = new System.Drawing.Point(12, 167);
            this.BtnLogin.Name = "BtnLogin";
            this.BtnLogin.Size = new System.Drawing.Size(85, 43);
            this.BtnLogin.TabIndex = 0;
            this.BtnLogin.Text = "Login";
            this.BtnLogin.UseVisualStyleBackColor = true;
            this.BtnLogin.Click += new System.EventHandler(this.BtnLogin_Click);
            // 
            // LblNome
            // 
            this.LblNome.AutoSize = true;
            this.LblNome.Font = new System.Drawing.Font("Corbel Light", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblNome.Location = new System.Drawing.Point(12, 9);
            this.LblNome.Name = "LblNome";
            this.LblNome.Size = new System.Drawing.Size(153, 26);
            this.LblNome.TabIndex = 1;
            this.LblNome.Text = "Digite o seu nome";
            // 
            // TxtNome
            // 
            this.TxtNome.Font = new System.Drawing.Font("Corbel Light", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtNome.Location = new System.Drawing.Point(17, 38);
            this.TxtNome.Name = "TxtNome";
            this.TxtNome.Size = new System.Drawing.Size(481, 33);
            this.TxtNome.TabIndex = 2;
            this.TxtNome.Text = "Soares";
            // 
            // LblSenha
            // 
            this.LblSenha.AutoSize = true;
            this.LblSenha.Font = new System.Drawing.Font("Corbel Light", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblSenha.Location = new System.Drawing.Point(12, 88);
            this.LblSenha.Name = "LblSenha";
            this.LblSenha.Size = new System.Drawing.Size(157, 26);
            this.LblSenha.TabIndex = 3;
            this.LblSenha.Text = "Digite a sua senha";
            // 
            // TxtSenha
            // 
            this.TxtSenha.Font = new System.Drawing.Font("Corbel Light", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtSenha.Location = new System.Drawing.Point(17, 117);
            this.TxtSenha.Name = "TxtSenha";
            this.TxtSenha.Size = new System.Drawing.Size(481, 33);
            this.TxtSenha.TabIndex = 4;
            this.TxtSenha.Text = "123";
            this.TxtSenha.UseSystemPasswordChar = true;
            // 
            // BtnCadastrar
            // 
            this.BtnCadastrar.Font = new System.Drawing.Font("Corbel Light", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCadastrar.Location = new System.Drawing.Point(112, 167);
            this.BtnCadastrar.Name = "BtnCadastrar";
            this.BtnCadastrar.Size = new System.Drawing.Size(85, 43);
            this.BtnCadastrar.TabIndex = 5;
            this.BtnCadastrar.Text = "Cadastrar";
            this.BtnCadastrar.UseVisualStyleBackColor = true;
            this.BtnCadastrar.Click += new System.EventHandler(this.BtnCadastrar_Click);
            // 
            // CheckSenhaLogin
            // 
            this.CheckSenhaLogin.AutoSize = true;
            this.CheckSenhaLogin.Checked = true;
            this.CheckSenhaLogin.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CheckSenhaLogin.Location = new System.Drawing.Point(504, 128);
            this.CheckSenhaLogin.Name = "CheckSenhaLogin";
            this.CheckSenhaLogin.Size = new System.Drawing.Size(15, 14);
            this.CheckSenhaLogin.TabIndex = 6;
            this.CheckSenhaLogin.UseVisualStyleBackColor = true;
            this.CheckSenhaLogin.Click += new System.EventHandler(this.CheckSenhaLogin_Click);
            // 
            // EntryPoint
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(522, 222);
            this.Controls.Add(this.CheckSenhaLogin);
            this.Controls.Add(this.BtnCadastrar);
            this.Controls.Add(this.TxtSenha);
            this.Controls.Add(this.LblSenha);
            this.Controls.Add(this.TxtNome);
            this.Controls.Add(this.LblNome);
            this.Controls.Add(this.BtnLogin);
            this.Name = "EntryPoint";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sistema de Agenda";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnLogin;
        private System.Windows.Forms.Label LblNome;
        private System.Windows.Forms.TextBox TxtNome;
        private System.Windows.Forms.Label LblSenha;
        private System.Windows.Forms.TextBox TxtSenha;
        private System.Windows.Forms.Button BtnCadastrar;
        private System.Windows.Forms.CheckBox CheckSenhaLogin;
    }
}

