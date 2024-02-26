// See https://aka.ms/new-console-template for more information
using System;
using System.Collections.Generic;
using System.IO.Compression;

namespace console_app // Remplacez MonNamespace par le nom de votre namespace
{
    class Program
    {
      enum mois
      {
        Janvier = 1,
        Février = 2,
        Mars = 3,
        Avril = 4,
        Mai = 5,
        Juin = 6,
        Juillet = 7,
        Août = 8,
        Septembre = 9,
        Octobre = 10,
        Novembre = 11,
        Décembre = 12
      }
        static void Main(string[] args)
        {
            Console.WriteLine("Voici, mon prmier programme en C#");
            // Boolean
            bool homme = true;
            Console.WriteLine(homme);
            // Integer
            int age = 29;
            Console.WriteLine(age);
            //Float
            float taille = 1.80f;
            Console.WriteLine(taille);
            //String
            string prenom = "Qian";
            Console.WriteLine(prenom);
            prenom = "Etienne";
            Console.WriteLine(prenom);

            string p = "Jim";
            int a = 28;
            string presentation = "Il s'appelle " + p + " et il a " + a + " ans.";
            Console.WriteLine(presentation);
            Console.WriteLine("Il s'appelle {0} et il a {1} ans.", p, a);
            Console.WriteLine($"Il s'appelle {p} et il a {a} ans.");
            // Console.WriteLine(5 + 2);
            int nombre = 22;
            // int resultat;

            // resultat = nombre / 5;

            // nombre = nombre + 10;

            // nombre  += 10;

            ++nombre;
            Console.WriteLine(nombre);
            int nombre2 = 10;
            nombre2++;
            Console.WriteLine(nombre2);

            int nombre3 = 10;
            Console.WriteLine(nombre3++);
            Console.WriteLine(++nombre3);

            int nombre4 = 10;
            nombre4 = nombre4 % 4;
            Console.WriteLine(nombre4);

            // conditionnel if
            int vitesse = 90;
            if (vitesse > 90)
            {
                Console.WriteLine("Vous avez une amende");
            }
            else if (vitesse == 90)
            {
                Console.WriteLine("Vous êtes à la limite");
            }
            else
            {
                Console.WriteLine("Vous êtes dans les normes");
            }

            string username = "admin";
            string password = "123456";
            if (username == "admin" && password == "123456")
            {
                Console.WriteLine("Vous êtes connecté");
            }
            else
            {
                Console.WriteLine("Erreur de connexion");
            }
            bool chat = true;
            if (chat)
            {
                Console.WriteLine("Vous avez un chat");
            }
            else
            {
                Console.WriteLine("Vous n'avez pas de chat");
            }

            bool chien = true;
            if (!chien)
            {
                Console.WriteLine("Vous n'avez pas de chien");
            }
            else
            {
                Console.WriteLine("Vous avez un chien");
            }

            // Switch
            string couleur = "violet";
            switch (couleur)
            {
              case "rouge":
                Console.WriteLine("La couleur " + couleur + " est ma préférée");
                break;
              case "bleu":
                Console.WriteLine("La couleur " + couleur + " est une super couleur");
                break;

                default:
                Console.WriteLine("Je ne connais pas cette couleur");
                break;
            }

            int note = 13;
            switch (note)
            {
              case 20:
              case 19:
              case 18:
                Console.WriteLine("Excellent");
                break;
              case 17:
              case 16:
                Console.WriteLine("Très bien");
                break;
              case 15:
              case 14:
                Console.WriteLine("Bien");
                break;
              case 13:
              case 12:
                Console.WriteLine("Assez bien");
                break;
              case 11:
              case 10:
                Console.WriteLine("Passable");
                break;
              default:
                Console.WriteLine("Insuffisant");
                break;
            }

            // ReadLine
            Console.WriteLine("Entrez votre prénom ?");
            string prenom2;
            prenom2 = Console.ReadLine();
            Console.WriteLine("Bonjour, " + prenom2);
            Console.WriteLine(prenom2.GetType());
            // ou
            Console.WriteLine("Entrez votre prénom ?");
            string prenom3 = Console.ReadLine();
            Console.WriteLine("Bonjour, " + prenom3);

            // tableau
            string[] tabMois =
            {
              "Janvier",
              "Février",
              "Mars",
              "Avril",
              "Mai",
              "Juin",
              "Juillet",
              "Août",
              "Septembre",
              "Octobre",
              "Novembre",
              "Décembre"
            };
            Console.WriteLine(tabMois[10]);
            Console.WriteLine("Longueur du tableau " + tabMois.Length);
            Console.WriteLine(tabMois[3]);
            tabMois[3] = "Nouveau mois";
            Console.WriteLine(tabMois[3]);

            string[] tabMois2 = new string[2];
            tabMois2[0] = "Janvier";
            Console.WriteLine("Tu dois entrer quelque chose ici");
            string str = Console.ReadLine();
            tabMois2[1] = str;
            Console.WriteLine("Voici ce que tu as écrit : ");
            Console.WriteLine(tabMois2[1]);

            // Structure conditionnelle
            for (int i =0; i<=10; i++)
            {
              Console.WriteLine("Valeur de i : " + i);
            }

            int compteur;
            for(compteur=0; compteur<=10; compteur+=3)
            {
              Console.WriteLine("Valeur de compteur : " + compteur);
            }

            string[] tPrenoms = {"Luc", "Marc", "Jean-Jacques", "Pierre", "Pablo"};
            for( int i =0; i <tPrenoms.Length; i++)
            {
              Console.WriteLine("Index : " + i + " Valeur : " + tPrenoms[i]);
            }

            string[] tVilles ={"Paris", "Rennes", "Le Mans", "Coppenhague", "Londres"};
            foreach (string ville in tVilles)
            {
              Console.WriteLine(ville);
            }

            int i2 = 10;
            while (i2<100)
            {
              Console.WriteLine("valeur de i2 : " + i2);
              i2 += 10;
            }

            int i3 =10;
            do
            {
              Console.WriteLine("Valuer de i3 :" + i3);
              i3 += 10;
            } while (i3 <1);

            // Conversion de types
            int nb = 14;
            float nb1 = nb;

            float nb2 = 16.78f;
            int nb3 = (int)nb2;
            Console.WriteLine(nb3);

            Console.WriteLine("Entrez un nombre");
            string nb4 = Console.ReadLine();
            int resultat;

            if (Int32.TryParse(nb4, out resultat))
            {
              resultat = Int32.Parse(nb4) * 2;
              Console.WriteLine(nb4 + " multiplié par 2 est égal à " + resultat);
            }
            else
            {
              Console.WriteLine("Erreur de conversion");
            }

            int nb5 = 10;
            string str1 = nb5.ToString();
            Console.WriteLine(str1);

            // Les listes
            List<string> listPrenoms = new List<string>();
            listPrenoms.Add("Jean-Marc");
            listPrenoms.Add("Jean-Luc");
            listPrenoms.Add("Pierre");
            listPrenoms.Add("Paul");

            // listPrenoms.Remove("Pierre");
            // listPrenoms.RemoveAt(0);
            listPrenoms.RemoveRange(0,3);
            listPrenoms.Clear();
            foreach (string prenom4 in listPrenoms)
            {
              Console.WriteLine(prenom4);
            }
            // listPrenoms[0] = "Jean-Michel";

            // Console.WriteLine(listPrenoms[0]);

            Console.WriteLine(listPrenoms.Count);

            List<string> listPrenoms2 = new List<string>
            {
              "Zoe",
              "Lucie",
              "Marie"
            };
            foreach (string prenom5 in listPrenoms2)
            {
              Console.WriteLine(prenom5);
            }

            // Les dictionnaires
            Dictionary<string, string> dicoExt = new Dictionary<string, string>();
            dicoExt.Add("bmp", "paint.exe");
            dicoExt.Add("txt", "notepad.exe");
            dicoExt.Add("docx", "winword.exe");
            dicoExt.Add("xlsx", "excel.exe");

            dicoExt.Remove("txt");
            // if (dicoExt.ContainsKey("docx"))
            // {
            //   Console.WriteLine(dicoExt["xlsx"]);
            // }
            // else
            // {
            //   Console.WriteLine("La clé n'existe pas");
            // }


            // string resultat2;
            // if (dicoExt.TryGetValue("bmp", out resultat2))
            // {
            //   Console.WriteLine(dicoExt["bmp"]);
            // }
            // else
            // {
            //   Console.WriteLine("La clé n'exste pas");
            // }


            foreach (KeyValuePair<string, string> kvp in dicoExt)
            {
              Console.WriteLine("Clé : " +kvp.Key + " Valeur : " + kvp.Value);
              Console.WriteLine(kvp);
            }

            Console.WriteLine(dicoExt["bmp"]);


            Console.WriteLine(dicoExt.Count);

            Dictionary<string, string> dicoExt2 = new Dictionary<string, string>
            {
              {"jpg", "paint.exe"},
              {"png", "paint.exe"},
              {"gif", "photo.exe"}
            };

            // Constantes et énumérations
            const float pi = 3.14f;

            mois m = mois.Octobre;
            Console.WriteLine((int)mois.Février);
            Console.WriteLine(m);

            // gestion des exceptions
            Console.WriteLine("Entrez un nombre :");

            try
            {
              int nba = int.Parse(Console.ReadLine());
              Console.WriteLine($"1024/{nba}={1024/nba}");
            }
            catch (Exception ex)
            {
              Console.WriteLine(ex.Message);
            }
            finally
            {
              Console.WriteLine("Fin du programme.");
            }

            // Opéraeur ternaire

            bool humain = true;
            // string message;
            // if (humain)
            // {
            //   message = "Bonjour humain";
            // }
            // else
            // {
            //   message = "Bonjour mais qui es-tu ?";
            // }

            // Console.WriteLine(message);

            string message = humain ? "Bonjour humain" : "Bonjour mais qui es-tu ?";

            int moyenneAge = 20;
            string messageAge = moyenneAge >18 ? "Majeur" : "Mineur";

            Console.ReadKey();
        }
    }
}
