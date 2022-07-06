using System;
using System.Collections.Generic;

namespace ExosParein
{
    internal class Program
    {

        delegate void MyDelegate(int a, int b);
        static void Main(string[] args)
        {
            // ***************Lire à la console ***************************************

            /*Console.Write("Entrez votre prenom : ");
            var prenom = Console.ReadLine();

            Console.Write("Quel est votre âge ? : ");
            var age = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"Vous vous appeller {prenom} est vous avez {age} ans.");

            // **************** LES TABLEAUX *******************************************

            string[] tabMois = {"Janvier" , "Février" , "Mars" , "Avril" , "Mai"};
            Console.Write("Le tableau des mois : [ ");

            int i = 1;
            foreach (var item in tabMois)
            {
                if (i <= tabMois.Length - 1)

                {
                    i++;
                    Console.Write(item + " , ");
                }
                else
                {
                    Console.WriteLine(item + " ]");
                }
               
            }

            // Trier tabMois par ordre croissant

            Array.Sort(tabMois);
            Console.Write("tabmois trié : [ ");
            foreach (var item in tabMois)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine("]"); */

            //************* Le TRANSTYPAGE *********************************************

            // Implicite :
            /*int nb = 275;
            float nb1 = nb;

            Console.WriteLine($"nb est casté par la machine (Cast implicite) est devient : {nb1}");

            //Exlicite
            float nb2 = 15.0f;
            int nb3 = Convert.ToInt32(nb2);

            Console.WriteLine($"après convertion explicite : {nb3}");

            Console.Write("Entrer le nombre à mettre  en carré : ");
            var reponse = Console.ReadLine();


            if (Int32.TryParse(reponse, out int number))  // tenter de Caster : ==> si on tape des lettres au lieu des chiffres ==>  exception levée
                                                         // Mais le programme ne plante pas
            {
                var carreNumber = Math.Pow(number, 2);
                Console.WriteLine($"Le carré de {number} est de : {carreNumber}");
            }

            // Convertion d'un entier en string

            int chiffre = 129;
            var chiffreString = chiffre.ToString();

            Console.WriteLine($"Le chiffre {chiffre} devient en string : {chiffreString}");
*/
            // ****************** LES LISTES ****************************************************************

            /*List<string> prenomsList = new List<string>();
            prenomsList.Add("Michel");
            prenomsList.Add("Ammar");
            prenomsList.Add("Kadour");
            prenomsList.Add("Eric");
            prenomsList.Add("Samantha");

            // On peu créer une liste autrement:
            List<string> prenomsList2 = new List<string>
            {
                "Zoé",
                "Mathilde",
                "Kamel",
                "Salah"
            }; 

            Console.Write("Notre liste prenomsList contient : [ ");
            foreach (var item in prenomsList)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine("]");

            // On cherche la position de "Eric" dans la liste avec IndexOf(liste , "prenom")
            Console.WriteLine($"Eric se trouve à l'index : {prenomsList.IndexOf("Eric")}");

            // On retourne la longueur de la liste prenomList avec "Count"
            Console.WriteLine($"La liste prenomList contient : {prenomsList.Count} élements.");*/

            // *************************** EXERCICE ********************************************

            // Trouvez un nombre entre 1 et 100 en utilisant des nombres aléatoires

            /*Random rand = new Random();
            int nbCoups = 0;
            int chiffre = 0;
           
            int nb = rand.Next(1, 101);


            while (chiffre != nb)

            {
                
                Console.Write("Entrez votre nombre entre 1 et 100 : ");

                try
                {
                    chiffre = int.Parse(Console.ReadLine());

                    if (chiffre >= 1 && chiffre <= 100)
                    {
                        nbCoups++;
                        if (chiffre > nb)
                        {
                            Console.WriteLine("Entrez un chiffre plus petit");
                        }
                        else if (chiffre < nb)
                        {
                            Console.WriteLine("Entrez un chiffre plus grand");
                        }
                        else
                        {
                            Console.WriteLine($"Bravo vous avez réussi après {nbCoups} Coups, le nombre magique est : {nb}");
                        }
                    }
                }
                catch
                {
                    Console.WriteLine("Entrer un format valide ...");
                }

            }*/

            // *************************** LES METHODES ***********************************************************************



            // flasher le message à l'ecran :
            /* static void flasherText(string text , int delay)
             {

                     Console.Write(text);
                     Thread.Sleep(650);

                     for (int i = 1; i <= text.Length + 2; i++)
                     {
                         Console.Write("\b" + (char)32 + "\b");
                         if (i == text.Length + 2) Thread.Sleep(delay);
                     }

             }

             Console.ForegroundColor = ConsoleColor.Red;
             Console.WriteLine("************************");
             Console.ForegroundColor = ConsoleColor.Green;
             // appel a la metthode pour  flasher
             flasherText("Ceci est une alerte!!!!" , 7000);

             Console.ForegroundColor = ConsoleColor.White;*/

            // Aficher la table de multipliaction de 2 ************************************************************************

            static void tableMultDe2()
            {
                for (int i = 0; i <= 10; i++)
                {
                    Console.WriteLine($"{i} * 2 = {i * 2}");
                }
                Console.WriteLine("\nFin de la table de multiplication");
            }

            // *******************APPEL DE LA TABLE DE MULTIPICATION ***********************************************************

            tableMultDe2();

            // **************** LES METHODES AVEC ARGUMENTS ********************************************************************

            void disBonjour(string texte, string prenom)
            {
                Console.WriteLine($"\n{prenom} dit {texte}");
            }

            // **********Appel à disBonjour() **********************************************************************************

            disBonjour("salut tous le Monde", "Benoit");

            // *****************LE DICTIONNAIRE *************************************************

            Dictionary<string, string> prenomsDictionary = new Dictionary<string, string>();
            prenomsDictionary.Add("Kadour", "Mercedes");
            prenomsDictionary.Add("Eric", "Honda");
            prenomsDictionary.Add("Jean", "Dacia");
            prenomsDictionary.Add("Samatha", "Peugeot");

            foreach (KeyValuePair<string, string> kv in prenomsDictionary)
            {
                Console.WriteLine($"{kv.Key} possède une ==> {kv.Value}");
            }

            if (prenomsDictionary.TryGetValue("Jean", out _))
            {

                Console.WriteLine($"Jean possède une : {prenomsDictionary["Jean"]}");

            }
            else
            {
                Console.WriteLine($"Cette personne n'existe pas dans le Dico !!!");
            };

            // ******* Autre forme de création de Dictionnary ***********************************

            Dictionary<string, string> dictionaitAngFrench = new Dictionary<string, string>()
            {
                {"Room" , "Chambre"},
                {"Dog" , "Chien" },
                {"Car" , "Voiture" },
                {"Computer" , "Ordinateur"}
            };

            foreach (KeyValuePair<string, string> kvp in dictionaitAngFrench)
            {
                Console.WriteLine($"{kvp.Key} en français ==> {kvp.Value}");
            }

            static double division(int a, int b)
            {
                var resultat = (double)(a / b);
                return resultat;
            }

            var devis = division(20, 15);
            Console.WriteLine((double)devis);

            Console.WriteLine(13 / 5.0);       // output: 2.6

            int a = 13;
            int b = 5;
            Console.WriteLine((double)a / b);  // output: 2.6

            //****************** LES ARGUMENTS DU MAIN **************************************

            foreach (string arg in args)
            {

                Console.WriteLine(arg);
            }

            // ******************** LES METHODES GENERIQUES **********************************

            void afficheType<T>(T nb)
            {
                Console.WriteLine($"{nb} est de type {nb.GetType()}");
            }

            afficheType(10.9);
            afficheType("10.9");
            afficheType('s');
            afficheType(10);
            afficheType(true);

            // ************* LES TYPES VAR ****************************************************

            var nombre = 22.67; // nombre est de type int reconnu par C#
            var chaine = "Sophie";
            Console.WriteLine($"{nombre} est de type {nombre.GetType()}");
            Console.WriteLine($"{chaine} est de type {chaine.GetType()}");

            // ************** REF ET OUT ******************************************************

            string str = "Salih";

            methodeParValeur(str);

            methodeParReference(ref str);

            void methodeParValeur(string str)
            {
                str = "toto";
                Console.WriteLine(str); // affiche "toto" mais pas "Salih" ==> passage par valeur

            }

            void methodeParReference(ref string str)
            {
                str = "toto";
                Console.WriteLine(str);
            }

            // *********************** LES DELEGUES *********************************************

            void addition(int nb1, int nb2)
            {
                Console.WriteLine("addition : " + (nb1 + nb2));
            }

            void soustraction(int nb1, int nb2)
            {
                Console.WriteLine("soustraction : " + (nb1 - nb2));
            }

            MyDelegate operation = addition;
            operation(20, 25);

            operation = soustraction;
            operation(20, 25);

            // *********************** LES DATES ************************************************

            DateTime maintenant = DateTime.Now;


            Console.Read();

        }
    }
}































