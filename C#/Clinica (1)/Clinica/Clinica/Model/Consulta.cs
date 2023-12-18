using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clinica
{
    internal class Consulta
    {
        public int codm { get; set; }
        public int codp { get; set; }
        public DateTime data { get; set; }
        public string hora { get; set; }

        public override string ToString ()
        {
            return codm + "\n" +
                codp + "\n" +
                data + "\n" +
                hora + "\n";
        }
    }
}
