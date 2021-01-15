
namespace TESTE_PARA_DESENVOLVEDOR
{
    partial class TelaCadastro
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
            this.LblNomeCadastro = new System.Windows.Forms.Label();
            this.TXTNomeCadastro = new System.Windows.Forms.TextBox();
            this.TxtSenha = new System.Windows.Forms.TextBox();
            this.LblSenhaCadastro = new System.Windows.Forms.Label();
            this.BtnCadastrar = new System.Windows.Forms.Button();
            this.MostraSenha = new System.Windows.Forms.CheckBox();
            this.BtnVoltaLogin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LblNomeCadastro
            // 
            this.LblNomeCadastro.AutoSize = true;
            this.LblNomeCadastro.Font = new System.Drawing.Font("Corbel Light", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblNomeCadastro.Location = new System.Drawing.Point(3, 13);
            this.LblNomeCadastro.Name = "LblNomeCadastro";
            this.LblNomeCadastro.Size = new System.Drawing.Size(127, 26);
            this.LblNomeCadastro.TabIndex = 0;
            this.LblNomeCadastro.Text = "Digite o nome:";
            // 
            // TXTNomeCadastro
            // 
            this.TXTNomeCadastro.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXTNomeCadastro.Location = new System.Drawing.Point(6, 42);
            this.TXTNomeCadastro.Name = "TXTNomeCadastro";
            this.TXTNomeCadastro.Size = new System.Drawing.Size(262, 27);
            this.TXTNomeCadastro.TabIndex = 1;
            // 
            // TxtSenha
            // 
            this.TxtSenha.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtSenha.Location = new System.Drawing.Point(6, 111);
            this.TxtSenha.Name = "TxtSenha";
            this.TxtSenha.Size = new System.Drawing.Size(262, 27);
            this.TxtSenha.TabIndex = 3;
            this.TxtSenha.UseSystemPasswordChar = true;
            // 
            // LblSenhaCadastro
            // 
            this.LblSenhaCadastro.AutoSize = true;
            this.LblSenhaCadastro.Font = new System.Drawing.Font("Corbel Light", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblSenhaCadastro.Location = new System.Drawing.Point(5, 82);
            this.LblSenhaCadastro.Name = "LblSenhaCadastro";
            this.LblSenhaCadastro.Size = new System.Drawing.Size(134, 26);
            this.LblSenhaCadastro.TabIndex = 2;
            this.LblSenhaCadastro.Text = "Digite a senha: ";
            // 
            // BtnCadastrar
            // 
            this.BtnCadastrar.Font = new System.Drawing.Font("Corbel Light", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCadastrar.Location = new System.Drawing.Point(87, 144);
            this.BtnCadastrar.Name = "BtnCadastrar";
            this.BtnCadastrar.Size = new System.Drawing.Size(122, 51);
            this.BtnCadastrar.TabIndex = 4;
            this.BtnCadastrar.Text = "Cadastrar";
            this.BtnCadastrar.UseVisualStyleBackColor = true;
            this.BtnCadastrar.Click += new System.EventHandler(this.BtnCadastrar_Click);
            // 
            // MostraSenha
            // 
            this.MostraSenha.AutoSize = true;
            this.MostraSenha.Checked = true;
            this.MostraSenha.CheckState = System.Windows.Forms.CheckState.Checked;
            this.MostraSenha.Location = new System.Drawing.Point(274, 117);
            this.MostraSenha.Name = "MostraSenha";
            this.MostraSenha.Size = new System.Drawing.Size(15, 14);
            this.MostraSenha.TabIndex = 5;
            this.MostraSenha.UseVisualStyleBackColor = true;
            this.MostraSenha.Click += new System.EventHandler(this.MostraSenha_Click);
            // 
            // BtnVoltaLogin
            // 
            this.BtnVoltaLogin.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnVoltaLogin.Location = new System.Drawing.Point(205, 3);
            this.BtnVoltaLogin.Name = "BtnVoltaLogin";
            this.BtnVoltaLogin.Size = new System.Drawing.Size(75, 33);
            this.BtnVoltaLogin.TabIndex = 6;
            this.BtnVoltaLogin.Text = "Logar";
            this.BtnVoltaLogin.UseVisualStyleBackColor = true;
            this.BtnVoltaLogin.Click += new System.EventHandler(this.BtnVoltaLogin_Click);
            // 
            // TelaCadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 204);
            this.Controls.Add(this.BtnVoltaLogin);
            this.Controls.Add(this.MostraSenha);
            this.Controls.Add(this.BtnCadastrar);
            this.Controls.Add(this.TxtSenha);
            this.Controls.Add(this.LblSenhaCadastro);
            this.Controls.Add(this.TXTNomeCadastro);
            this.Controls.Add(this.LblNomeCadastro);
            this.Name = "TelaCadastro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TelaCadastro";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblNomeCadastro;
        private System.Windows.Forms.TextBox TXTNomeCadastro;
        private System.Windows.Forms.TextBox TxtSenha;
        private System.Windows.Forms.Label LblSenhaCadastro;
        private System.Windows.Forms.Button BtnCadastrar;
        private System.Windows.Forms.CheckBox MostraSenha;
        private System.Windows.Forms.Button BtnVoltaLogin;
    }
}