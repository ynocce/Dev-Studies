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
    public partial class ConsultasEditar : Form
    {
        public ConsultasEditar (object consulta)
        {
            InitializeComponent();

            Consulta c = (Consulta)consulta;

            this.codmValor.Text = c.codm.ToString();
            this.codpValor.Text = c.codp.ToString();
            this.dataValor.Text = c.data.ToString();
            this.horaValor.Text = c.hora;

        }

        private void voltarBtn_Click (object sender, EventArgs e)
        {
            this.Close();
            Inicio tela = new Inicio();
            tela.Show();
        }

        private void salvarBtn_Click (object sender, EventArgs e)
        {




            this.Close ();
            Consultas tela = new Consultas();
            tela.Show ();
        }

        private void ConsultasEditar_Load (object sender, EventArgs e)
        {

        }

        private void label1_Click (object sender, EventArgs e)
        {

        }
    }
}
