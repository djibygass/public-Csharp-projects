using System;

namespace test
{
    class Program
    {
        static void Main(string[] args)
        {
     
            string generateNbrs(int nbpart)
            {
                var rand = new Random();
                string ch = "";
                for (int ctr = 1; ctr <= 3; ctr++)  ch += rand.Next(nbpart);
                Console.WriteLine();

                return ch;
            }
            string rdstr = generateNbrs(5);
            bool checkdupclat(string str)
            {

                foreach (Char a in str)
                {
                    int count = 0;
                    foreach (Char b in str)
                    {
                        if (a == b)
                        {
                            count++;
                        }
                    }
                    if ((count == 2) | (count == 3))
                    {
                        return false;

                    }
                }
                return true;
            }
            while (checkdupclat(rdstr) == false)
            {
                rdstr = generateNbrs(5);
                Console.WriteLine("-----");
            }
            Console.WriteLine(rdstr);

        }
    }
}
