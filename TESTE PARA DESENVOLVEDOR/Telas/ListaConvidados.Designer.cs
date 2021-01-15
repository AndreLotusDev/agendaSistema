
namespace TESTE_PARA_DESENVOLVEDOR.Telas
{
    partial class ListaConvidados
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
            this.gpbx = new System.Windows.Forms.GroupBox();
            this.DgViewConvidados = new System.Windows.Forms.DataGridView();
            this.NomeDoConvidado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BtnSalvarConvidados = new System.Windows.Forms.Button();
            this.gpbx.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgViewConvidados)).BeginInit();
            this.SuspendLayout();
            // 
            // gpbx
            // 
            this.gpbx.Controls.Add(this.BtnSalvarConvidados);
            this.gpbx.Controls.Add(this.DgViewConvidados);
            this.gpbx.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbx.Location = new System.Drawing.Point(13, 13);
            this.gpbx.Name = "gpbx";
            this.gpbx.Size = new System.Drawing.Size(333, 425);
            this.gpbx.TabIndex = 0;
            this.gpbx.TabStop = false;
            this.gpbx.Text = "Lista de convidados";
            // 
            // DgViewConvidados
            // 
            this.DgViewConvidados.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.DgViewConvidados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgViewConvidados.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NomeDoConvidado});
            this.DgViewConvidados.GridColor = System.Drawing.SystemColors.ControlLight;
            this.DgViewConvidados.Location = new System.Drawing.Point(7, 27);
            this.DgViewConvidados.Name = "DgViewConvidados";
            this.DgViewConvidados.Size = new System.Drawing.Size(320, 301);
            this.DgViewConvidados.TabIndex = 0;
            this.DgViewConvidados.Enter += new System.EventHandler(this.DgViewConvidados_Enter);
            this.DgViewConvidados.KeyUp += new System.Windows.Forms.KeyEventHandler(this.DgViewConvidados_KeyUp);
            // 
            // NomeDoConvidado
            // 
            this.NomeDoConvidado.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.NomeDoConvidado.HeaderText = "Nome do convidado";
            this.NomeDoConvidado.Name = "NomeDoConvidado";
            this.NomeDoConvidado.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // BtnSalvarConvidados
            // 
            this.BtnSalvarConvidados.Location = new System.Drawing.Point(7, 335);
            this.BtnSalvarConvidados.Name = "BtnSalvarConvidados";
            this.BtnSalvarConvidados.Size = new System.Drawing.Size(320, 84);
            this.BtnSalvarConvidados.TabIndex = 1;
            this.BtnSalvarConvidados.Text = "Salvar";
            this.BtnSalvarConvidados.UseVisualStyleBackColor = true;
            this.BtnSalvarConvidados.Click += new System.EventHandler(this.BtnSalvarConvidados_Click);
            // 
            // ListaConvidados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(372, 450);
            this.Controls.Add(this.gpbx);
            this.Name = "ListaConvidados";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ListaConvidados";
            this.gpbx.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DgViewConvidados)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gpbx;
        private System.Windows.Forms.DataGridView DgViewConvidados;
        private System.Windows.Forms.DataGridViewTextBoxColumn NomeDoConvidado;
        private System.Windows.Forms.Button BtnSalvarConvidados;
    }
}