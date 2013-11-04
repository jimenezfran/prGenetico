using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prGenetico
{
    abstract class AlgoritmoGenetico
    {

        #region Fields

        Poblacion poblacion;
        IProblema problema;
        private int pasos;
        private double probMutacion;

        #endregion

        #region Methods

        public AlgoritmoGenetico(int tP, int tI, int np, double pMut, IProblema pr)
        {
            poblacion = new Poblacion(tP, tI, pr);
            problema = pr;
            probMutacion = pMut;
            pasos = np;
        }

        public Individuo Ejecuta()
        {
            Random rand = new Random();
            int indA = 0, indB = 0;
            Cromosoma recombinado;
            Individuo nuevoIndividuo;
            // Repetir 'pasos' veces:
            for (int i = 0; i < pasos; i++)
            {
                // Seleccionar dos individuos aleatoriamente. 
                indA=rand.Next(poblacion.NumIndividuos);
                do
                {
                  indB = rand.Next(poblacion.NumIndividuos);
                } while (indA == indB);
                // Tomar sus cromosomas y recombinarlos usando void Recombinar(cr1,cr2)
                recombinado = Recombinar(poblacion[indA].Cromosoma, poblacion[indB].Cromosoma);

                // Mutar el resultado con la probabilidad indicada.
                recombinado.Mutar(probMutacion);

                // Crear un individuo con el cromosoma resultante que se insertará en la población reemplazando al peor individuo
                nuevoIndividuo = new Individuo(recombinado, problema);
                poblacion.Reemplaza(nuevoIndividuo);

            }
            // Devolver el mejor individuo de la población después de la terminación del bucle
            return poblacion.MejorIndividuo();
        }

        public abstract Cromosoma Recombinar(Cromosoma cr1, Cromosoma cr2);
        
        #endregion
    }
}
