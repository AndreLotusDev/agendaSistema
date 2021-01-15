
namespace TESTE_PARA_DESENVOLVEDOR.Telas
{
    partial class ListDeUsuariosAConvidar
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
            this.gpBoxUsuarios = new System.Windows.Forms.GroupBox();
            this.dataGridUsuarios = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Selecionar = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.btnSalvarLista = new System.Windows.Forms.Button();
            this.gpBoxUsuarios.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridUsuarios)).BeginInit();
            this.SuspendLayout();
            // 
            // gpBoxUsuarios
            // 
            this.gpBoxUsuarios.Controls.Add(this.btnSalvarLista);
            this.gpBoxUsuarios.Controls.Add(this.dataGridUsuarios);
            this.gpBoxUsuarios.Location = new System.Drawing.Point(12, 12);
            this.gpBoxUsuarios.Name = "gpBoxUsuarios";
            this.gpBoxUsuarios.Size = new System.Drawing.Size(776, 426);
            this.gpBoxUsuarios.TabIndex = 0;
            this.gpBoxUsuarios.TabStop = false;
            this.gpBoxUsuarios.Text = "Lista usuarios";
            // 
            // dataGridUsuarios
            // 
            this.dataGridUsuarios.AllowUserToAddRows = false;
            this.dataGridUsuarios.AllowUserToDeleteRows = false;
            this.dataGridUsuarios.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridUsuarios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Nome,
            this.Selecionar});
            this.dataGridUsuarios.Location = new System.Drawing.Point(3, 19);
            this.dataGridUsuarios.Name = "dataGridUsuarios";
            this.dataGridUsuarios.ReadOnly = true;
            this.dataGridUsuarios.Size = new System.Drawing.Size(770, 353);
            this.dataGridUsuarios.TabIndex = 0;
            // 
            // Id
            // 
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            // 
            // Nome
            // 
            this.Nome.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Nome.HeaderText = "Nome";
            this.Nome.Name = "Nome";
            this.Nome.ReadOnly = true;
            // 
            // Selecionar
            // 
            this.Selecionar.HeaderText = "Selecionar";
            this.Selecionar.Name = "Selecionar";
            this.Selecionar.ReadOnly = true;
            // 
            // btnSalvarLista
            // 
            this.btnSalvarLista.Location = new System.Drawing.Point(317, 378);
            this.btnSalvarLista.Name = "btnSalvarLista";
            this.btnSalvarLista.Size = new System.Drawing.Size(161, 42);
            this.btnSalvarLista.TabIndex = 1;
            this.btnSalvarLista.Text = "Salvar lista";
            this.btnSalvarLista.UseVisualStyleBackColor = true;
            // 
            // ListDeUsuariosAConvidar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gpBoxUsuarios);
            this.Name = "ListDeUsuariosAConvidar";
            this.Text = "Convidar usuarios";
            this.Load += new System.EventHandler(this.listDeUsuariosAConvidar_Load);
            this.gpBoxUsuarios.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridUsuarios)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gpBoxUsuarios;
        private System.Windows.Forms.DataGridView dataGridUsuarios;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nome;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Selecionar;
        private System.Windows.Forms.Button btnSalvarLista;
    }
}