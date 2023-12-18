namespace Clinica
{
    partial class FuncionarioEditar
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
            this.tituloLabel = new System.Windows.Forms.Label();
            this.salvarBtn = new System.Windows.Forms.Button();
            this.cargoLabel = new System.Windows.Forms.Label();
            this.salarioLabel = new System.Windows.Forms.Label();
            this.cidadeLabel = new System.Windows.Forms.Label();
            this.cpfLabel = new System.Windows.Forms.Label();
            this.idadeLabel = new System.Windows.Forms.Label();
            this.nomeLabel = new System.Windows.Forms.Label();
            this.cargoValor = new System.Windows.Forms.TextBox();
            this.salarioValor = new System.Windows.Forms.TextBox();
            this.cidadeValor = new System.Windows.Forms.TextBox();
            this.cpfValor = new System.Windows.Forms.TextBox();
            this.idadeValor = new System.Windows.Forms.TextBox();
            this.nomeValor = new System.Windows.Forms.TextBox();
            this.codigoValor = new System.Windows.Forms.TextBox();
            this.codigoLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
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
            // tituloLabel
            // 
            this.tituloLabel.AutoSize = true;
            this.tituloLabel.Font = new System.Drawing.Font("Javanese Text", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tituloLabel.ForeColor = System.Drawing.Color.Black;
            this.tituloLabel.Location = new System.Drawing.Point(23, 27);
            this.tituloLabel.Name = "tituloLabel";
            this.tituloLabel.Size = new System.Drawing.Size(338, 84);
            this.tituloLabel.TabIndex = 32;
            this.tituloLabel.Text = "Criar Novo Funci.";
            // 
            // salvarBtn
            // 
            this.salvarBtn.Location = new System.Drawing.Point(137, 435);
            this.salvarBtn.Name = "salvarBtn";
            this.salvarBtn.Size = new System.Drawing.Size(75, 23);
            this.salvarBtn.TabIndex = 31;
            this.salvarBtn.Text = "Salvar";
            this.salvarBtn.UseVisualStyleBackColor = true;
            this.salvarBtn.Click += new System.EventHandler(this.salvarBtn_Click);
            // 
            // cargoLabel
            // 
            this.cargoLabel.AutoSize = true;
            this.cargoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cargoLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.cargoLabel.Location = new System.Drawing.Point(149, 379);
            this.cargoLabel.Name = "cargoLabel";
            this.cargoLabel.Size = new System.Drawing.Size(52, 20);
            this.cargoLabel.TabIndex = 30;
            this.cargoLabel.Text = "Cargo";
            // 
            // salarioLabel
            // 
            this.salarioLabel.AutoSize = true;
            this.salarioLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.salarioLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.salarioLabel.Location = new System.Drawing.Point(145, 331);
            this.salarioLabel.Name = "salarioLabel";
            this.salarioLabel.Size = new System.Drawing.Size(58, 20);
            this.salarioLabel.TabIndex = 29;
            this.salarioLabel.Text = "Salário";
            // 
            // cidadeLabel
            // 
            this.cidadeLabel.AutoSize = true;
            this.cidadeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cidadeLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.cidadeLabel.Location = new System.Drawing.Point(145, 283);
            this.cidadeLabel.Name = "cidadeLabel";
            this.cidadeLabel.Size = new System.Drawing.Size(59, 20);
            this.cidadeLabel.TabIndex = 28;
            this.cidadeLabel.Text = "Cidade";
            // 
            // cpfLabel
            // 
            this.cpfLabel.AutoSize = true;
            this.cpfLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cpfLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.cpfLabel.Location = new System.Drawing.Point(155, 235);
            this.cpfLabel.Name = "cpfLabel";
            this.cpfLabel.Size = new System.Drawing.Size(40, 20);
            this.cpfLabel.TabIndex = 27;
            this.cpfLabel.Text = "CPF";
            // 
            // idadeLabel
            // 
            this.idadeLabel.AutoSize = true;
            this.idadeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idadeLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.idadeLabel.Location = new System.Drawing.Point(149, 187);
            this.idadeLabel.Name = "idadeLabel";
            this.idadeLabel.Size = new System.Drawing.Size(50, 20);
            this.idadeLabel.TabIndex = 26;
            this.idadeLabel.Text = "Idade";
            // 
            // nomeLabel
            // 
            this.nomeLabel.AutoSize = true;
            this.nomeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nomeLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.nomeLabel.Location = new System.Drawing.Point(149, 139);
            this.nomeLabel.Name = "nomeLabel";
            this.nomeLabel.Size = new System.Drawing.Size(51, 20);
            this.nomeLabel.TabIndex = 25;
            this.nomeLabel.Text = "Nome";
            // 
            // cargoValor
            // 
            this.cargoValor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.cargoValor.Location = new System.Drawing.Point(75, 403);
            this.cargoValor.Name = "cargoValor";
            this.cargoValor.Size = new System.Drawing.Size(200, 20);
            this.cargoValor.TabIndex = 24;
            // 
            // salarioValor
            // 
            this.salarioValor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.salarioValor.Location = new System.Drawing.Point(75, 355);
            this.salarioValor.Name = "salarioValor";
            this.salarioValor.Size = new System.Drawing.Size(200, 20);
            this.salarioValor.TabIndex = 23;
            // 
            // cidadeValor
            // 
            this.cidadeValor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.cidadeValor.Location = new System.Drawing.Point(75, 307);
            this.cidadeValor.Name = "cidadeValor";
            this.cidadeValor.Size = new System.Drawing.Size(200, 20);
            this.cidadeValor.TabIndex = 22;
            // 
            // cpfValor
            // 
            this.cpfValor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.cpfValor.Location = new System.Drawing.Point(75, 259);
            this.cpfValor.Name = "cpfValor";
            this.cpfValor.Size = new System.Drawing.Size(200, 20);
            this.cpfValor.TabIndex = 21;
            // 
            // idadeValor
            // 
            this.idadeValor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.idadeValor.Location = new System.Drawing.Point(75, 211);
            this.idadeValor.Name = "idadeValor";
            this.idadeValor.Size = new System.Drawing.Size(200, 20);
            this.idadeValor.TabIndex = 20;
            // 
            // nomeValor
            // 
            this.nomeValor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.nomeValor.Location = new System.Drawing.Point(75, 163);
            this.nomeValor.Name = "nomeValor";
            this.nomeValor.Size = new System.Drawing.Size(200, 20);
            this.nomeValor.TabIndex = 19;
            // 
            // codigoValor
            // 
            this.codigoValor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.codigoValor.Enabled = false;
            this.codigoValor.Location = new System.Drawing.Point(75, 115);
            this.codigoValor.Name = "codigoValor";
            this.codigoValor.Size = new System.Drawing.Size(200, 20);
            this.codigoValor.TabIndex = 18;
            // 
            // codigoLabel
            // 
            this.codigoLabel.AutoSize = true;
            this.codigoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.codigoLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.codigoLabel.Location = new System.Drawing.Point(145, 91);
            this.codigoLabel.Name = "codigoLabel";
            this.codigoLabel.Size = new System.Drawing.Size(59, 20);
            this.codigoLabel.TabIndex = 17;
            this.codigoLabel.Text = "Código";
            // 
            // FuncionarioEditar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkCyan;
            this.ClientSize = new System.Drawing.Size(356, 472);
            this.Controls.Add(this.salvarBtn);
            this.Controls.Add(this.cargoLabel);
            this.Controls.Add(this.salarioLabel);
            this.Controls.Add(this.cidadeLabel);
            this.Controls.Add(this.cpfLabel);
            this.Controls.Add(this.idadeLabel);
            this.Controls.Add(this.nomeLabel);
            this.Controls.Add(this.cargoValor);
            this.Controls.Add(this.salarioValor);
            this.Controls.Add(this.cidadeValor);
            this.Controls.Add(this.cpfValor);
            this.Controls.Add(this.idadeValor);
            this.Controls.Add(this.nomeValor);
            this.Controls.Add(this.codigoValor);
            this.Controls.Add(this.codigoLabel);
            this.Controls.Add(this.voltarBtn);
            this.Controls.Add(this.tituloLabel);
            this.Name = "FuncionarioEditar";
            this.Text = "FuncionarioEditar";
            this.Load += new System.EventHandler(this.FuncionarioEditar_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button voltarBtn;
        private System.Windows.Forms.Label tituloLabel;
        private System.Windows.Forms.Button salvarBtn;
        private System.Windows.Forms.Label cargoLabel;
        private System.Windows.Forms.Label salarioLabel;
        private System.Windows.Forms.Label cidadeLabel;
        private System.Windows.Forms.Label cpfLabel;
        private System.Windows.Forms.Label idadeLabel;
        private System.Windows.Forms.Label nomeLabel;
        private System.Windows.Forms.TextBox cargoValor;
        private System.Windows.Forms.TextBox salarioValor;
        private System.Windows.Forms.TextBox cidadeValor;
        private System.Windows.Forms.TextBox cpfValor;
        private System.Windows.Forms.TextBox idadeValor;
        private System.Windows.Forms.TextBox nomeValor;
        private System.Windows.Forms.TextBox codigoValor;
        private System.Windows.Forms.Label codigoLabel;
    }
}