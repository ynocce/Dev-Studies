namespace Clinica
{
    partial class Inicio
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose (bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent ()
        {
            this.pacienteBtn = new System.Windows.Forms.Button();
            this.consultaBtn = new System.Windows.Forms.Button();
            this.medicoBtn = new System.Windows.Forms.Button();
            this.funcionarioBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // pacienteBtn
            // 
            this.pacienteBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.pacienteBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(163)))), ((int)(((byte)(17)))));
            this.pacienteBtn.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.pacienteBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pacienteBtn.Location = new System.Drawing.Point(27, 98);
            this.pacienteBtn.Name = "pacienteBtn";
            this.pacienteBtn.Size = new System.Drawing.Size(156, 56);
            this.pacienteBtn.TabIndex = 0;
            this.pacienteBtn.Text = "Pacientes";
            this.pacienteBtn.UseVisualStyleBackColor = false;
            this.pacienteBtn.Click += new System.EventHandler(this.pacienteBtn_Click);
            // 
            // consultaBtn
            // 
            this.consultaBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.consultaBtn.Location = new System.Drawing.Point(189, 98);
            this.consultaBtn.Name = "consultaBtn";
            this.consultaBtn.Size = new System.Drawing.Size(156, 56);
            this.consultaBtn.TabIndex = 1;
            this.consultaBtn.Text = "Consultas";
            this.consultaBtn.UseVisualStyleBackColor = true;
            this.consultaBtn.Click += new System.EventHandler(this.consultaBtn_Click);
            // 
            // medicoBtn
            // 
            this.medicoBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.medicoBtn.Location = new System.Drawing.Point(27, 175);
            this.medicoBtn.Name = "medicoBtn";
            this.medicoBtn.Size = new System.Drawing.Size(156, 56);
            this.medicoBtn.TabIndex = 2;
            this.medicoBtn.Text = "Médicos";
            this.medicoBtn.UseVisualStyleBackColor = true;
            this.medicoBtn.Click += new System.EventHandler(this.medicoBtn_Click);
            // 
            // funcionarioBtn
            // 
            this.funcionarioBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.funcionarioBtn.Location = new System.Drawing.Point(189, 175);
            this.funcionarioBtn.Name = "funcionarioBtn";
            this.funcionarioBtn.Size = new System.Drawing.Size(156, 56);
            this.funcionarioBtn.TabIndex = 3;
            this.funcionarioBtn.Text = "Funcionários";
            this.funcionarioBtn.UseVisualStyleBackColor = true;
            this.funcionarioBtn.Click += new System.EventHandler(this.funcionarioBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Javanese Text", 32.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(69, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(263, 98);
            this.label1.TabIndex = 4;
            this.label1.Text = "Bem vindo!";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkCyan;
            this.ClientSize = new System.Drawing.Size(383, 263);
            this.Controls.Add(this.funcionarioBtn);
            this.Controls.Add(this.medicoBtn);
            this.Controls.Add(this.consultaBtn);
            this.Controls.Add(this.pacienteBtn);
            this.Controls.Add(this.label1);
            this.Name = "Inicio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sistema Clinica";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button pacienteBtn;
        private System.Windows.Forms.Button consultaBtn;
        private System.Windows.Forms.Button medicoBtn;
        private System.Windows.Forms.Button funcionarioBtn;
        private System.Windows.Forms.Label label1;
    }
}

