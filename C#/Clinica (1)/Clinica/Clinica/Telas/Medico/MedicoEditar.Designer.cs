namespace Clinica
{
    partial class MedicoEditar
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
            this.tituloLabel = new System.Windows.Forms.Label();
            this.salvarBtn = new System.Windows.Forms.Button();
            this.voltarBtn = new System.Windows.Forms.Button();
            this.nroaLabel = new System.Windows.Forms.Label();
            this.cidadeLabel = new System.Windows.Forms.Label();
            this.cpfLabel = new System.Windows.Forms.Label();
            this.especialidadeLabel = new System.Windows.Forms.Label();
            this.idadeLabel = new System.Windows.Forms.Label();
            this.nomeLabel = new System.Windows.Forms.Label();
            this.nomeValor = new System.Windows.Forms.TextBox();
            this.idadeValor = new System.Windows.Forms.TextBox();
            this.especialidadeValor = new System.Windows.Forms.TextBox();
            this.nroaValor = new System.Windows.Forms.TextBox();
            this.cidadeValor = new System.Windows.Forms.TextBox();
            this.cpfValor = new System.Windows.Forms.TextBox();
            this.codigoValor = new System.Windows.Forms.TextBox();
            this.codigoLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tituloLabel
            // 
            this.tituloLabel.AutoSize = true;
            this.tituloLabel.Font = new System.Drawing.Font("Javanese Text", 32.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tituloLabel.ForeColor = System.Drawing.Color.Black;
            this.tituloLabel.Location = new System.Drawing.Point(12, 25);
            this.tituloLabel.Name = "tituloLabel";
            this.tituloLabel.Size = new System.Drawing.Size(322, 98);
            this.tituloLabel.TabIndex = 39;
            this.tituloLabel.Text = "Editar Médico";
            // 
            // salvarBtn
            // 
            this.salvarBtn.Location = new System.Drawing.Point(132, 446);
            this.salvarBtn.Name = "salvarBtn";
            this.salvarBtn.Size = new System.Drawing.Size(75, 23);
            this.salvarBtn.TabIndex = 7;
            this.salvarBtn.Text = "Slavar";
            this.salvarBtn.UseVisualStyleBackColor = true;
            this.salvarBtn.Click += new System.EventHandler(this.salvarBtn_Click);
            // 
            // voltarBtn
            // 
            this.voltarBtn.Location = new System.Drawing.Point(12, 12);
            this.voltarBtn.Name = "voltarBtn";
            this.voltarBtn.Size = new System.Drawing.Size(75, 23);
            this.voltarBtn.TabIndex = 8;
            this.voltarBtn.Text = "Voltar";
            this.voltarBtn.UseVisualStyleBackColor = true;
            this.voltarBtn.Click += new System.EventHandler(this.voltarBtn_Click);
            // 
            // nroaLabel
            // 
            this.nroaLabel.AutoSize = true;
            this.nroaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nroaLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.nroaLabel.Location = new System.Drawing.Point(142, 390);
            this.nroaLabel.Name = "nroaLabel";
            this.nroaLabel.Size = new System.Drawing.Size(55, 20);
            this.nroaLabel.TabIndex = 36;
            this.nroaLabel.Text = "NROA";
            // 
            // cidadeLabel
            // 
            this.cidadeLabel.AutoSize = true;
            this.cidadeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cidadeLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.cidadeLabel.Location = new System.Drawing.Point(140, 342);
            this.cidadeLabel.Name = "cidadeLabel";
            this.cidadeLabel.Size = new System.Drawing.Size(59, 20);
            this.cidadeLabel.TabIndex = 35;
            this.cidadeLabel.Text = "Cidade";
            // 
            // cpfLabel
            // 
            this.cpfLabel.AutoSize = true;
            this.cpfLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cpfLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.cpfLabel.Location = new System.Drawing.Point(150, 294);
            this.cpfLabel.Name = "cpfLabel";
            this.cpfLabel.Size = new System.Drawing.Size(40, 20);
            this.cpfLabel.TabIndex = 34;
            this.cpfLabel.Text = "CPF";
            // 
            // especialidadeLabel
            // 
            this.especialidadeLabel.AutoSize = true;
            this.especialidadeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.especialidadeLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.especialidadeLabel.Location = new System.Drawing.Point(116, 246);
            this.especialidadeLabel.Name = "especialidadeLabel";
            this.especialidadeLabel.Size = new System.Drawing.Size(108, 20);
            this.especialidadeLabel.TabIndex = 33;
            this.especialidadeLabel.Text = "Especialidade";
            // 
            // idadeLabel
            // 
            this.idadeLabel.AutoSize = true;
            this.idadeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idadeLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.idadeLabel.Location = new System.Drawing.Point(144, 198);
            this.idadeLabel.Name = "idadeLabel";
            this.idadeLabel.Size = new System.Drawing.Size(50, 20);
            this.idadeLabel.TabIndex = 32;
            this.idadeLabel.Text = "Idade";
            // 
            // nomeLabel
            // 
            this.nomeLabel.AutoSize = true;
            this.nomeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nomeLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.nomeLabel.Location = new System.Drawing.Point(144, 150);
            this.nomeLabel.Name = "nomeLabel";
            this.nomeLabel.Size = new System.Drawing.Size(51, 20);
            this.nomeLabel.TabIndex = 31;
            this.nomeLabel.Text = "Nome";
            // 
            // nomeValor
            // 
            this.nomeValor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.nomeValor.Location = new System.Drawing.Point(70, 174);
            this.nomeValor.Name = "nomeValor";
            this.nomeValor.Size = new System.Drawing.Size(200, 20);
            this.nomeValor.TabIndex = 1;
            // 
            // idadeValor
            // 
            this.idadeValor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.idadeValor.Location = new System.Drawing.Point(70, 222);
            this.idadeValor.Name = "idadeValor";
            this.idadeValor.Size = new System.Drawing.Size(200, 20);
            this.idadeValor.TabIndex = 2;
            // 
            // especialidadeValor
            // 
            this.especialidadeValor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.especialidadeValor.Location = new System.Drawing.Point(70, 270);
            this.especialidadeValor.Name = "especialidadeValor";
            this.especialidadeValor.Size = new System.Drawing.Size(200, 20);
            this.especialidadeValor.TabIndex = 3;
            // 
            // nroaValor
            // 
            this.nroaValor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.nroaValor.Location = new System.Drawing.Point(70, 414);
            this.nroaValor.Name = "nroaValor";
            this.nroaValor.Size = new System.Drawing.Size(200, 20);
            this.nroaValor.TabIndex = 6;
            // 
            // cidadeValor
            // 
            this.cidadeValor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.cidadeValor.Location = new System.Drawing.Point(70, 366);
            this.cidadeValor.Name = "cidadeValor";
            this.cidadeValor.Size = new System.Drawing.Size(200, 20);
            this.cidadeValor.TabIndex = 5;
            // 
            // cpfValor
            // 
            this.cpfValor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.cpfValor.Location = new System.Drawing.Point(70, 318);
            this.cpfValor.Name = "cpfValor";
            this.cpfValor.Size = new System.Drawing.Size(200, 20);
            this.cpfValor.TabIndex = 4;
            // 
            // codigoValor
            // 
            this.codigoValor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.codigoValor.Enabled = false;
            this.codigoValor.Location = new System.Drawing.Point(70, 126);
            this.codigoValor.Name = "codigoValor";
            this.codigoValor.Size = new System.Drawing.Size(200, 20);
            this.codigoValor.TabIndex = 24;
            // 
            // codigoLabel
            // 
            this.codigoLabel.AutoSize = true;
            this.codigoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.codigoLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.codigoLabel.Location = new System.Drawing.Point(113, 102);
            this.codigoLabel.Name = "codigoLabel";
            this.codigoLabel.Size = new System.Drawing.Size(114, 20);
            this.codigoLabel.TabIndex = 23;
            this.codigoLabel.Text = "Código Médico";
            // 
            // MedicoEditar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkCyan;
            this.ClientSize = new System.Drawing.Size(334, 493);
            this.Controls.Add(this.salvarBtn);
            this.Controls.Add(this.voltarBtn);
            this.Controls.Add(this.nroaLabel);
            this.Controls.Add(this.cidadeLabel);
            this.Controls.Add(this.cpfLabel);
            this.Controls.Add(this.especialidadeLabel);
            this.Controls.Add(this.idadeLabel);
            this.Controls.Add(this.nomeLabel);
            this.Controls.Add(this.nomeValor);
            this.Controls.Add(this.idadeValor);
            this.Controls.Add(this.especialidadeValor);
            this.Controls.Add(this.nroaValor);
            this.Controls.Add(this.cidadeValor);
            this.Controls.Add(this.cpfValor);
            this.Controls.Add(this.codigoValor);
            this.Controls.Add(this.codigoLabel);
            this.Controls.Add(this.tituloLabel);
            this.Name = "MedicoEditar";
            this.Text = "MedicoEditar";
            this.Load += new System.EventHandler(this.MedicoEditar_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label tituloLabel;
        private System.Windows.Forms.Button salvarBtn;
        private System.Windows.Forms.Button voltarBtn;
        private System.Windows.Forms.Label nroaLabel;
        private System.Windows.Forms.Label cidadeLabel;
        private System.Windows.Forms.Label cpfLabel;
        private System.Windows.Forms.Label especialidadeLabel;
        private System.Windows.Forms.Label idadeLabel;
        private System.Windows.Forms.Label nomeLabel;
        private System.Windows.Forms.TextBox nomeValor;
        private System.Windows.Forms.TextBox idadeValor;
        private System.Windows.Forms.TextBox especialidadeValor;
        private System.Windows.Forms.TextBox nroaValor;
        private System.Windows.Forms.TextBox cidadeValor;
        private System.Windows.Forms.TextBox cpfValor;
        private System.Windows.Forms.TextBox codigoValor;
        private System.Windows.Forms.Label codigoLabel;
    }
}