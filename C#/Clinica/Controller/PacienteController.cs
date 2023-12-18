using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clinica
{
    public class PacienteController
    {
        public void listar ()
        {
            PacienteDAO pacienteDAO = new PacienteDAO();
            ArrayList lista = pacienteDAO.all();

            Pacientes pacientes = new Pacientes(lista);
            pacientes.Show();
        }
        public void criar(object objeto)
        {
            Paciente paciente = (Paciente)objeto;

            PacienteDAO pacienteDAO = new PacienteDAO();

            paciente = (Paciente)pacienteDAO.create(paciente);
            this.alterar(paciente);
        }
        public void alterar (object objeto)
        {
            Paciente paciente = (Paciente)objeto;
            PacienteEditar edicao = new PacienteEditar (paciente);
            edicao.Show();

        }

        public void salvar (object objeto)
        {
            Paciente paciente = (Paciente)objeto;

            PacienteDAO pacienteDAO = new PacienteDAO();

            paciente = (Paciente)pacienteDAO.update(paciente);

            ArrayList todos = pacienteDAO.all();
            Pacientes listagem = new Pacientes(todos);
            listagem.Show();

        }
        public void deletar (object objeto)
        {
            Paciente paciente = (Paciente)objeto;

            PacienteDAO pacienteDAO = new PacienteDAO();
            pacienteDAO.delete(paciente);

            new Pacientes(pacienteDAO.all()).Show();
        }
    }
}
