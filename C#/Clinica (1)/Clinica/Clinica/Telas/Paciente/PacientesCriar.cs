using System;
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
    public partial class PacientesCriar : Form
    {
        public PacientesCriar ()
        {
            InitializeComponent();
            this.Show();
        }

        private void label3_Click (object sender, EventArgs e)
        {

        }

        private void voltarBtn_Click (object sender, EventArgs e)
        {
            this.Close();
            Pacientes pacientes = new Pacientes();
            pacientes.Show();
            
        }

        private void salvarBtn_Click (object sender, EventArgs e)
        {
            Paciente paciente = new Paciente();

            //paciente.codp = int.Parse(this.codigoValor.Text.Trim());
            paciente.nome = this.nomeValor.Text.Trim();
            paciente.idade = int.Parse(this.idadeValor.Text.Trim());
            paciente.cidade = this.cidadeValor.Text.Trim();
            paciente.cpf = this.cpfValor.Text.Trim();
            paciente.doenca = this.doencaValor.Text.Trim();

            PacienteController pacienteController = new PacienteController();
            pacienteController.criar(paciente);
            
            this.Hide();
        }

        private void PacientesCriar_Load (object sender, EventArgs e)
        {

        }
    }
}
