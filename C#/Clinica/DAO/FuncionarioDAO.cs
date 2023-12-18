using MySql.Data.MySqlClient;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clinica
{
    internal class FuncionarioDAO : IDAO
    {
        public ArrayList all ()
        {
            ArrayList lista = new ArrayList();
            FuncionarioModel funcionario;
            BancoDeDados bd = new BancoDeDados();

            string sql = "select * from funcionarios";
            MySqlCommand cmd = new MySqlCommand(sql, bd.conectar());

            try
            {
                MySqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    funcionario = new FuncionarioModel();
                    funcionario.codf = int.Parse(dr[0].ToString());
                    funcionario.nome = dr[1].ToString();
                    funcionario.idade = int.Parse(dr[2].ToString());
                    funcionario.cpf = dr[3].ToString();
                    funcionario.cidade = dr[4].ToString();
                    funcionario.salario = double.Parse(dr[5].ToString());
                    funcionario.cargo = dr[6].ToString();

                    lista.Add(funcionario);
                }
                dr.Close();
            }
            catch
            {
                throw;
            }
            return lista;
        }

        public object create (object objeto)
        {
            throw new NotImplementedException();
        }

        public object delete (object chave)
        {
            throw new NotImplementedException();
        }

        public object read (object chave)
        {
            throw new NotImplementedException();
        }

        public object update (object objeto)
        {
            throw new NotImplementedException();
        }
    }
}
