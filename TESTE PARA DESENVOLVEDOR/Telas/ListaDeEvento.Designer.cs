
namespace TESTE_PARA_DESENVOLVEDOR.Telas
{
    partial class ListaDeEventos
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.DataEventos = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EventoLocal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EventoNome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataInicio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HorarioFim = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Editar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Excluir = new System.Windows.Forms.DataGridViewButtonColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataEventos)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.DataEventos);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(775, 425);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Eventos";
            // 
            // DataEventos
            // 
            this.DataEventos.AllowUserToAddRows = false;
            this.DataEventos.AllowUserToDeleteRows = false;
            this.DataEventos.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.DataEventos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataEventos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.EventoLocal,
            this.EventoNome,
            this.DataInicio,
            this.HorarioFim,
            this.Editar,
            this.Excluir});
            this.DataEventos.GridColor = System.Drawing.SystemColors.ButtonFace;
            this.DataEventos.Location = new System.Drawing.Point(6, 16);
            this.DataEventos.Name = "DataEventos";
            this.DataEventos.ReadOnly = true;
            this.DataEventos.Size = new System.Drawing.Size(757, 409);
            this.DataEventos.TabIndex = 0;
            this.DataEventos.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DataEventos_CellMouseClick);
            // 
            // Id
            // 
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            // 
            // EventoLocal
            // 
            this.EventoLocal.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.EventoLocal.HeaderText = "Local";
            this.EventoLocal.Name = "EventoLocal";
            this.EventoLocal.ReadOnly = true;
            // 
            // EventoNome
            // 
            this.EventoNome.HeaderText = "Nome";
            this.EventoNome.Name = "EventoNome";
            this.EventoNome.ReadOnly = true;
            // 
            // DataInicio
            // 
            this.DataInicio.HeaderText = "Começo do evento";
            this.DataInicio.Name = "DataInicio";
            this.DataInicio.ReadOnly = true;
            // 
            // HorarioFim
            // 
            this.HorarioFim.HeaderText = "Fim do evento";
            this.HorarioFim.Name = "HorarioFim";
            this.HorarioFim.ReadOnly = true;
            // 
            // Editar
            // 
            this.Editar.HeaderText = "Editar";
            this.Editar.Name = "Editar";
            this.Editar.ReadOnly = true;
            // 
            // Excluir
            // 
            this.Excluir.HeaderText = "Excluir";
            this.Excluir.Name = "Excluir";
            this.Excluir.ReadOnly = true;
            // 
            // ListaDeEventos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Name = "ListaDeEventos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lista de eventos";
            this.Load += new System.EventHandler(this.ListaDeEventos_Load);
            this.Enter += new System.EventHandler(this.ListaDeEventos_Enter);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DataEventos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView DataEventos;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn EventoLocal;
        private System.Windows.Forms.DataGridViewTextBoxColumn EventoNome;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataInicio;
        private System.Windows.Forms.DataGridViewTextBoxColumn HorarioFim;
        private System.Windows.Forms.DataGridViewButtonColumn Editar;
        private System.Windows.Forms.DataGridViewButtonColumn Excluir;
    }
}