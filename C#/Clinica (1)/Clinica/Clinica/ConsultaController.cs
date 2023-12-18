using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clinica
{
    public class ConsultaController
    {
        public void listar ()
        {
            ConsultaDAO consultaDAO = new ConsultaDAO();
            ArrayList lista = consultaDAO.all();

            Consultas tela = new Consultas(lista);
            tela.Show();
        }
    }
}
