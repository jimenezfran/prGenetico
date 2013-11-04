using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prGenetico
{
    class Poblacion
    {
        private Individuo[] individuos;


        int NumIndividuos { get { return individuos.Length; } }
        Individuo this[int i] { get { return individuos[i]; } }

        public Individuo MejorIndividuo()
        {
            int mayorFitness = 0;
            for (int i = 0; i < individuos.Length; i++)
            {
                if (individuos[i].Fitness > mayorFitness) { mayorFitness = i; }
            }

            return individuos[mayorFitness];
        }

        public Poblacion(int tP, int tI, IProblema pr)
        {
            individuos = new Individuo[tP];

            for (int i = 0; i < individuos.Length; i++)
            {
                individuos[i] = new Individuo(tI, pr);
            }
        }

        public void Reemplaza(Individuo individuo)
        {
            int menorFitness = individuo.Cromosoma.Longitud;
            for (int i = 0; i < individuos.Length; i++)
            {
                if (individuos[i].Fitness < menorFitness) { menorFitness = i; }
            }

            if (individuos[menorFitness].Fitness < individuo.Fitness)
            {
                individuos[menorFitness] = individuo;
            }

        }
    }
}
