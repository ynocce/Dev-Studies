using Clinica;
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
    public partial class Inicio : Form
    {
        public Inicio ()
        {
            InitializeComponent();
            this.Show();
            
        }

        private void Form1_Load (object sender, EventArgs e)
        {

        }

        private void label1_Click (object sender, EventArgs e)
        {

        }

        private void pacienteBtn_Click (object sender, EventArgs e)
        {
            PacienteController pacienteController = new PacienteController ();
            pacienteController.listar();
            this.Hide();
        }

        private void medicoBtn_Click (object sender, EventArgs e)
        {
            MedicoController medicoController = new MedicoController ();
            medicoController.listar();
            this.Hide ();
        }

        private void funcionarioBtn_Click (object sender, EventArgs e)
        {
            FuncionarioController funcionarioController = new FuncionarioController ();
            funcionarioController.listar ();
            this.Hide();
        }

        private void consultaBtn_Click (object sender, EventArgs e)
        {
            ConsultaController consultaController = new ConsultaController ();
            consultaController.listar ();
            this.Hide();
        }
    }
}
