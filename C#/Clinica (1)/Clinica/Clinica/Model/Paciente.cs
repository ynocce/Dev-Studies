using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clinica
{
    internal class Paciente
    {
        public int codp { get; set; }
        public string nome { get; set; }
        public int idade { get; set; }
        public string cidade { get; set; }
        public string cpf { get; set; }
        public string doenca { get; set; }

        public override string ToString ()
        {
            return this.codp + "\n" +
                this.nome + "\n" +
                this.idade + "\n" +
                this.cidade + "\n" +
                this.cpf + "\n";
                
        }
    }
}
