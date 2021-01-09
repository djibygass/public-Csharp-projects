using System;

namespace FirstApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] entiers = {1,2,3};
            
            string[] chaines;
            chaines = new string[10];
            Console.WriteLine("la valeur du premier element est de entier : " + entiers[0]);
            Console.WriteLine("la valeur du premier element est de chaine : " + chaines[0]);

            foreach (int entier in entiers)
            {
                Console.WriteLine(entier);
            }
            int[,] image = new int[32, 16];
            image[1, 5] = 30;
            for (int i = 0; i< image.GetLength(0); i++)
            {
                for (int j = 0; j < image.GetLength(1); j++)
                {
                    if (image[i, j] != 0)
                    {
                        Console.WriteLine("La valeur de" + i + "," + j + "est de :"+image[i, j]);
                    }
                }
            }
        }
    }
  

}
