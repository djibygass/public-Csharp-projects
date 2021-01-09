using System;

namespace JeuLoupGarou
{
    class Program
    {
        static void Main(string[] args)
        {

            // variables
            string[][] ArrJR = new string[2][];
            string prenoms;

            //Fonctions

                //retourne false si la valeur rentrer n'est pas un int et true dans le cas contraire
            bool verifint(string nb)
            {
                return Int32.TryParse(nb, out int nbr);
            }
                //conversion str -> int
            int convertstrtoint(string nb)
            {
                return Convert.ToInt32(nb);
            }
                //verifie qu'il n'y a pas de duplicat ou plusieur de Char dans un str 
            bool checkdupclatstr(string str)
            {
                //copie et transformation du str en tableau
                string[] tab1 = str.Split(' ');
                string[] tab2 = str.Split(' ');

                //compare les element des 2 tableau
                for (int i = 0; i < tab1.Length; i++)
                {
                    int count = 0;
                    for(int j = 0; j < tab2.Length; j++)
                    {
                        if (tab1[i] == tab2[j])
                        {
                            count++;
                        }
                    }
                    if (count > 1)
                    {
                        return false;
                    }
                }
                return true;
            }


            //retourne un string composant 3 chiffres aléatoire entre 0 et nbParticipant
            string Randomindex(int nbpart)
            {
                //genere aléatoirement 3 chiffres de 0 au nbr de participant
                string generateNbrs()
                {
                    var rand = new Random();
                    string ch = "";
                    for (int ctr = 1; ctr <= 3; ctr++) ch += rand.Next(nbpart);
                   
                    return ch;
                }
                string rdstr = generateNbrs();

                //verifie ou s'assure que y'aura pas le mm chiffre 2 ou 3 fois
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
                    rdstr = generateNbrs();
                }
                return rdstr;
            }





            //retourne les joueurs associer à leur role
            string[][] JoueurRole()
            {
                Console.WriteLine("Rentrer le nombre de Participants : ");
                string nbParticipant = Console.ReadLine();
                //le tableau dans lequel y'aura le tableau des prenoms et le tableau des roles
                string[][] JoueurRoleTab = new string[2][];

                if (verifint(nbParticipant) == true)
                {
                   if ((convertstrtoint(nbParticipant) >= 5))
                   { 
                        //tableau des prenom des joueurs
                        string[] JoueurTab = new string[convertstrtoint(nbParticipant)];
                        //tableau des roles
                        string[] RoleTab = new string[convertstrtoint(nbParticipant)];

                        // met les prenom des joueurs dans le tableau JoueurTab
                        String prenomrecup()
                        {
                            prenoms = "";
                            int i = 0;
                            while (i < convertstrtoint(nbParticipant))
                            {
                                // attention aux  "" et les mm nom qui se rèpete 
                                Console.WriteLine("Rentrer le prénom du joueur" + (i + 1));
                                String prenomJoueur = Console.ReadLine();

                                if ((prenomJoueur.Trim().Length == 0) | (verifint(prenomJoueur) == true))
                                {
                                    Console.WriteLine("Merci de rentre des prénoms valide !!! ");
                                    prenomrecup();
                                    break;
                                }
                                else
                                {
                                    prenoms += prenomJoueur + " ";
                                }
                                i++;
                            }

                            if (checkdupclatstr(prenoms) == false)
                            {
                                Console.WriteLine("\nMerci de Rentrer des Prénoms Différents !!\n");
                                prenomrecup();
                            }
                            return prenoms.TrimEnd();
                        }
                        JoueurTab = prenomrecup().Split(' ');

                        //int rdindex = convertstrtoint(Randomindex());
                        string rdindex = Randomindex(convertstrtoint(nbParticipant));
                        //Console.WriteLine(rdindex);
                        for (int i = 0; i<RoleTab.Length ;i++)
                        {
                            
                            string ii = i.ToString();
                            
                            if (ii == rdindex[0].ToString()) 
                            {
                                RoleTab[i] = "Voyante";
                            }
                            else if (ii == rdindex[1].ToString())
                            {
                                RoleTab[i] = "Loup";
                            }
                            else if (ii == rdindex[2].ToString())
                            {
                                RoleTab[i] = "Loup";
                            }
                            else
                            {
                                RoleTab[i] = "Villageois";
                            }

                        }

                        JoueurRoleTab[0] = RoleTab;
                        JoueurRoleTab[1] = JoueurTab;
                        //Console.WriteLine(JoueurRoleTab);
                        //Afficher le Tableau ;)
                        /*for (int i = 0; i < JoueurRoleTab.Length; i++)
                        {
                            System.Console.Write("Element({0}): ", i);

                            for (int j = 0; j < JoueurRoleTab[i].Length; j++)
                            {
                                System.Console.Write("{0}{1}", JoueurRoleTab[i][j], j == (JoueurRoleTab[i].Length - 1) ? "" : " ");
                            }
                            System.Console.WriteLine();
                        }*/
                    }
                   else
                   {
                       JoueurRole();
                   }
                }
                else
                {
                    JoueurRole();
                }

                //string[] test = new string[3];
                return ArrJR = JoueurRoleTab;

            }

