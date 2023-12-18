namespace Clinica
{
    partial class Consultas
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.listagem = new System.Windows.Forms.DataGridView();
            this.codm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.data = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hora = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.voltarBtn = new System.Windows.Forms.Button();
            this.buscaBtn = new System.Windows.Forms.Button();
            this.novaBtn = new System.Windows.Forms.Button();
            this.editarBtn = new System.Windows.Forms.Button();
            this.deletarBtn = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.listagem)).BeginInit();
            this.SuspendLayout();
            // 
            // listagem
            // 
            this.listagem.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(201)))), ((int)(((byte)(115)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(163)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.listagem.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.listagem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.listagem.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codm,
            this.codp,
            this.data,
            this.hora});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(201)))), ((int)(((byte)(115)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(163)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.listagem.DefaultCellStyle = dataGridViewCellStyle2;
            this.listagem.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.listagem.Location = new System.Drawing.Point(186, 149);
            this.listagem.Name = "listagem";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.listagem.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.listagem.Size = new System.Drawing.Size(443, 249);
            this.listagem.TabIndex = 0;
            // 
            // codm
            // 
            this.codm.Frozen = true;
            this.codm.HeaderText = "codm";
            this.codm.Name = "codm";
            // 
            // codp
            // 
            this.codp.Frozen = true;
            this.codp.HeaderText = "codp";
            this.codp.Name = "codp";
            // 
            // data
            // 
            this.data.Frozen = true;
            this.data.HeaderText = "data";
            this.data.Name = "data";
            // 
            // hora
            // 
            this.hora.Frozen = true;
            this.hora.HeaderText = "hora";
            this.hora.Name = "hora";
            // 
            // voltarBtn
            // 
            this.voltarBtn.Location = new System.Drawing.Point(12, 12);
            this.voltarBtn.Name = "voltarBtn";
            this.voltarBtn.Size = new System.Drawing.Size(75, 23);
            this.voltarBtn.TabIndex = 1;
            this.voltarBtn.Text = "Voltar";
            this.voltarBtn.UseVisualStyleBackColor = true;
            this.voltarBtn.Click += new System.EventHandler(this.voltarBtn_Click);
            // 
            // buscaBtn
            // 
            this.buscaBtn.Location = new System.Drawing.Point(554, 114);
            this.buscaBtn.Name = "buscaBtn";
            this.buscaBtn.Size = new System.Drawing.Size(75, 23);
            this.buscaBtn.TabIndex = 2;
            this.buscaBtn.Text = "Filtrar";
            this.buscaBtn.UseVisualStyleBackColor = true;
            this.buscaBtn.Click += new System.EventHandler(this.buscaBtn_Click);
            // 
            // novaBtn
            // 
            this.novaBtn.Location = new System.Drawing.Point(186, 404);
            this.novaBtn.Name = "novaBtn";
            this.novaBtn.Size = new System.Drawing.Size(75, 23);
            this.novaBtn.TabIndex = 3;
            this.novaBtn.Text = "Nova";
            this.novaBtn.UseVisualStyleBackColor = true;
            this.novaBtn.Click += new System.EventHandler(this.novaBtn_Click);
            // 
            // editarBtn
            // 
            this.editarBtn.Location = new System.Drawing.Point(267, 404);
            this.editarBtn.Name = "editarBtn";
            this.editarBtn.Size = new System.Drawing.Size(75, 23);
            this.editarBtn.TabIndex = 4;
            this.editarBtn.Text = "Editar";
            this.editarBtn.UseVisualStyleBackColor = true;
            // 
            // deletarBtn
            // 
            this.deletarBtn.Location = new System.Drawing.Point(348, 404);
            this.deletarBtn.Name = "deletarBtn";
            this.deletarBtn.Size = new System.Drawing.Size(75, 23);
            this.deletarBtn.TabIndex = 5;
            this.deletarBtn.Text = "Deletar";
            this.deletarBtn.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(348, 116);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(200, 20);
            this.textBox1.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Ink Free", 32F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(163)))), ((int)(((byte)(17)))));
            this.label1.Location = new System.Drawing.Point(309, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(197, 53);
            this.label1.TabIndex = 7;
            this.label1.Text = "Consultas";
            // 
            // Consultas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(33)))), ((int)(((byte)(61)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.deletarBtn);
            this.Controls.Add(this.editarBtn);
            this.Controls.Add(this.novaBtn);
            this.Controls.Add(this.buscaBtn);
            this.Controls.Add(this.voltarBtn);
            this.Controls.Add(this.listagem);
            this.Name = "Consultas";
            this.Text = "Consultas";
            this.Load += new System.EventHandler(this.Consultas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.listagem)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView listagem;
        private System.Windows.Forms.DataGridViewTextBoxColumn codm;
        private System.Windows.Forms.DataGridViewTextBoxColumn codp;
        private System.Windows.Forms.DataGridViewTextBoxColumn data;
        private System.Windows.Forms.DataGridViewTextBoxColumn hora;
        private System.Windows.Forms.Button voltarBtn;
        private System.Windows.Forms.Button buscaBtn;
        private System.Windows.Forms.Button novaBtn;
        private System.Windows.Forms.Button editarBtn;
        private System.Windows.Forms.Button deletarBtn;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
    }
}