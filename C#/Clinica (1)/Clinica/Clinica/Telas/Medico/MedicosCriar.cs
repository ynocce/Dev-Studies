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
    public partial class MedicosCriar : Form
    {
        public MedicosCriar ()
        {
            InitializeComponent();
        }

        private void salvarBtn_Click (object sender, EventArgs e)
        {

            Medico medico = new Medico ();

            medico.codm = int.Parse(this.codigoValor.Text.Trim());
            medico.nome = this.nomeValor.Text.Trim();
            medico.idade = int.Parse(this.idadeValor.Text.Trim());
            medico.especialidade = this.especialidadeValor.Text.Trim();
            medico.cpf = this.cpfValor.Text.Trim();
            medico.cidade = this.cidadeValor.Text.Trim();
            medico.nroa = int.Parse(this.nroaValor.Text.Trim());

            MedicoEditar tela = new MedicoEditar(medico);
            tela.Show();
            this.Close();
        }

        private void voltarBtn_Click_2 (object sender, EventArgs e)
        {
            this.Close();
            Medicos tela = new Medicos();
            tela.Show();
        }
    }
}
