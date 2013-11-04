using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prGenetico
{
    class Program
    {
        static void Main(string[] args)
        {

            //OneMax problema1=new OneMax();
            //// TEST  clase Coromosoma
            //Cromosoma cromo = new Cromosoma(10, false);
            //Cromosoma cromo2 = new Cromosoma(10, true);
            //Cromosoma cromo3 = cromo2.Copia();

            //cromo.Mutar(90);

            //// TEST individuo
            
            //Individuo individuo = new Individuo(10, problema1);

            //Console.WriteLine(individuo.ToString());

            //// TEST poblacion

            //Poblacion poblacion = new Poblacion(3, 2, problema1);

            //Individuo mejor = poblacion.MejorIndividuo();

            //poblacion.Reemplaza(mejor);

            //Console.ReadKey();

          
            const int TAM_POBLACION = 20;
            const int PASOS_GA = 400;
            const int LONG_CROMOSOMA = 50;
            const double PROB_MUT = 0.02;

            IProblema problema = new OneMax();
            AlgoritmoGenetico ga1 = new AGUnPunto(TAM_POBLACION, LONG_CROMOSOMA, PASOS_GA, PROB_MUT, problema);
            Individuo solucion1 = ga1.Ejecuta();
            Console.WriteLine("Solución 1:" + solucion1);
            AlgoritmoGenetico ga2 = new AGUniforme(TAM_POBLACION, LONG_CROMOSOMA, PASOS_GA, PROB_MUT, problema);
            Individuo solucion2 = ga2.Ejecuta();
            Console.WriteLine("Solución 2:" + solucion2);


            Console.ReadKey();


        }
    }
}
