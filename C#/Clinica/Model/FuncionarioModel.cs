using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clinica
{
    internal class FuncionarioModel
    {
        public int codf { get; set; }
        public string nome { get; set; }
        public int idade { get; set; }
        public string cpf { get; set; }
        public string cidade { get; set; }
        public double salario { get; set; }
        public string cargo { get; set; }

        public override string ToString ()
        {
            return this.codf + "\n" +
                this.nome + "\n" +
                this.idade + "\n" +
                this.cpf + "\n" +
                this.cidade + "\n" +
                this.salario + "\n" +
                this.cargo + "\n";
        }
    }
}
