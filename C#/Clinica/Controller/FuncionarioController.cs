using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clinica
{
    public class FuncionarioController
    {
        public void listar ()
        {
            FuncionarioDAO funcionarioDAO = new FuncionarioDAO ();
            ArrayList lista = funcionarioDAO.all();

            Funcionarios tela = new Funcionarios (lista);
            tela.Show();
        }
    }
}
