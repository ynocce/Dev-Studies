using System;
using System.Collections;
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
    public partial class Consultas : Form
    {
        public Consultas ()
        {
            InitializeComponent();
            
        }
        public Consultas (ArrayList consultas)
        {
            InitializeComponent();
            int x = 0;

            foreach (Consulta c in consultas)
            {
                listagem.Rows.Add();

                this.listagem.Rows[x].Cells[0].Value = c.codm;
                this.listagem.Rows[x].Cells[1].Value = c.codp;
                this.listagem.Rows[x].Cells[2].Value = c.data;
                this.listagem.Rows[x].Cells[3].Value = c.hora;

                x++;

            }
        }

        private void novaBtn_Click (object sender, EventArgs e)
        {
            this.Close ();  
            ConsultasCriar tela = new ConsultasCriar ();
            tela.Show();
        }

        private void voltarBtn_Click (object sender, EventArgs e)
        {
            this.Close();
            Inicio tela = new Inicio();
            tela.Show();
            
        }

        private void Consultas_Load (object sender, EventArgs e)
        {

        }

        private void buscaBtn_Click (object sender, EventArgs e)
        {

        }
    }
}
