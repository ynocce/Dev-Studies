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
    public partial class ConsultasCriar : Form
    {
        public ConsultasCriar ()
        {
            InitializeComponent();
        }

        private void voltarBtn_Click (object sender, EventArgs e)
        {
            this.Close();
            Consultas tela = new Consultas ();
            tela.Show();
            
        }

        private void salvarBtn_Click (object sender, EventArgs e)
        {
            Consulta consulta = new Consulta ();

            consulta.codm = int.Parse(this.codmValor.Text);
            consulta.codp = int.Parse(this.codpValor.Text);
            consulta.data = DateTime.Parse(this.dataValor1.Text);
            consulta.hora = this.horaValor.Text;

            this.Close();
            ConsultasEditar tela = new ConsultasEditar (consulta);
            tela.Show();
        }

        private void dataValor1_ValueChanged (object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
