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
    public partial class FuncionarioEditar : Form
    {
        public FuncionarioEditar (object funcionario)
        {
            InitializeComponent();

            FuncionarioModel f = (FuncionarioModel)funcionario;

            this.codigoValor.Text = f.codf.ToString();
            this.nomeValor.Text = f.nome;
            this.idadeValor.Text = f.idade.ToString();
            this.cpfValor.Text = f.cpf;
            this.cidadeValor.Text = f.cidade;
            this.salarioValor.Text = f.salario.ToString();
            this.cargoValor.Text = f.cargo;
        }

        private void voltarBtn_Click (object sender, EventArgs e)
        {
            this.Close();
            FuncionarioCriar tela = new FuncionarioCriar();
            tela.Show();
        }

        private void salvarBtn_Click (object sender, EventArgs e)
        {
            FuncionarioModel funcionario = new FuncionarioModel ();

            funcionario.codf = int.Parse(this.codigoValor.Text);
            funcionario.nome = this.nomeValor.Text;
            funcionario.idade = int.Parse(this.idadeValor.Text);
            funcionario.cpf = this.cpfValor.Text;
            funcionario.cidade = this.cidadeValor.Text;
            funcionario.salario = double.Parse(this.salarioValor.Text);
            funcionario.cargo = this.cargoValor.Text;

            ArrayList funcionarios = new ArrayList();
            funcionarios.Add(funcionario);

            this.Close();
            Funcionarios tela = new Funcionarios();
            tela.Show();
        }

        private void FuncionarioEditar_Load (object sender, EventArgs e)
        {

        }
    }
}
