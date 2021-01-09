using System;

namespace Tptableaux
{
    class Program
    {
        static void Main(string[] args)
        {
            string r;
            int[] tableau = new int[5];
            do
            {
                Console.WriteLine("Commande?");
                r = Console.ReadLine();

                switch (r)
                {
                    case "e":
                        int entier;
                        int position = 0;
                        while (position<5)
                        {
                            Console.WriteLine("Veuillez entrer l'entier numéro (" + (position+1) +") : ");
                            var entre = Console.ReadLine();
                            bool checkit = Int32.TryParse(entre, out entier);
                            if (checkit == true)
                            {
                                tableau[position] = entier;
;                                position++;
                            }
                            else
                            {
                                Console.WriteLine("Veuillez entrer un entier svp ! ");
                            }


                            /*try
                            {
                                int checkit = int.Parse(entre);
                            }catch(Exception e)
                            {
                                Console.WriteLine("Veuillez entre l'entier svp : ");
                            }*/
                        }
                        for (int i = 0; i < tableau.Length; i++)
                        {
                            Console.WriteLine(tableau[i]+" de position "+i);
                        }
                        break;
                    case "d":
                        for (int i = 0; i < tableau.Length; i++)
                        {
                            Console.WriteLine(tableau[i] + " de position " + i);
                        }
                        break;
                    case "s":
                        Array.Sort(tableau);
                        for (int i = 0; i < tableau.Length; i++)
                        {
                            Console.WriteLine(tableau[i] + " de position " + i);
                        }
                        break;
                    case "r":
                        Array.Reverse(tableau);
                        for (int i = 0; i < tableau.Length; i++)
                        {
                            Console.WriteLine(tableau[i] + " de position " + i);
                        }
                        break;


                }
            } while (r != "q");

        }
    }
}
