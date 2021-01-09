using System;

namespace HangmanGame
{
    class Program
    {
        static void Main(string[] args)
        {
            // index of the game
            Console.WriteLine("Bienvenue sur le jeu du Pendu\n Saisissez le mot à deviner");
            string his_word = Console.ReadLine();

            string hiddenWord = "";
            // the length shoul be equal 5
            while (his_word.Length<5)
            {
                Console.WriteLine("Le nombre de charactère de votre mot doit être supérieur à 5");
                his_word = Console.ReadLine();
                
            }
            // the (*******) word
            for( int i=0; i<his_word.Length; i++)
            {
                 hiddenWord += "*";
                
            }
           // print the '******'
            Console.WriteLine(hiddenWord);
            
            int essai = 7;//Max try

            //transform the "*******" to ['*','*','*','*','*'] (new var thiddenWord)
            Char[] thiddenWord = hiddenWord.ToCharArray();
            //transform the ['*','*','*','*','*'] to  "*******" (new var final)
            string final = new string(thiddenWord);
            //handle the 7 'essai'
            while (essai != 0)
            {
                // show number of tests(essai) remaining and ask for a letter
                Console.WriteLine("Nombre d'essai : "+essai);
                Console.WriteLine("Proposez une lettre");
                String letter = Console.ReadLine();
                essai--;
                bool ok = true;
                for (int i = 0; i < his_word.Length; i++)
                {
                    
                    if (his_word[i].ToString() == letter)
                    {
                        thiddenWord[i] =  letter[0];
                       
                        ok = false;
                    }
                  
                }
               if(ok)
                {
                    Console.WriteLine("La lettre saisie ne se trouve pas dans le mot ");
                }
                else
                {
                    Console.WriteLine("La lettre saisie se trouve dans le mot ");
                }
                Console.WriteLine(thiddenWord);
                final = new string(thiddenWord);
                if (his_word == final)
                {
                    Console.WriteLine("Bravo vous avait gagné !! ");
                    break;
                }
            }
             
            if (his_word != final)
            {
                Console.WriteLine("DSL vous avec perdu !! ");
                
            }


        }

    }
}
