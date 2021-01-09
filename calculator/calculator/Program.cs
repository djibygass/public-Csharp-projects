using System;

namespace calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bienvenue sur la calculatrice ;)");
            Console.WriteLine("Que voulez-vous faire comme calcul ? (+,-,*,/)");
            string op = Console.ReadLine();
            string nb2;
            string nb1;
            switch (op)
            { 
                case "+":
                    Console.WriteLine("number1 ?");
                    nb1 = Console.ReadLine();
                    Console.WriteLine("number2 ?");
                    nb2 = Console.ReadLine();
                    Console.WriteLine(nb1 + " + " + nb2 + " = " + (Convert.ToInt32(nb1) + Convert.ToInt32(nb2)));
                    break;
                case "-":
                    Console.WriteLine("number1 ?");
                    nb1 = Console.ReadLine();
                    Console.WriteLine("number2 ?");
                    nb2 = Console.ReadLine();
                    Console.WriteLine(nb1 + " - " + nb2 + " = " + (Convert.ToInt32(nb1) - Convert.ToInt32(nb2)));
                    break;
                case "*":
                    Console.WriteLine("number1 ?");
                    nb1 = Console.ReadLine(); 
                    Console.WriteLine("number2 ?");
                    nb2 = Console.ReadLine();
                    Console.WriteLine(nb1 + " * " + nb2 + " = " + (Convert.ToInt32(nb1) * Convert.ToInt32(nb2)));
                    break;
                case "/":
                    Console.WriteLine("number1 ?");
                    nb1 = Console.ReadLine();
                    Console.WriteLine("number2 ?");
                    nb2 = Console.ReadLine();
                    Console.WriteLine(nb1+" / "+nb2 +" = "+ (Convert.ToInt32(nb1) / Convert.ToInt32(nb2)));
                    break;



            }
        }
    }
}
