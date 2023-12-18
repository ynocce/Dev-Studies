using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clinica
{
    internal class Medico
    {
        public int codm { get; set; }
        public string nome { get; set; }
        public int idade { get; set; }
        public string especialidade { get; set; }
        public string cpf { get; set; }
        public string cidade { get; set; }
        public int nroa { get; set; }

        public override string ToString ()
        {
            return this.codm+"\n"+
                this.nome + "\n" +
                this.idade + "\n" +
                this.especialidade + "\n" +
                this.cpf + "\n" +
                this.cidade + "\n" +
                this.nroa + "\n";
            
        }
    }



}
