using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prGenetico
{
    interface IProblema
    {
        double Evalua(Cromosoma cr);
    }
}
