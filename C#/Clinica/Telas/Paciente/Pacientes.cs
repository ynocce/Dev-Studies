using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clinica
{
    public partial class Pacientes : Form
    {
        public Pacientes ()
        {
            InitializeComponent();
            
        }
        public Pacientes (ArrayList pacientes)
        {
            InitializeComponent();
            //this.listagem.DataSource = pacientes;
            int x = 0;

            foreach (Paciente p in pacientes)
            {
                this.listagem.Rows.Add();
                this.listagem.Rows[x].Cells[0].Value = p.codp;
                this.listagem.Rows[x].Cells[1].Value = p.nome;
                this.listagem.Rows[x].Cells[2].Value = p.idade;
                this.listagem.Rows[x].Cells[3].Value = p.cpf;
                this.listagem.Rows[x].Cells[4].Value = p.cidade;
                this.listagem.Rows[x].Cells[5].Value = p.doenca;
                x++;
            }
        }
        private void filtroValor_TextChanged (object sender, EventArgs e)
        {

        }

        private void voltarBtn_Click (object sender, EventArgs e)
        {
            Inicio inicio = new Inicio();
            this.Close();
            inicio.Show();
        }

        private void novoBtn_Click (object sender, EventArgs e)
        {
            PacientesCriar pacienteCriar = new PacientesCriar();
            pacienteCriar.Show();
            this.Close();
        }

        private void Pacientes_Load (object sender, EventArgs e)
        {

        }

        private void editarBtn_Click (object sender, EventArgs e)
        {
            int rowIndex = this.listagem.CurrentCell.RowIndex;

            String codp = this.listagem.Rows[rowIndex].Cells[0].Value.ToString();
            String nome = this.listagem.Rows[rowIndex].Cells[1].Value.ToString();
            String idade = this.listagem.Rows[rowIndex].Cells[2].Value.ToString();
            String cidade = this.listagem.Rows[rowIndex].Cells[3].Value.ToString();
            String cpf = this.listagem.Rows[rowIndex].Cells[4].Value.ToString();
            String doenca = this.listagem.Rows[rowIndex].Cells[5].Value.ToString();

            Paciente paciente = new Paciente();
            paciente.codp = int.Parse(codp);
            paciente.nome = nome;
            paciente.idade = int.Parse(idade);
            paciente.cpf = cpf;
            paciente.cidade = cidade;
            paciente.doenca = doenca;

            PacienteController controller = new PacienteController();
            controller.alterar(paciente);
            this.Close();
        }

        private void deletarBtn_Click (object sender, EventArgs e)
        {
            int rowIndex = this.listagem.CurrentCell.RowIndex;

            String codp = this.listagem.Rows[rowIndex].Cells[0].Value.ToString();
            String nome = this.listagem.Rows[rowIndex].Cells[1].Value.ToString();
            String idade = this.listagem.Rows[rowIndex].Cells[2].Value.ToString();
            String cidade = this.listagem.Rows[rowIndex].Cells[3].Value.ToString();
            String cpf = this.listagem.Rows[rowIndex].Cells[4].Value.ToString();
            String doenca = this.listagem.Rows[rowIndex].Cells[5].Value.ToString();

            Paciente paciente = new Paciente();
            paciente.codp = int.Parse(codp);
            paciente.nome = nome;
            paciente.idade = int.Parse(idade);
            paciente.cpf = cpf;
            paciente.cidade = cidade;
            paciente.doenca = doenca;

            PacienteController controller = new PacienteController();
            controller.deletar(paciente);
            this.Close();
        }
    }
}
