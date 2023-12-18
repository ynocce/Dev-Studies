namespace Clinica
{
    partial class Medicos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose (bool disposing)
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
        private void InitializeComponent ()
        {
            this.voltarBtn = new System.Windows.Forms.Button();
            this.buscaValor = new System.Windows.Forms.TextBox();
            this.filrarBtn = new System.Windows.Forms.Button();
            this.listagem = new System.Windows.Forms.DataGridView();
            this.novoBtn = new System.Windows.Forms.Button();
            this.deletarBtn = new System.Windows.Forms.Button();
            this.editarBtn = new System.Windows.Forms.Button();
            this.filtroLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Especialidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cpf = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ambulatorio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.listagem)).BeginInit();
            this.SuspendLayout();
            // 
            // voltarBtn
            // 
            this.voltarBtn.Location = new System.Drawing.Point(12, 12);
            this.voltarBtn.Name = "voltarBtn";
            this.voltarBtn.Size = new System.Drawing.Size(75, 23);
            this.voltarBtn.TabIndex = 0;
            this.voltarBtn.Text = "Voltar";
            this.voltarBtn.UseVisualStyleBackColor = true;
            this.voltarBtn.Click += new System.EventHandler(this.voltarBtn_Click);
            // 
            // buscaValor
            // 
            this.buscaValor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.buscaValor.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buscaValor.Location = new System.Drawing.Point(498, 96);
            this.buscaValor.Name = "buscaValor";
            this.buscaValor.Size = new System.Drawing.Size(200, 20);
            this.buscaValor.TabIndex = 2;
            this.buscaValor.TextChanged += new System.EventHandler(this.buscaValor_TextChanged);
            // 
            // filrarBtn
            // 
            this.filrarBtn.Location = new System.Drawing.Point(704, 96);
            this.filrarBtn.Name = "filrarBtn";
            this.filrarBtn.Size = new System.Drawing.Size(75, 23);
            this.filrarBtn.TabIndex = 3;
            this.filrarBtn.Text = "Filtrar";
            this.filrarBtn.UseVisualStyleBackColor = true;
            this.filrarBtn.Click += new System.EventHandler(this.filrarBtn_Click);
            // 
            // listagem
            // 
            this.listagem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.listagem.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Codigo,
            this.Nome,
            this.idade,
            this.Especialidade,
            this.cpf,
            this.cidade,
            this.ambulatorio});
            this.listagem.Location = new System.Drawing.Point(36, 125);
            this.listagem.Name = "listagem";
            this.listagem.Size = new System.Drawing.Size(743, 249);
            this.listagem.TabIndex = 4;
            // 
            // novoBtn
            // 
            this.novoBtn.Location = new System.Drawing.Point(36, 380);
            this.novoBtn.Name = "novoBtn";
            this.novoBtn.Size = new System.Drawing.Size(75, 23);
            this.novoBtn.TabIndex = 9;
            this.novoBtn.Text = "Novo";
            this.novoBtn.UseVisualStyleBackColor = true;
            this.novoBtn.Click += new System.EventHandler(this.novoBtn_Click);
            // 
            // deletarBtn
            // 
            this.deletarBtn.Location = new System.Drawing.Point(198, 380);
            this.deletarBtn.Name = "deletarBtn";
            this.deletarBtn.Size = new System.Drawing.Size(75, 23);
            this.deletarBtn.TabIndex = 8;
            this.deletarBtn.Text = "Deletar";
            this.deletarBtn.UseVisualStyleBackColor = true;
            // 
            // editarBtn
            // 
            this.editarBtn.Location = new System.Drawing.Point(117, 380);
            this.editarBtn.Name = "editarBtn";
            this.editarBtn.Size = new System.Drawing.Size(75, 23);
            this.editarBtn.TabIndex = 7;
            this.editarBtn.Text = "Editar";
            this.editarBtn.UseVisualStyleBackColor = true;
            // 
            // filtroLabel
            // 
            this.filtroLabel.AutoSize = true;
            this.filtroLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.filtroLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.filtroLabel.Location = new System.Drawing.Point(441, 96);
            this.filtroLabel.Name = "filtroLabel";
            this.filtroLabel.Size = new System.Drawing.Size(51, 20);
            this.filtroLabel.TabIndex = 10;
            this.filtroLabel.Text = "Nome";
            this.filtroLabel.Click += new System.EventHandler(this.filtroLabel_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Ink Free", 32F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(163)))), ((int)(((byte)(17)))));
            this.label1.Location = new System.Drawing.Point(328, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 53);
            this.label1.TabIndex = 11;
            this.label1.Text = "Médicos";
            // 
            // Codigo
            // 
            this.Codigo.Frozen = true;
            this.Codigo.HeaderText = "Codigo";
            this.Codigo.Name = "Codigo";
            this.Codigo.ReadOnly = true;
            // 
            // Nome
            // 
            this.Nome.Frozen = true;
            this.Nome.HeaderText = "Nome";
            this.Nome.Name = "Nome";
            // 
            // idade
            // 
            this.idade.Frozen = true;
            this.idade.HeaderText = "idade";
            this.idade.Name = "idade";
            // 
            // Especialidade
            // 
            this.Especialidade.Frozen = true;
            this.Especialidade.HeaderText = "Especialidade";
            this.Especialidade.Name = "Especialidade";
            // 
            // cpf
            // 
            this.cpf.Frozen = true;
            this.cpf.HeaderText = "cpf";
            this.cpf.Name = "cpf";
            // 
            // cidade
            // 
            this.cidade.Frozen = true;
            this.cidade.HeaderText = "cidade";
            this.cidade.Name = "cidade";
            // 
            // ambulatorio
            // 
            this.ambulatorio.Frozen = true;
            this.ambulatorio.HeaderText = "ambulatorio";
            this.ambulatorio.Name = "ambulatorio";
            // 
            // Medicos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(33)))), ((int)(((byte)(61)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.filtroLabel);
            this.Controls.Add(this.novoBtn);
            this.Controls.Add(this.deletarBtn);
            this.Controls.Add(this.editarBtn);
            this.Controls.Add(this.listagem);
            this.Controls.Add(this.filrarBtn);
            this.Controls.Add(this.buscaValor);
            this.Controls.Add(this.voltarBtn);
            this.Name = "Medicos";
            this.Text = "Medicos";
            this.Load += new System.EventHandler(this.Medicos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.listagem)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button voltarBtn;
        private System.Windows.Forms.TextBox buscaValor;
        private System.Windows.Forms.Button filrarBtn;
        private System.Windows.Forms.DataGridView listagem;
        private System.Windows.Forms.Button novoBtn;
        private System.Windows.Forms.Button deletarBtn;
        private System.Windows.Forms.Button editarBtn;
        private System.Windows.Forms.Label filtroLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn idade;
        private System.Windows.Forms.DataGridViewTextBoxColumn Especialidade;
        private System.Windows.Forms.DataGridViewTextBoxColumn cpf;
        private System.Windows.Forms.DataGridViewTextBoxColumn cidade;
        private System.Windows.Forms.DataGridViewTextBoxColumn ambulatorio;
    }
}