using System;
using System.Collections.Generic;
using System.Linq;

namespace Partie4_Ex4
{
    class Program
    {
        static void Main(string[] args)
        {

            List<int> numbers = new List<int>();
            int number, result;
            string resp = "o";

            while (resp == "o")
            {
                Console.WriteLine("ajouter un nombre à multiplier : ");
                number = Convert.ToInt32(Console.ReadLine());
                numbers.Add(number);

                Console.WriteLine("voulez-vous ajouter un autre nombre à multipier ? O/N");
                resp = Console.ReadLine().ToLowerInvariant();

            }

            result = numbers.Aggregate(1, (x, y) => x * y);
            Console.WriteLine("le résultat est {0}", result);

            string usednb = string.Join("*", numbers);
            Console.WriteLine(usednb);




        }
    
        }
    }



/* trop long utiliser la fonction agregate
 * List<int> myList = new List<int>();
            int nb = 0;
            int multi = 1;
            int nbUser;
            string answer;

            do
            {


                Console.WriteLine("ajouter un nombre");
                nbUser = Convert.ToInt32(Console.ReadLine());
                myList.Insert(nb, nbUser);
                Console.WriteLine("vouslez vous continuer ?");
                answer = Console.ReadLine();
                multi *= nbUser;
                nb++;

            }

            while (answer!="non");

            Console.WriteLine("votre list comprend ces valeurs");
            for (nb = 0; nb < myList.Count; nb++)
            {

                Console.WriteLine(myList[nb]);

            }


            Console.WriteLine($"la multiplication de ces valeurs vaut {multi}");
*/ 