using System;

namespace JustePrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int joueur1()
            {

                //joueur 1 rentre un montant
                Console.WriteLine("Joueur 1 : Saisissez le monatant à deviner ");
                String saisie = Console.ReadLine();
                bool checkit = Int32.TryParse(saisie, out int montant1);
                while (checkit == false)
                {
                    Console.WriteLine("Veuillez à bien rentrer un entier !!!!!");
                    Console.WriteLine("Joueur 1 : Saisissez le monatant à deviner ");
                    saisie = Console.ReadLine();
                    checkit = Int32.TryParse(saisie, out montant1);
                }
                return montant1;
            }
            int joueur2()
            {
                //joueur 2 rentre un montant à son tour
                Console.WriteLine("Joueur 2 : Entrer une proposition ");
                String saisie = Console.ReadLine();
                bool checkit = Int32.TryParse(saisie, out int montant2);
                while (checkit == false)
                {
                    Console.WriteLine("Veuillez à bien rentrer un entier !!!!!");
                    Console.WriteLine("Joueur 2 : Entrer une proposition ");
                    saisie = Console.ReadLine();
                    checkit = Int32.TryParse(saisie, out montant2);
                }
                return montant2;
            }

            Console.WriteLine("Bienvenue sur le juste prix");
            //joueur 1 rentre un montant
            int montant1=joueur1();
            int montant2=joueur2();

            int tentatives = 20;
            bool ok = false;
            while (tentatives!=0)
            {
                if (montant1 == montant2)
                {
                    Console.WriteLine("Bravo ! le montant était bien" + montant2);
                    ok = true;
                    break;
                }
               else if (montant1>montant2)
                {
                    tentatives--;
                    Console.WriteLine("Non c'est  plus de " + montant2);
                    Console.WriteLine("Il vous reste " + tentatives +" tentatives");
                    montant2 = joueur2();
                }
                else
                {
                    tentatives--;
                    Console.WriteLine("Non c'est moins de " + montant2);
                    Console.WriteLine("Il vous reste " + tentatives + " tentatives");
                    montant2 = joueur2();
                }
            }
            if (ok == false)
            {
                Console.WriteLine("Dommage vous avez perdu !");
            }
        }
    
     
    }
}
