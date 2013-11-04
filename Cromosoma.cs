using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prGenetico
{
     class Cromosoma
    {
         protected internal byte[] datos;
         public static Random rnd=new Random();


         public int Longitud {get{return datos.Length;} set{} }
         public byte this[int i] { get { return datos[i]; } set { datos[i] = value; } }

         /// <summary>
         /// Devuelve una copia del objeto que lo llama.
         /// </summary>
         /// <returns></returns>
         public Cromosoma Copia()
         {
             Cromosoma nuevoCromosoma = new Cromosoma(datos.Length,false);
             nuevoCromosoma.datos = datos;
             return nuevoCromosoma;
         }

         /// <summary>
         /// Crea un Cromosoma
         /// </summary>
         /// <param name="tam">Longitud del cromosoma</param>
         /// <param name="mod">false: todo a 0. true: aleatorio</param>
         public Cromosoma(int tam,bool mod)
         {
             if (tam <= 0)
             {
                 throw new Exception("Error: intenta crear un cromosoma de tamaño " + tam);
             }
             else
             {
                 datos=new byte[tam];

                 if (mod == false)
                 {
                     // Todo el cromosoma a 0
                     for (int i = 0; i < tam; i++)
                     {
                         datos[i] = (byte)(0);
                     }
                 }
                 else
                 {
                     // Cromosoma a valores aleatorios 0/1
                     for (int i = 0; i < tam; i++)
                     {
                         datos[i] = (byte)(rnd.Next(0,2));
                     }
                 }
             }
         }

         /// <summary>
         /// Muta los genes del cromosoma en funcion de la probabilidad de mutacion
         /// </summary>
         /// <param name="prop">Probabilidad en % [0-100]</param>
         public void Mutar(double prop)
         {
             int prob;
             if (prop > 100 || prop < 0)
             {
                 throw new Exception("Probabilidad invalida. Introduzca probabilidad [0-100]");
             }
             else
             {
                 for (int i = 0; i < datos.Length; i++)
                 {
                     prob = rnd.Next(0, 101); // Cuanto mayor la probabilidad, mas numeros del intervalo estaran por debajo de ella
                     if (prob < prop)
                     {
                         // Muta el gen
                         if (datos[i] == 0) { datos[i] = 1; } else { datos[i] = 0; }
                     }
                 }
             }
         }


    }
}
