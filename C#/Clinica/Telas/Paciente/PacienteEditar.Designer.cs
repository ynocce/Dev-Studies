namespace Clinica
{
    partial class PacienteEditar
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
            this.salvarBtn = new System.Windows.Forms.Button();
            this.tituloLabel = new System.Windows.Forms.Label();
            this.doencaValor = new System.Windows.Forms.TextBox();
            this.doencaLbel = new System.Windows.Forms.Label();
            this.cpfValor = new System.Windows.Forms.TextBox();
            this.cpfLabel = new System.Windows.Forms.Label();
            this.cidadeValor = new System.Windows.Forms.TextBox();
            this.cidadeLabel = new System.Windows.Forms.Label();
            this.idadeValor = new System.Windows.Forms.TextBox();
            this.idadeLabel = new System.Windows.Forms.Label();
            this.nomeValor = new System.Windows.Forms.TextBox();
            this.nomeLabel = new System.Windows.Forms.Label();
            this.codigoValor = new System.Windows.Forms.TextBox();
            this.codigoLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // voltarBtn
            // 
            this.voltarBtn.Location = new System.Drawing.Point(12, 12);
            this.voltarBtn.Name = "voltarBtn";
            this.voltarBtn.Size = new System.Drawing.Size(75, 23);
            this.voltarBtn.TabIndex = 29;
            this.voltarBtn.Text = "Voltar";
            this.voltarBtn.UseVisualStyleBackColor = true;
            this.voltarBtn.Click += new System.EventHandler(this.voltarBtn_Click);
            // 
            // salvarBtn
            // 
            this.salvarBtn.Location = new System.Drawing.Point(370, 392);
            this.salvarBtn.Name = "salvarBtn";
            this.salvarBtn.Size = new System.Drawing.Size(75, 23);
            this.salvarBtn.TabIndex = 28;
            this.salvarBtn.Text = "Salvar";
            this.salvarBtn.UseVisualStyleBackColor = true;
            this.salvarBtn.Click += new System.EventHandler(this.salvarBtn_Click);
            // 
            // tituloLabel
            // 
            this.tituloLabel.AutoSize = true;
            this.tituloLabel.Font = new System.Drawing.Font("Ink Free", 32F);
            this.tituloLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(163)))), ((int)(((byte)(17)))));
            this.tituloLabel.Location = new System.Drawing.Point(256, 32);
            this.tituloLabel.Name = "tituloLabel";
            this.tituloLabel.Size = new System.Drawing.Size(304, 53);
            this.tituloLabel.TabIndex = 27;
            this.tituloLabel.Text = "Editar Paciente";
            this.tituloLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // doencaValor
            // 
            this.doencaValor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.doencaValor.Location = new System.Drawing.Point(308, 360);
            this.doencaValor.Name = "doencaValor";
            this.doencaValor.Size = new System.Drawing.Size(200, 20);
            this.doencaValor.TabIndex = 26;
            // 
            // doencaLbel
            // 
            this.doencaLbel.AutoSize = true;
            this.doencaLbel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.doencaLbel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.doencaLbel.Location = new System.Drawing.Point(375, 336);
            this.doencaLbel.Name = "doencaLbel";
            this.doencaLbel.Size = new System.Drawing.Size(65, 20);
            this.doencaLbel.TabIndex = 25;
            this.doencaLbel.Text = "Doença";
            this.doencaLbel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cpfValor
            // 
            this.cpfValor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.cpfValor.Location = new System.Drawing.Point(308, 312);
            this.cpfValor.Name = "cpfValor";
            this.cpfValor.Size = new System.Drawing.Size(200, 20);
            this.cpfValor.TabIndex = 24;
            // 
            // cpfLabel
            // 
            this.cpfLabel.AutoSize = true;
            this.cpfLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cpfLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.cpfLabel.Location = new System.Drawing.Point(388, 288);
            this.cpfLabel.Name = "cpfLabel";
            this.cpfLabel.Size = new System.Drawing.Size(40, 20);
            this.cpfLabel.TabIndex = 23;
            this.cpfLabel.Text = "CPF";
            this.cpfLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cidadeValor
            // 
            this.cidadeValor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.cidadeValor.Location = new System.Drawing.Point(308, 264);
            this.cidadeValor.Name = "cidadeValor";
            this.cidadeValor.Size = new System.Drawing.Size(200, 20);
            this.cidadeValor.TabIndex = 22;
            // 
            // cidadeLabel
            // 
            this.cidadeLabel.AutoSize = true;
            this.cidadeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cidadeLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.cidadeLabel.Location = new System.Drawing.Point(378, 240);
            this.cidadeLabel.Name = "cidadeLabel";
            this.cidadeLabel.Size = new System.Drawing.Size(59, 20);
            this.cidadeLabel.TabIndex = 21;
            this.cidadeLabel.Text = "Cidade";
            this.cidadeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // idadeValor
            // 
            this.idadeValor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.idadeValor.Location = new System.Drawing.Point(308, 216);
            this.idadeValor.Name = "idadeValor";
            this.idadeValor.Size = new System.Drawing.Size(200, 20);
            this.idadeValor.TabIndex = 20;
            // 
            // idadeLabel
            // 
            this.idadeLabel.AutoSize = true;
            this.idadeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idadeLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.idadeLabel.Location = new System.Drawing.Point(382, 192);
            this.idadeLabel.Name = "idadeLabel";
            this.idadeLabel.Size = new System.Drawing.Size(50, 20);
            this.idadeLabel.TabIndex = 19;
            this.idadeLabel.Text = "Idade";
            this.idadeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // nomeValor
            // 
            this.nomeValor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.nomeValor.Location = new System.Drawing.Point(308, 168);
            this.nomeValor.Name = "nomeValor";
            this.nomeValor.Size = new System.Drawing.Size(200, 20);
            this.nomeValor.TabIndex = 18;
            // 
            // nomeLabel
            // 
            this.nomeLabel.AutoSize = true;
            this.nomeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nomeLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.nomeLabel.Location = new System.Drawing.Point(382, 144);
            this.nomeLabel.Name = "nomeLabel";
            this.nomeLabel.Size = new System.Drawing.Size(51, 20);
            this.nomeLabel.TabIndex = 17;
            this.nomeLabel.Text = "Nome";
            this.nomeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // codigoValor
            // 
            this.codigoValor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.codigoValor.Enabled = false;
            this.codigoValor.Location = new System.Drawing.Point(308, 120);
            this.codigoValor.Name = "codigoValor";
            this.codigoValor.Size = new System.Drawing.Size(200, 20);
            this.codigoValor.TabIndex = 16;
            // 
            // codigoLabel
            // 
            this.codigoLabel.AutoSize = true;
            this.codigoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.codigoLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.codigoLabel.Location = new System.Drawing.Point(345, 96);
            this.codigoLabel.Name = "codigoLabel";
            this.codigoLabel.Size = new System.Drawing.Size(125, 20);
            this.codigoLabel.TabIndex = 15;
            this.codigoLabel.Text = "Codigo Paciente";
            this.codigoLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // PacienteEditar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(33)))), ((int)(((byte)(61)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.voltarBtn);
            this.Controls.Add(this.salvarBtn);
            this.Controls.Add(this.tituloLabel);
            this.Controls.Add(this.doencaValor);
            this.Controls.Add(this.doencaLbel);
            this.Controls.Add(this.cpfValor);
            this.Controls.Add(this.cpfLabel);
            this.Controls.Add(this.cidadeValor);
            this.Controls.Add(this.cidadeLabel);
            this.Controls.Add(this.idadeValor);
            this.Controls.Add(this.idadeLabel);
            this.Controls.Add(this.nomeValor);
            this.Controls.Add(this.nomeLabel);
            this.Controls.Add(this.codigoValor);
            this.Controls.Add(this.codigoLabel);
            this.Name = "PacienteEditar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "PacienteEditar";
            this.Load += new System.EventHandler(this.PacienteEditar_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button voltarBtn;
        private System.Windows.Forms.Button salvarBtn;
        private System.Windows.Forms.Label tituloLabel;
        private System.Windows.Forms.TextBox doencaValor;
        private System.Windows.Forms.Label doencaLbel;
        private System.Windows.Forms.TextBox cpfValor;
        private System.Windows.Forms.Label cpfLabel;
        private System.Windows.Forms.TextBox cidadeValor;
        private System.Windows.Forms.Label cidadeLabel;
        private System.Windows.Forms.TextBox idadeValor;
        private System.Windows.Forms.Label idadeLabel;
        private System.Windows.Forms.TextBox nomeValor;
        private System.Windows.Forms.Label nomeLabel;
        private System.Windows.Forms.TextBox codigoValor;
        private System.Windows.Forms.Label codigoLabel;
    }
}