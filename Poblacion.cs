using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prGenetico
{
    class Poblacion
    {
        #region Fields
        private Individuo[] individuos;
        #endregion

        #region Properties
        int NumIndividuos { get { return individuos.Length; } }
        Individuo this[int i] { get { return individuos[i]; } }
        #endregion

        #region Methods
        /// <summary>
        /// Devuelve el individuo con mayor fitness de la poblacion.
        /// Si existe mas de uno devuelve el primero encontrado.
        /// </summary>
        /// <returns>Mejor individuo</returns>
        public Individuo MejorIndividuo()
        {
            int mayorFitness = 0;
            for (int i = 0; i < individuos.Length; i++)
            {
                if (individuos[i].Fitness > mayorFitness) { mayorFitness = i; }
            }

            return individuos[mayorFitness];
        }

        /// <summary>
        /// Crea un array de Individuos de tamano tP.
        /// </summary>
        /// <param name="tP">Numero de individuos de la publiacion</param>
        /// <param name="tI">Longitud del cromosoma de los individuos</param>
        /// <param name="pr">Metodo a usar para calcular el fitness de cada individuo</param>
        public Poblacion(int tP, int tI, IProblema pr)
        {
            individuos = new Individuo[tP];

            for (int i = 0; i < individuos.Length; i++)
            {
                individuos[i] = new Individuo(tI, pr);
            }
        }

        /// <summary>
        /// Busca el peor individuo de la poblacion y lo reemplaza por el individuo
        /// pasado como parametro.
        /// </summary>
        /// <param name="individuo">Individuo reemplazante</param>
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
        #endregion
    }
}
