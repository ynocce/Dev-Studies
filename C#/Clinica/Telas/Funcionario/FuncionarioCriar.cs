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
    public partial class FuncionarioCriar : Form
    {
        public FuncionarioCriar ()
        {
            InitializeComponent();
            this.Show();
        }

        private void salvarBtn_Click (object sender, EventArgs e)
        {
            FuncionarioModel funcionario = new FuncionarioModel();

            funcionario.codf = int.Parse(this.codigoValor.Text.Trim());
            funcionario.nome = this.nomeValor.Text.Trim();
            funcionario.idade = int.Parse(this.idadeValor.Text.Trim());
            funcionario.cpf = this.cpfValor.Text.Trim();
            funcionario.cidade = this.cidadeValor.Text.Trim();
            funcionario.salario = double.Parse(this.salarioValor.Text.Trim());
            funcionario.cargo = this.cargoValor.Text.Trim();

            
            FuncionarioEditar tela = new FuncionarioEditar (funcionario);
            tela.Show();
            this.Close();
        }

        private void voltarBtn_Click (object sender, EventArgs e)
        {
            this.Close();
            Funcionarios tela = new Funcionarios();
            tela.Show();
        }

        private void FuncionarioCriar_Load (object sender, EventArgs e)
        {

        }
    }
}
