using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prGenetico
{
     class OneMax:IProblema
    {
        
        public double Evalua(Cromosoma cr)
        {
            double res = 0;
            for(int i=0;i<cr.Longitud;i++)
            {
                res += cr.datos[i];
            }
            return res;
        }
    }
}
