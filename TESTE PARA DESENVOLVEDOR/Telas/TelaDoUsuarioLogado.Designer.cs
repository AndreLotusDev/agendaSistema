
namespace TESTE_PARA_DESENVOLVEDOR.Telas
{
    partial class TelaDoUsuarioLogado
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
            this.Lbl_ = new System.Windows.Forms.Label();
            this.LblNome = new System.Windows.Forms.Label();
            this.GBoxFuncoes = new System.Windows.Forms.GroupBox();
            this.BtnCriarNovoEvento = new System.Windows.Forms.Button();
            this.BtnAtivarEvento = new System.Windows.Forms.Button();
            this.BtnVisualizarEvento = new System.Windows.Forms.Button();
            this.BtnLogout = new System.Windows.Forms.Button();
            this.GBoxFuncoes.SuspendLayout();
            this.SuspendLayout();
            // 
            // Lbl_
            // 
            this.Lbl_.AutoSize = true;
            this.Lbl_.Font = new System.Drawing.Font("Corbel Light", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_.Location = new System.Drawing.Point(13, 13);
            this.Lbl_.Name = "Lbl_";
            this.Lbl_.Size = new System.Drawing.Size(70, 26);
            this.Lbl_.TabIndex = 0;
            this.Lbl_.Text = "Nome: ";
            // 
            // LblNome
            // 
            this.LblNome.AutoSize = true;
            this.LblNome.Font = new System.Drawing.Font("Corbel Light", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblNome.Location = new System.Drawing.Point(74, 13);
            this.LblNome.Name = "LblNome";
            this.LblNome.Size = new System.Drawing.Size(0, 26);
            this.LblNome.TabIndex = 1;
            // 
            // GBoxFuncoes
            // 
            this.GBoxFuncoes.Controls.Add(this.BtnCriarNovoEvento);
            this.GBoxFuncoes.Controls.Add(this.BtnAtivarEvento);
            this.GBoxFuncoes.Controls.Add(this.BtnVisualizarEvento);
            this.GBoxFuncoes.Font = new System.Drawing.Font("Corbel Light", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GBoxFuncoes.Location = new System.Drawing.Point(18, 54);
            this.GBoxFuncoes.Name = "GBoxFuncoes";
            this.GBoxFuncoes.Size = new System.Drawing.Size(200, 225);
            this.GBoxFuncoes.TabIndex = 2;
            this.GBoxFuncoes.TabStop = false;
            this.GBoxFuncoes.Text = "Funções";
            // 
            // BtnCriarNovoEvento
            // 
            this.BtnCriarNovoEvento.Location = new System.Drawing.Point(6, 145);
            this.BtnCriarNovoEvento.Name = "BtnCriarNovoEvento";
            this.BtnCriarNovoEvento.Size = new System.Drawing.Size(188, 57);
            this.BtnCriarNovoEvento.TabIndex = 2;
            this.BtnCriarNovoEvento.Text = "Criar novo evento";
            this.BtnCriarNovoEvento.UseVisualStyleBackColor = true;
            this.BtnCriarNovoEvento.Click += new System.EventHandler(this.BtnCriarNovoEvento_Click);
            // 
            // BtnAtivarEvento
            // 
            this.BtnAtivarEvento.Location = new System.Drawing.Point(6, 82);
            this.BtnAtivarEvento.Name = "BtnAtivarEvento";
            this.BtnAtivarEvento.Size = new System.Drawing.Size(188, 57);
            this.BtnAtivarEvento.TabIndex = 1;
            this.BtnAtivarEvento.Text = "Ativar Eventos";
            this.BtnAtivarEvento.UseVisualStyleBackColor = true;
            // 
            // BtnVisualizarEvento
            // 
            this.BtnVisualizarEvento.Location = new System.Drawing.Point(6, 19);
            this.BtnVisualizarEvento.Name = "BtnVisualizarEvento";
            this.BtnVisualizarEvento.Size = new System.Drawing.Size(188, 57);
            this.BtnVisualizarEvento.TabIndex = 0;
            this.BtnVisualizarEvento.Text = "Visualizar Eventos";
            this.BtnVisualizarEvento.UseVisualStyleBackColor = true;
            this.BtnVisualizarEvento.Click += new System.EventHandler(this.BtnVisualizarEvento_Click);
            // 
            // BtnLogout
            // 
            this.BtnLogout.Location = new System.Drawing.Point(196, 10);
            this.BtnLogout.Name = "BtnLogout";
            this.BtnLogout.Size = new System.Drawing.Size(50, 36);
            this.BtnLogout.TabIndex = 3;
            this.BtnLogout.Text = "X";
            this.BtnLogout.UseVisualStyleBackColor = true;
            this.BtnLogout.Click += new System.EventHandler(this.BtnLogout_Click);
            // 
            // TelaDoUsuarioLogado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(258, 296);
            this.Controls.Add(this.BtnLogout);
            this.Controls.Add(this.GBoxFuncoes);
            this.Controls.Add(this.LblNome);
            this.Controls.Add(this.Lbl_);
            this.Name = "TelaDoUsuarioLogado";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Agenda Pessoal ";
            this.Activated += new System.EventHandler(this.TelaDoUsuarioLogado_Activated);
            this.GBoxFuncoes.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Lbl_;
        private System.Windows.Forms.Label LblNome;
        private System.Windows.Forms.GroupBox GBoxFuncoes;
        private System.Windows.Forms.Button BtnCriarNovoEvento;
        private System.Windows.Forms.Button BtnAtivarEvento;
        private System.Windows.Forms.Button BtnVisualizarEvento;
        private System.Windows.Forms.Button BtnLogout;
    }
}