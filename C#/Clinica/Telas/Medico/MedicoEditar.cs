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
    public partial class MedicoEditar : Form
    {
        public MedicoEditar (object medico)
        {
            InitializeComponent();

            Medico m = (Medico)medico;
            this.codigoValor.Text = m.codm.ToString();
            this.nomeValor.Text = m.nome;
            this.idadeValor.Text = m.idade.ToString();
            this.especialidadeValor.Text = m.especialidade;
            this.cpfValor.Text = m.cpf;
            this.cidadeValor.Text = m.cidade;
            this.nroaValor.Text = m.nroa.ToString();
            
        }

        private void MedicoEditar_Load (object sender, EventArgs e)
        {

        }

        private void salvarBtn_Click (object sender, EventArgs e)
        {
            Medico medico = new Medico();
            medico.codm = int.Parse(this.codigoValor.Text);
            medico.nome = this.nomeValor.Text;
            medico.idade = int.Parse(this.idadeValor.Text);
            medico.especialidade = this.especialidadeValor.Text;
            medico.cpf = this.cpfValor.Text;
            medico.cidade = this.cidadeValor.Text;

            medico.nroa = int.Parse(this.nroaValor.Text);

            ArrayList medicos = new ArrayList();
            medicos.Add(medico);

            Medicos listagem = new Medicos(medicos);
            listagem.Show();
            this.Close();

        }

        private void voltarBtn_Click (object sender, EventArgs e)
        {
            this.Close();
            MedicosCriar tela = new MedicosCriar();
            tela.Show();
        }
    }
}
