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
    public partial class Medicos : Form
    {
        public Medicos ()
        {
            InitializeComponent();
        }
        public Medicos (ArrayList medicos)
        {
            InitializeComponent();
            int x = 0;

            foreach(Medico m in medicos)
            {
                listagem.Rows.Add();
                this.listagem.Rows[x].Cells[0].Value = m.codm;
                this.listagem.Rows[x].Cells[1].Value = m.nome;
                this.listagem.Rows[x].Cells[2].Value = m.idade;
                this.listagem.Rows[x].Cells[3].Value = m.especialidade;
                this.listagem.Rows[x].Cells[4].Value = m.cpf;
                this.listagem.Rows[x].Cells[5].Value = m.cidade;
                this.listagem.Rows[x].Cells[6].Value = m.nroa;
                x++;
            }
        }


        private void filtroLabel_Click (object sender, EventArgs e)
        {

        }

        private void filrarBtn_Click (object sender, EventArgs e)
        {

        }

        private void buscaValor_TextChanged (object sender, EventArgs e)
        {

        }

        private void voltarBtn_Click (object sender, EventArgs e)
        {
            this.Close();
            Inicio inicio = new Inicio ();
            inicio.Show();
        }

        private void novoBtn_Click (object sender, EventArgs e)
        {
            this.Close ();
            MedicosCriar tela = new MedicosCriar ();
            tela.Show();
        }

        private void Medicos_Load (object sender, EventArgs e)
        {

        }
    }
}
