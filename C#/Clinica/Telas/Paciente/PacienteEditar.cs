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
    public partial class PacienteEditar : Form
    {
        public PacienteEditar (object paciente)
        {
            InitializeComponent();

            Paciente p = (Paciente)paciente;

            this.codigoValor.Text = p.codp.ToString();
            this.nomeValor.Text = p.nome;
            this.idadeValor.Text = p.idade.ToString();
            this.cidadeValor.Text = p.cidade;
            this.cpfValor.Text = p.cpf;
            this.doencaValor.Text = p.doenca;
        }

        private void PacienteEditar_Load (object sender, EventArgs e)
        {

        }

        private void salvarBtn_Click (object sender, EventArgs e)
        {
            Paciente paciente = new Paciente();

            paciente.codp = int.Parse(this.codigoValor.Text);
            paciente.nome = this.nomeValor.Text;
            paciente.idade = int.Parse(this.idadeValor.Text);
            paciente.cidade = this.cidadeValor.Text;
            paciente.cpf = this.cpfValor.Text;
            paciente.doenca = this.doencaValor.Text;

            PacienteController controller = new PacienteController();
            controller.salvar(paciente);

            this.Close();
        }

        private void voltarBtn_Click (object sender, EventArgs e)
        {
            this.Close();
            PacientesCriar tela = new PacientesCriar();
            tela.Show();
        }
    }
}
