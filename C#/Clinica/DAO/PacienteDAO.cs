using MySql.Data.MySqlClient;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clinica
{
    internal class PacienteDAO : IDAO
    {
        public ArrayList all ()
        {
            ArrayList lista = new ArrayList();
            Paciente paciente;
            BancoDeDados bd = new BancoDeDados();

            string sql = "select * from pacientes order by codp desc";
            MySqlCommand cmd = new MySqlCommand(sql, bd.conectar());

            try
            {
                MySqlDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    paciente = new Paciente();
                    paciente.codp = int.Parse(rdr[0].ToString());
                    paciente.nome = rdr[1].ToString();
                    paciente.idade = int.Parse(rdr[2].ToString());
                    paciente.cpf = rdr[3].ToString();
                    paciente.cidade = rdr[4].ToString();
                    paciente.doenca = rdr[5].ToString();

                    lista.Add(paciente);
                }
                rdr.Close();
            }
            catch
            {
                throw;
            }
            return lista;
        }



        public object create (object objeto)
        {
            Paciente paciente = (Paciente)objeto;
            BancoDeDados bd = new BancoDeDados();
            MySqlConnection conn = bd.conectar();
            MySqlCommand cmd = new MySqlCommand();

            try
            {
                cmd.Connection = conn;

                cmd.CommandText = "insert into pacientes (nome, idade, cidade, cpf, doenca) values (@nome, @idade, @cidade, @cpf, @doenca)";
                cmd.Prepare();

                cmd.Parameters.AddWithValue("@nome", paciente.nome);
                cmd.Parameters.AddWithValue("@idade", paciente.idade);
                cmd.Parameters.AddWithValue("@cidade", paciente.cidade);
                cmd.Parameters.AddWithValue("@cpf", paciente.cpf);
                cmd.Parameters.AddWithValue("@doenca", paciente.doenca);
                cmd.ExecuteNonQuery();
                int id = int.Parse(cmd.LastInsertedId.ToString());
                paciente.codp = id;
            }
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {
                throw ex;
            }
            return paciente;
        }

        public object delete (object chave)
        {
            Paciente paciente = (Paciente)chave;
            BancoDeDados bd = new BancoDeDados();
            MySqlConnection conn = bd.conectar();
            MySqlCommand cmd = new MySqlCommand();

            try
            {
                cmd.Connection = conn;
                cmd.CommandText = "delete from pacientes where codp=@codp";
                cmd.Prepare();
                cmd.Parameters.AddWithValue("@codp", paciente.codp);
                cmd.ExecuteNonQuery();
            }
            catch(MySql.Data.MySqlClient.MySqlException ex)
            {
                throw ex;
            }
            return paciente;
        }

        public object read (object chave)
        {
            throw new NotImplementedException();
        }

        public object update (object objeto)
        {
            Paciente paciente = (Paciente)objeto;
            BancoDeDados bd = new BancoDeDados();
            MySqlConnection conn = bd.conectar();
            MySqlCommand cmd = new MySqlCommand();

            try
            {
                cmd.Connection = conn;

                cmd.CommandText = "update pacientes set nome=@nome, idade=@idade, cidade=@cidade, cpf=@cpf, doenca=@doenca where codp=@codp";
                cmd.Prepare();

                cmd.Parameters.AddWithValue("@nome", paciente.nome);
                cmd.Parameters.AddWithValue("@idade", paciente.idade);
                cmd.Parameters.AddWithValue("@cidade", paciente.cidade);
                cmd.Parameters.AddWithValue("@cpf", paciente.cpf);
                cmd.Parameters.AddWithValue("@doenca", paciente.doenca);
                cmd.Parameters.AddWithValue("@codp", paciente.codp);
                cmd.ExecuteNonQuery();

            }
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {
                throw ex;
            }
            return paciente;
        }
    }
}
