using MySql.Data.MySqlClient;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clinica
{
    internal class MedicoDAO : IDAO
    {
        public ArrayList all ()
        {
            ArrayList lista = new ArrayList ();
            Medico medico;
            BancoDeDados bd = new BancoDeDados ();

            string sql = "select * from medicos";
            MySqlCommand cmd = new MySqlCommand(sql, bd.conectar());

            try
            {
                MySqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    medico = new Medico ();
                    medico.codm = int.Parse(dr[0].ToString());
                    medico.nome = dr[1].ToString();
                    medico.idade = int.Parse(dr[2].ToString());
                    medico.especialidade = dr[3].ToString();
                    medico.cpf = dr[4].ToString();
                    medico.cidade = dr[5].ToString();

                    int teste = 0;
                    int.TryParse(dr[6].ToString(), out teste); 
                    medico.nroa = teste;


                    lista.Add (medico);
                }
                dr.Close ();
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
