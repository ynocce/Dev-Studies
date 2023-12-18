namespace Clinica
{
    partial class Funcionarios
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
            this.listagem = new System.Windows.Forms.DataGridView();
            this.codf = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CPF = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.salario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cargo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.voltarBtn = new System.Windows.Forms.Button();
            this.filtrarBtn = new System.Windows.Forms.Button();
            this.buscaValor = new System.Windows.Forms.TextBox();
            this.buscarLabel = new System.Windows.Forms.Label();
            this.novoBtn = new System.Windows.Forms.Button();
            this.deletarBtn = new System.Windows.Forms.Button();
            this.editarBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.listagem)).BeginInit();
            this.SuspendLayout();
            // 
            // listagem
            // 
            this.listagem.BackgroundColor = System.Drawing.SystemColors.ActiveBorder;
            this.listagem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.listagem.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codf,
            this.nome,
            this.idade,
            this.CPF,
            this.cidade,
            this.salario,
            this.cargo});
            this.listagem.Location = new System.Drawing.Point(12, 116);
            this.listagem.Name = "listagem";
            this.listagem.Size = new System.Drawing.Size(742, 150);
            this.listagem.TabIndex = 1;
            this.listagem.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.listagem_CellContentClick);
            // 
            // codf
            // 
            this.codf.Frozen = true;
            this.codf.HeaderText = "codf";
            this.codf.Name = "codf";
            // 
            // nome
            // 
            this.nome.Frozen = true;
            this.nome.HeaderText = "nome";
            this.nome.Name = "nome";
            // 
            // idade
            // 
            this.idade.Frozen = true;
            this.idade.HeaderText = "idade";
            this.idade.Name = "idade";
            // 
            // CPF
            // 
            this.CPF.Frozen = true;
            this.CPF.HeaderText = "CPF";
            this.CPF.Name = "CPF";
            // 
            // cidade
            // 
            this.cidade.Frozen = true;
            this.cidade.HeaderText = "cidade";
            this.cidade.Name = "cidade";
            // 
            // salario
            // 
            this.salario.Frozen = true;
            this.salario.HeaderText = "salario";
            this.salario.Name = "salario";
            // 
            // cargo
            // 
            this.cargo.Frozen = true;
            this.cargo.HeaderText = "cargo";
            this.cargo.Name = "cargo";
            // 
            // voltarBtn
            // 
            this.voltarBtn.Location = new System.Drawing.Point(12, 12);
            this.voltarBtn.Name = "voltarBtn";
            this.voltarBtn.Size = new System.Drawing.Size(75, 23);
            this.voltarBtn.TabIndex = 2;
            this.voltarBtn.Text = "Voltar";
            this.voltarBtn.UseVisualStyleBackColor = true;
            this.voltarBtn.Click += new System.EventHandler(this.voltarBtn_Click);
            // 
            // filtrarBtn
            // 
            this.filtrarBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.filtrarBtn.Location = new System.Drawing.Point(275, 90);
            this.filtrarBtn.Name = "filtrarBtn";
            this.filtrarBtn.Size = new System.Drawing.Size(75, 23);
            this.filtrarBtn.TabIndex = 3;
            this.filtrarBtn.Text = "Filtrar";
            this.filtrarBtn.UseVisualStyleBackColor = true;
            // 
            // buscaValor
            // 
            this.buscaValor.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buscaValor.Location = new System.Drawing.Point(69, 93);
            this.buscaValor.Name = "buscaValor";
            this.buscaValor.Size = new System.Drawing.Size(200, 20);
            this.buscaValor.TabIndex = 4;
            // 
            // buscarLabel
            // 
            this.buscarLabel.AutoSize = true;
            this.buscarLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buscarLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.buscarLabel.Location = new System.Drawing.Point(12, 93);
            this.buscarLabel.Name = "buscarLabel";
            this.buscarLabel.Size = new System.Drawing.Size(51, 20);
            this.buscarLabel.TabIndex = 5;
            this.buscarLabel.Text = "Nome";
            // 
            // novoBtn
            // 
            this.novoBtn.Location = new System.Drawing.Point(12, 272);
            this.novoBtn.Name = "novoBtn";
            this.novoBtn.Size = new System.Drawing.Size(75, 23);
            this.novoBtn.TabIndex = 9;
            this.novoBtn.Text = "Novo";
            this.novoBtn.UseVisualStyleBackColor = true;
            this.novoBtn.Click += new System.EventHandler(this.novoBtn_Click);
            // 
            // deletarBtn
            // 
            this.deletarBtn.Location = new System.Drawing.Point(174, 272);
            this.deletarBtn.Name = "deletarBtn";
            this.deletarBtn.Size = new System.Drawing.Size(75, 23);
            this.deletarBtn.TabIndex = 8;
            this.deletarBtn.Text = "Deletar";
            this.deletarBtn.UseVisualStyleBackColor = true;
            // 
            // editarBtn
            // 
            this.editarBtn.Location = new System.Drawing.Point(93, 272);
            this.editarBtn.Name = "editarBtn";
            this.editarBtn.Size = new System.Drawing.Size(75, 23);
            this.editarBtn.TabIndex = 7;
            this.editarBtn.Text = "Editar";
            this.editarBtn.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Javanese Text", 32.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(275, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(294, 98);
            this.label1.TabIndex = 10;
            this.label1.Text = "Funcionários";
            // 
            // Funcionarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkCyan;
            this.ClientSize = new System.Drawing.Size(760, 310);
            this.Controls.Add(this.novoBtn);
            this.Controls.Add(this.deletarBtn);
            this.Controls.Add(this.editarBtn);
            this.Controls.Add(this.buscarLabel);
            this.Controls.Add(this.buscaValor);
            this.Controls.Add(this.filtrarBtn);
            this.Controls.Add(this.voltarBtn);
            this.Controls.Add(this.listagem);
            this.Controls.Add(this.label1);
            this.Name = "Funcionarios";
            this.Text = "Funcionarios";
            this.Load += new System.EventHandler(this.Funcionarios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.listagem)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView listagem;
        private System.Windows.Forms.Button voltarBtn;
        private System.Windows.Forms.Button filtrarBtn;
        private System.Windows.Forms.TextBox buscaValor;
        private System.Windows.Forms.Label buscarLabel;
        private System.Windows.Forms.Button novoBtn;
        private System.Windows.Forms.Button deletarBtn;
        private System.Windows.Forms.Button editarBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn codf;
        private System.Windows.Forms.DataGridViewTextBoxColumn nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn idade;
        private System.Windows.Forms.DataGridViewTextBoxColumn CPF;
        private System.Windows.Forms.DataGridViewTextBoxColumn cidade;
        private System.Windows.Forms.DataGridViewTextBoxColumn salario;
        private System.Windows.Forms.DataGridViewTextBoxColumn cargo;
    }
}