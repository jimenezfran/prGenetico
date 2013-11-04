using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prGenetico
{
    class AGUnPunto:AlgoritmoGenetico
    {
        public AGUnPunto(int tP, int tI, int np, double pMut, IProblema pr):base(tP,tI,np,pMut,pr)
        {
        }

        public override Cromosoma Recombinar(Cromosoma cr1, Cromosoma cr2)
        {
            if (cr1.Longitud != cr2.Longitud) { throw new Exception("Intenta recombinar cromosomas de distinta longitud"); }

            else
            {
                Random rnd = new Random();
                int punto = rnd.Next(cr1.Longitud);
                Cromosoma nuevoCromosoma = new Cromosoma(cr1.Longitud, false);

                for (int i = 0; i < punto; i++)
                {
                    nuevoCromosoma[i] = cr1[i];
                }
                for (int i = punto; i < cr1.Longitud; i++)
                {
                    nuevoCromosoma[i] = cr2[i];
                }

                return nuevoCromosoma;
            }
        }
    }
}
