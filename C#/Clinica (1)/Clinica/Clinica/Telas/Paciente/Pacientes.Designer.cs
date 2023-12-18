namespace Clinica
{
    partial class Pacientes
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
            this.codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cpf = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.doenca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.filtrarBtn = new System.Windows.Forms.Button();
            this.filtroValor = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.editarBtn = new System.Windows.Forms.Button();
            this.deletarBtn = new System.Windows.Forms.Button();
            this.novoBtn = new System.Windows.Forms.Button();
            this.voltarBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.listagem)).BeginInit();
            this.SuspendLayout();
            // 
            // listagem
            // 
            this.listagem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.listagem.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codigo,
            this.nome,
            this.idade,
            this.cidade,
            this.cpf,
            this.doenca});
            this.listagem.Location = new System.Drawing.Point(12, 135);
            this.listagem.Name = "listagem";
            this.listagem.Size = new System.Drawing.Size(642, 209);
            this.listagem.TabIndex = 0;
            // 
            // codigo
            // 
            this.codigo.Frozen = true;
            this.codigo.HeaderText = "codigo";
            this.codigo.Name = "codigo";
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
            // cidade
            // 
            this.cidade.Frozen = true;
            this.cidade.HeaderText = "cidade";
            this.cidade.Name = "cidade";
            // 
            // cpf
            // 
            this.cpf.Frozen = true;
            this.cpf.HeaderText = "cpf";
            this.cpf.Name = "cpf";
            // 
            // doenca
            // 
            this.doenca.Frozen = true;
            this.doenca.HeaderText = "doenca";
            this.doenca.Name = "doenca";
            // 
            // filtrarBtn
            // 
            this.filtrarBtn.Location = new System.Drawing.Point(275, 109);
            this.filtrarBtn.Name = "filtrarBtn";
            this.filtrarBtn.Size = new System.Drawing.Size(75, 23);
            this.filtrarBtn.TabIndex = 1;
            this.filtrarBtn.Text = "Filtrar";
            this.filtrarBtn.UseVisualStyleBackColor = true;
            // 
            // filtroValor
            // 
            this.filtroValor.Location = new System.Drawing.Point(69, 111);
            this.filtroValor.Name = "filtroValor";
            this.filtroValor.Size = new System.Drawing.Size(200, 20);
            this.filtroValor.TabIndex = 2;
            this.filtroValor.TextChanged += new System.EventHandler(this.filtroValor_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.label1.Location = new System.Drawing.Point(12, 112);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Nome";
            // 
            // editarBtn
            // 
            this.editarBtn.Location = new System.Drawing.Point(93, 350);
            this.editarBtn.Name = "editarBtn";
            this.editarBtn.Size = new System.Drawing.Size(75, 23);
            this.editarBtn.TabIndex = 4;
            this.editarBtn.Text = "Editar";
            this.editarBtn.UseVisualStyleBackColor = true;
            this.editarBtn.Click += new System.EventHandler(this.editarBtn_Click);
            // 
            // deletarBtn
            // 
            this.deletarBtn.Location = new System.Drawing.Point(174, 350);
            this.deletarBtn.Name = "deletarBtn";
            this.deletarBtn.Size = new System.Drawing.Size(75, 23);
            this.deletarBtn.TabIndex = 5;
            this.deletarBtn.Text = "Deletar";
            this.deletarBtn.UseVisualStyleBackColor = true;
            this.deletarBtn.Click += new System.EventHandler(this.deletarBtn_Click);
            // 
            // novoBtn
            // 
            this.novoBtn.Location = new System.Drawing.Point(12, 350);
            this.novoBtn.Name = "novoBtn";
            this.novoBtn.Size = new System.Drawing.Size(75, 23);
            this.novoBtn.TabIndex = 6;
            this.novoBtn.Text = "Novo";
            this.novoBtn.UseVisualStyleBackColor = true;
            this.novoBtn.Click += new System.EventHandler(this.novoBtn_Click);
            // 
            // voltarBtn
            // 
            this.voltarBtn.Location = new System.Drawing.Point(12, 12);
            this.voltarBtn.Name = "voltarBtn";
            this.voltarBtn.Size = new System.Drawing.Size(75, 23);
            this.voltarBtn.TabIndex = 7;
            this.voltarBtn.Text = "Voltar";
            this.voltarBtn.UseVisualStyleBackColor = true;
            this.voltarBtn.Click += new System.EventHandler(this.voltarBtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Javanese Text", 32.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(142, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(398, 98);
            this.label2.TabIndex = 8;
            this.label2.Text = "Lista de Pacientes";
            // 
            // Pacientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkCyan;
            this.ClientSize = new System.Drawing.Size(663, 384);
            this.Controls.Add(this.voltarBtn);
            this.Controls.Add(this.novoBtn);
            this.Controls.Add(this.deletarBtn);
            this.Controls.Add(this.editarBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.filtroValor);
            this.Controls.Add(this.filtrarBtn);
            this.Controls.Add(this.listagem);
            this.Controls.Add(this.label2);
            this.Name = "Pacientes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Pacientes";
            this.Load += new System.EventHandler(this.Pacientes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.listagem)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView listagem;
        private System.Windows.Forms.Button filtrarBtn;
        private System.Windows.Forms.TextBox filtroValor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button editarBtn;
        private System.Windows.Forms.Button deletarBtn;
        private System.Windows.Forms.Button novoBtn;
        private System.Windows.Forms.Button voltarBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn idade;
        private System.Windows.Forms.DataGridViewTextBoxColumn cidade;
        private System.Windows.Forms.DataGridViewTextBoxColumn cpf;
        private System.Windows.Forms.DataGridViewTextBoxColumn doenca;
    }
}