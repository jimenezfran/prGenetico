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

            OneMax problema1=new OneMax();
            // Comprueba la clase Coromosoma
            Cromosoma cromo = new Cromosoma(10, false);
            Cromosoma cromo2 = new Cromosoma(10, true);
            Cromosoma cromo3 = cromo2.Copia();


            cromo.Mutar(90);

            // Testeando individuo
            
            Individuo individuo = new Individuo(10, problema1);


            Console.ReadKey();
        }
    }
}