            //fonction donnant les rôle
            void askRole()
            {
                string start = "";
                while (start != "go")
                {
                    Console.WriteLine("\nQui souhaite Connaître son rôle ? Tapez ('go') pour commencer le jeu.");

                    string name = Console.ReadLine();
                    bool yest = false;
           
                    for (int j = 0; j < ArrJR[0].Length; j++)
                    {
                        if (name == "go")
                        {
                            yest = true;
                            start = name;
                            break;
                        }
                        if (ArrJR[1][j] == name)
                        {
                            Console.WriteLine("\n" + name + " Vous êtes --> " + ArrJR[0][j] + ".\n Appuyer sur une touche pour effacer ;)");
                            yest = true;
                            Console.ReadKey(true);
                            Console.Clear();
                            Console.WriteLine("\n Les Participants sont : " + prenoms);
                        }
                    }
                    if (yest == false)
                    {
                        Console.WriteLine("\n" + name + ", Vous n'êtes pas participant");
                    }
                }
            }

            // debut du jeu ---> donne les roles à la voyante...
            void debutJeu()
            {
               
                for (int i = 0; i < ArrJR[1].Length; i++)
                {
                    //verifier si la voyante est bien dans le jeu : elle peut etre éliminer par les loups ou par le groupes.
                    bool yest = false;
                    if (ArrJR[0][i] == "Voyante") 
                    {
                        Console.WriteLine("\n La nuit tombe .... Fermez vos yeux\n");
                        Console.WriteLine(" ...\n ...\n ...\n");

                        prenoms = string.Join(" ", ArrJR[1]);
                        Console.WriteLine("\n Les Participants sont : " + prenoms);
                        Console.WriteLine("\nVoyante, Entrer le prenom de la personne dont vous souhaitez dévoiler la carte.");
                        String name = Console.ReadLine();
                       
                        for (int j = 0; j < ArrJR[1].Length; j++)
                        {
                            if (ArrJR[1][j] == name)
                            {
                                Console.WriteLine("\n"+name + " est " + ArrJR[0][j] + " appuyer sur une touche pour effacer et continuer ;)");
                                yest = true;
                                Console.ReadKey(true);
                                Console.Clear();
                            }
                        }
                        if (yest == false)
                        {
                            Console.WriteLine("\n" + name + ",  n'est pas participant");
                            debutJeu();
                        }
                    }
                }
            }
            // la nuit
            void loupstuent()
            {
                Console.WriteLine("Qui les loups ont-ils décidé de tuer ?");
                String nm = Console.ReadLine();
                bool yest = false;
                for (int j = 0; j < ArrJR[1].Length; j++)
                {
                    if (ArrJR[1][j] == nm)
                    {
                        yest = true;
                        if (ArrJR[0][j] == "Loup")
                        {
                            Console.WriteLine("Les loups sont les rois de la nuit !!");
                            loupstuent();
                        }
                        else
                        {
                            //Array.Clear(ArrJR[1],j, ArrJR[0].Length);
                            ArrJR[1][j] = ArrJR[1][j].Remove(0); 
                            Console.Clear();
                            Console.WriteLine("\n" + nm + ", était " + ArrJR[0][j] + " et a été tuer pendant la nuit ...");
                            ArrJR[0][j] = ArrJR[0][j].Remove(0);
                            yest = true;
                            break;
                        }
                    }
                }
                if (yest == false)
                {
                    Console.WriteLine("\n" + nm + ",  n'est pas participant");
                    loupstuent();
                }
            }
            // Le jour se lève les villageois (Afin s'il en reste toujours) éliminent un participant... 
            void villageSeConcerte()
            {
                bool villagedanslejeu = false;
                int count = 0;
                for (int i = 0; i < ArrJR[1].Length; i++)
                {
                   
                    if (ArrJR[0][i] == "Villageois")
                    {
                        count++;
                    }
                    if (count>1)
                    {
                        villagedanslejeu = true;
                        Console.WriteLine("\n...\nLe jour se lève\n");
                        Console.WriteLine("Qui le village souhait-il éliminer ?");
                        String nm = Console.ReadLine();
                        bool yest = false;
                        for (int j = 0; j < ArrJR[1].Length; j++)
                        {
                            if (ArrJR[1][j] == nm)
                            {
                                //Array.Clear(ArrJR[1],j, ArrJR[0].Length);
                                ArrJR[1][j] = ArrJR[1][j].Remove(0);
                                yest = true;
                                Console.Clear();
                                if (ArrJR[0][j] == "Loup")
                                {
                                    Console.WriteLine("\n" + nm + ", a été éliminer par le village ...");
                                    Console.WriteLine("\n Bravo , c'était bien un " + ArrJR[0][j]);
                                }
                                if (ArrJR[0][j] == "Voyante")
                                {
                                    Console.WriteLine("\n" + nm + ", a été éliminer par le village ...");
                                    Console.WriteLine("\n Pas de chance, c'était une " + ArrJR[0][j]);

                                }
                                if (ArrJR[0][j] == "Villageois")
                                {
                                    Console.WriteLine("\n" + nm + ", a été éliminer par le village ...");
                                    Console.WriteLine("\n Pas de chance, c'était un " + ArrJR[0][j]);
                                }
                                ArrJR[0][j] = ArrJR[0][j].Remove(0);
                            }
                        }
                        if (yest == false)
                        {
                            Console.WriteLine("\n" + nm + ",  n'est pas participant");
                            villageSeConcerte();
                        }
                    }
                      
                }
                if (villagedanslejeu == false)
                {
                    checkscore();
                }
            }
            // verifie si le jeu est fini ou pas
            void checkscore()
            {
                int countLoup = 0;
                int countVillageois = 0;
                for (int j = 0; j < ArrJR[1].Length; j++)
                {

                    if (ArrJR[0][j] == "Loup")
                    {

                        countLoup++;
                    }

                    if (ArrJR[0][j] == "Villageois")
                    {
                        countVillageois++;
                    }


                }
                if (countVillageois < countLoup)
                {
                    Console.WriteLine("\nLes Loups Garous Ont Gagnés !!!!!");
                }
                if (countVillageois >=  countLoup)
                {
                    letsgo();
                }
                if (countLoup == 0)
                {
                    Console.WriteLine("\nLes Villageois Ont Gagnés !!!!!");
                }
            }
            // déclenche le jeu
            void letsgo()
            {
                debutJeu();
                loupstuent();
                villageSeConcerte();
                checkscore();
            }


            //affichage - corps - appels de fonction

            //bienvenu & regles...
            Console.WriteLine("Bienvenu sur votre jeu de Loup Garou :) \n");

            Console.WriteLine("Voici les règles : \n" +
                " 1 - Il faut au minimum 5 joueurs \n" +
                " 2 - Les rôles seront attribués aléatoirement\n" +
                " 3 - Y-aura 2 Loups garou, 1 voyante et les autres seront des villageois.\n" +
                " 4 - Vous avez pas le droit d'utiliser un nom de joueur qui a déja était choisi !\n");


            ArrJR = JoueurRole();
            askRole();
            letsgo();

        }

    }

    
}
