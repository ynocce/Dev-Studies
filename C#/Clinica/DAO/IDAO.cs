using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clinica
{
    public interface IDAO
    {
        ArrayList all ();
        Object create (object objeto);
        Object read (object chave);
        Object update (object objeto);
        Object delete (object chave);

    }
}
