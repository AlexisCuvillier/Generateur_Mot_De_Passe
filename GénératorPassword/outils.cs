using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FomationCS
{

    // FomationCS.outils.DemanderNOmbrePositifNonNull
    static class outils
    {
      public static int DemanderNOmbrePositifNonNull(string question)
        {
            return DemanderNombreEntre(question, 1, int.MaxValue, "ERROR : le nombre doit être positif et non nul");

            /* int nombre = DemanderNombre(question);

              if(nombre > 0)
              {
                  return(nombre);
              }
              Console.WriteLine("ERREUR : Le nombre doit être supèrieur à 0");
              return DemanderNOmbrePositifNonNull(question); */
        }

      public static int DemanderNombreEntre(string question, int min, int max, string messageErreurPersonnalise = null)
        {

            //     while(true)
            //   {

            int nombre = DemanderNombre(question);

            if ((nombre >= min) && (nombre <= max))
            {
                // valide
                return nombre;
            }
            if (messageErreurPersonnalise == null)
            {
            Console.WriteLine("ERREUR : Le nombre doit être compris entre " + min + " et " + max);
            Console.WriteLine();
            }
            else
            {
                Console.WriteLine(messageErreurPersonnalise);
            }
           
            return DemanderNombreEntre(question, min, max);


            //     }


        }

      public static int DemanderNombre(string question)
        {
            while (true)
            {

                Console.Write(question);
                string response = Console.ReadLine();

                try
                {
                    int responseInt = int.Parse(response);
                    return responseInt;
                }
                catch
                {
                    Console.WriteLine("Entrez un nombre correct");
                }


            }






        }
    }
}
