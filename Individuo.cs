using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prGenetico
{
    class Individuo
    {
        #region Fields
        private double fitness;
        private Cromosoma cromosoma;
        #endregion


        #region Properties
        public  Cromosoma Cromosoma { get { return this.cromosoma; }  }
        public double Fitness { get { return this.fitness; } }

        #endregion

        #region Methods
        public Individuo(Cromosoma cr, IProblema pr)
        {
            cromosoma = cr.Copia();
            fitness = pr.Evalua(cromosoma);
        }
        
        public Individuo(int tam, IProblema pr)
        {
            cromosoma = new Cromosoma(tam, true);
            fitness = pr.Evalua(cromosoma);
        }
        public override string ToString()
        {
           // return "Cromosoma: "+cromosoma.datos+"Fitness: "+fitness.ToString();
            
            var builder = new StringBuilder();
            Array.ForEach(cromosoma.datos, x => builder.Append(x));
            var res = builder.ToString();

            return "Cromosoma: " + res + " Fitness: " + fitness.ToString();

        }
        #endregion
    }
}
