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
    public partial class Funcionarios : Form
    {
        public Funcionarios ()
        {
            InitializeComponent();
            Show();
        }
        public Funcionarios (ArrayList funcionarios)
        {
            InitializeComponent();
            int x = 0;

            foreach (FuncionarioModel f in funcionarios)
            {
                listagem.Rows.Add();

                this.listagem.Rows[x].Cells[0].Value = f.codf;
                this.listagem.Rows[x].Cells[1].Value = f.nome;
                this.listagem.Rows[x].Cells[2].Value = f.idade;
                this.listagem.Rows[x].Cells[3].Value = f.cpf;
                this.listagem.Rows[x].Cells[4].Value = f.cidade;
                this.listagem.Rows[x].Cells[5].Value = f.salario;
                this.listagem.Rows[x].Cells[6].Value = f.cargo;

                x++;

            }
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
            FuncionarioCriar tela = new FuncionarioCriar ();
            tela.Show();
        }

        private void Funcionarios_Load (object sender, EventArgs e)
        {

        }

        private void listagem_CellContentClick (object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
