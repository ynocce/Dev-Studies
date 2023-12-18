using MySql.Data.MySqlClient;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clinica
{
    internal class ConsultaDAO : IDAO
    {
        public ArrayList all ()
        {
            ArrayList lista = new ArrayList();
            Consulta consulta;
            BancoDeDados bd = new BancoDeDados();

            string sql = "select * from consultas";
            MySqlCommand cmd = new MySqlCommand(sql, bd.conectar());

            try
            {
                MySqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    consulta = new Consulta();

                    consulta.codm = int.Parse(dr[0].ToString());
                    consulta.codp = int.Parse(dr[1].ToString());
                    consulta.data = DateTime.Parse(dr[2].ToString());
                    consulta.hora = dr[3].ToString();

                    lista.Add(consulta);
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
