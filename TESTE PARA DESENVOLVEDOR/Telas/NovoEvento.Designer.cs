
namespace TESTE_PARA_DESENVOLVEDOR.Telas
{
    partial class NovoEvento
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
            this.TxtEventoNome = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.TxtEventoLocal = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.TxtDescricao = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.RBtnCompartilhado = new System.Windows.Forms.RadioButton();
            this.RBtnExclusivo = new System.Windows.Forms.RadioButton();
            this.btnOutrosUsuarios = new System.Windows.Forms.Button();
            this.BtnConvidados = new System.Windows.Forms.Button();
            this.BtnSalvarEvento = new System.Windows.Forms.Button();
            this.DataComeco = new System.Windows.Forms.DateTimePicker();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.DataFim = new System.Windows.Forms.DateTimePicker();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.TxtEventoNome);
            this.groupBox1.Font = new System.Drawing.Font("Corbel Light", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(271, 50);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Nome";
            // 
            // TxtEventoNome
            // 
            this.TxtEventoNome.Location = new System.Drawing.Point(6, 19);
            this.TxtEventoNome.Name = "TxtEventoNome";
            this.TxtEventoNome.Size = new System.Drawing.Size(255, 27);
            this.TxtEventoNome.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.TxtEventoLocal);
            this.groupBox2.Font = new System.Drawing.Font("Corbel Light", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(290, 13);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(498, 50);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Local";
            // 
            // TxtEventoLocal
            // 
            this.TxtEventoLocal.Location = new System.Drawing.Point(6, 19);
            this.TxtEventoLocal.Name = "TxtEventoLocal";
            this.TxtEventoLocal.Size = new System.Drawing.Size(486, 27);
            this.TxtEventoLocal.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.TxtDescricao);
            this.groupBox3.Font = new System.Drawing.Font("Corbel Light", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(12, 69);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(776, 241);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Descrição";
            // 
            // TxtDescricao
            // 
            this.TxtDescricao.Location = new System.Drawing.Point(6, 19);
            this.TxtDescricao.Multiline = true;
            this.TxtDescricao.Name = "TxtDescricao";
            this.TxtDescricao.Size = new System.Drawing.Size(764, 216);
            this.TxtDescricao.TabIndex = 0;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.RBtnCompartilhado);
            this.groupBox4.Controls.Add(this.RBtnExclusivo);
            this.groupBox4.Font = new System.Drawing.Font("Corbel Light", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(12, 316);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(140, 70);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Tipo";
            // 
            // RBtnCompartilhado
            // 
            this.RBtnCompartilhado.AutoSize = true;
            this.RBtnCompartilhado.Location = new System.Drawing.Point(5, 42);
            this.RBtnCompartilhado.Name = "RBtnCompartilhado";
            this.RBtnCompartilhado.Size = new System.Drawing.Size(118, 23);
            this.RBtnCompartilhado.TabIndex = 1;
            this.RBtnCompartilhado.Text = "Compartilhado";
            this.RBtnCompartilhado.UseVisualStyleBackColor = true;
            // 
            // RBtnExclusivo
            // 
            this.RBtnExclusivo.AutoSize = true;
            this.RBtnExclusivo.Checked = true;
            this.RBtnExclusivo.Location = new System.Drawing.Point(6, 19);
            this.RBtnExclusivo.Name = "RBtnExclusivo";
            this.RBtnExclusivo.Size = new System.Drawing.Size(83, 23);
            this.RBtnExclusivo.TabIndex = 0;
            this.RBtnExclusivo.TabStop = true;
            this.RBtnExclusivo.Text = "Exclusivo";
            this.RBtnExclusivo.UseVisualStyleBackColor = true;
            // 
            // btnOutrosUsuarios
            // 
            this.btnOutrosUsuarios.Font = new System.Drawing.Font("Corbel Light", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOutrosUsuarios.Location = new System.Drawing.Point(158, 327);
            this.btnOutrosUsuarios.Name = "btnOutrosUsuarios";
            this.btnOutrosUsuarios.Size = new System.Drawing.Size(164, 59);
            this.btnOutrosUsuarios.TabIndex = 4;
            this.btnOutrosUsuarios.Text = "Enviar evento a outro usuário";
            this.btnOutrosUsuarios.UseVisualStyleBackColor = true;
            this.btnOutrosUsuarios.Click += new System.EventHandler(this.btnOutrosUsuarios_Click);
            // 
            // BtnConvidados
            // 
            this.BtnConvidados.Font = new System.Drawing.Font("Corbel Light", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnConvidados.Location = new System.Drawing.Point(328, 327);
            this.BtnConvidados.Name = "BtnConvidados";
            this.BtnConvidados.Size = new System.Drawing.Size(164, 59);
            this.BtnConvidados.TabIndex = 5;
            this.BtnConvidados.Text = "Adicionar Lista de Convidados";
            this.BtnConvidados.UseVisualStyleBackColor = true;
            this.BtnConvidados.Click += new System.EventHandler(this.BtnConvidados_Click);
            // 
            // BtnSalvarEvento
            // 
            this.BtnSalvarEvento.Font = new System.Drawing.Font("Corbel Light", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSalvarEvento.Location = new System.Drawing.Point(498, 327);
            this.BtnSalvarEvento.Name = "BtnSalvarEvento";
            this.BtnSalvarEvento.Size = new System.Drawing.Size(164, 59);
            this.BtnSalvarEvento.TabIndex = 6;
            this.BtnSalvarEvento.Text = "Salvar Evento";
            this.BtnSalvarEvento.UseVisualStyleBackColor = true;
            this.BtnSalvarEvento.Click += new System.EventHandler(this.BtnSalvarEvento_Click);
            this.BtnSalvarEvento.Enter += new System.EventHandler(this.BtnSalvarEvento_Enter);
            // 
            // DataComeco
            // 
            this.DataComeco.CustomFormat = "HH:mm dd.MM.yyyy";
            this.DataComeco.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DataComeco.Location = new System.Drawing.Point(0, 19);
            this.DataComeco.Name = "DataComeco";
            this.DataComeco.Size = new System.Drawing.Size(200, 20);
            this.DataComeco.TabIndex = 7;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.DataComeco);
            this.groupBox5.Location = new System.Drawing.Point(13, 392);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(200, 57);
            this.groupBox5.TabIndex = 9;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Horario de entrada";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.DataFim);
            this.groupBox6.Location = new System.Drawing.Point(462, 392);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(200, 57);
            this.groupBox6.TabIndex = 10;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Horario de saida";
            // 
            // DataFim
            // 
            this.DataFim.CustomFormat = "HH:mm dd.MM.yyyy";
            this.DataFim.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DataFim.Location = new System.Drawing.Point(0, 19);
            this.DataFim.Name = "DataFim";
            this.DataFim.Size = new System.Drawing.Size(200, 20);
            this.DataFim.TabIndex = 7;
            // 
            // NovoEvento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.BtnSalvarEvento);
            this.Controls.Add(this.BtnConvidados);
            this.Controls.Add(this.btnOutrosUsuarios);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "NovoEvento";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NovoEvento";
            this.Load += new System.EventHandler(this.NovoEvento_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox TxtEventoNome;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox TxtEventoLocal;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox TxtDescricao;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.RadioButton RBtnCompartilhado;
        private System.Windows.Forms.RadioButton RBtnExclusivo;
        private System.Windows.Forms.Button btnOutrosUsuarios;
        private System.Windows.Forms.Button BtnConvidados;
        private System.Windows.Forms.Button BtnSalvarEvento;
        private System.Windows.Forms.DateTimePicker DataComeco;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.DateTimePicker DataFim;
    }
}