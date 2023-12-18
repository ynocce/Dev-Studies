using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clinica
{
    public class MedicoController
    {
        public void listar ()
        {
            MedicoDAO medicoDAO = new MedicoDAO();
            ArrayList lista = medicoDAO.all();

            Medicos tela = new Medicos (lista);
            tela.Show();
        }


    }
}
