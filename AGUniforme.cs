using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prGenetico
{
    class AGUniforme:AlgoritmoGenetico
    {
         public AGUniforme(int tP, int tI, int np, double pMut, IProblema pr):base(tP,tI,np,pMut,pr)
        {
        }

        public override Cromosoma Recombinar(Cromosoma cr1, Cromosoma cr2)
        {
            if (cr1.Longitud != cr2.Longitud) { throw new Exception("Intenta recombinar cromosomas de distinta longitud"); }

            else
            {
                Random rnd = new Random();
                int padre = 0;
                Cromosoma nuevoCromosoma = new Cromosoma(cr1.Longitud, false);

                for(int i=0;i<cr2.Longitud;i++)
                {
                    padre = rnd.Next(2); // Si padre=0 -> Toma el gen de cr1; padre=1-> Toma el de cr2
                    if (padre == 0)
                    {
                        nuevoCromosoma[i] = cr1[i];
                    }
                    else
                    {
                        nuevoCromosoma[i] = cr2[i];
                    }
                }

                return nuevoCromosoma;
            }
        }
    }
}
