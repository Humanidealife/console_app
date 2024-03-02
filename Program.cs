// See https://aka.ms/new-console-template for more information
// Notes du cours C# des 3 premiers chapitres"Les fondamentaux du C#"

using System;
using System.Collections.Generic;
using System.IO.Compression;
using System.Linq.Expressions;

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

       // Les délégues
            // Les délégues sont des types qui permettent de définir des méthodes qui peuvent être appelées par une autre méthode.
            // Les délégues sont utiles pour créer des événements et des méthodes anonymes.
            // Les délégues sont des types référence.
        delegate void MonDelegue(int nb7, int nb8);
        delegate int MonDelegueInt(int nb7, int nb8);
        static void Main(string[] args)
        {

            Console.Title = "Ma console en C#";
            // Console.BackgroundColor = ConsoleColor.DarkCyan;
            // Console.ForegroundColor = ConsoleColor.Yellow;
            // Console.WindowWidth = 100;
            // Console.WindowHeight = 30 ;

            Console.WriteLine("Voici, mon prmier programme en C#");



            MonDelegue Operation = Addition;
            Operation(10, 10);

            MonDelegueInt Op = Add;
            Op(14, 16);
            Console.WriteLine(Op(14, 16));

            //methode1 pour délégué
            void Addition(int nb7, int nb8)
            {
              Console.WriteLine(nb7 + nb8);
            }
            // methode2 pour délégué
            void Soustraction(int nb7, int nb8)
            {
              Console.WriteLine(nb7 - nb8);
            }

            int Add(int x, int y)
            {
              return (x + y);
            }

            int Sous(int x, int y)
            {
              return (x - y);
            }

            //Action délégué façon 1 avec une méthode void

            Action<string> affiche;
            affiche = print;

            affiche("salut");

            void print(string str6)
            {
              Console.WriteLine(str6);
            }

            //Action délégué façon 2 avce une expression lambda
            Action<string> affiche2 = str7 => Console.WriteLine(str7);

            affiche2("ToTo");

            //Action délégué façon 3 avec une méthode anonyme
            Action<string> affiche3 = delegate (string str8)
            {
              Console.WriteLine(str8);
            };
            affiche3("NiHao");
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
            for (int i0 =0; i0<=10; i0++)
            {
              Console.WriteLine("Valeur de i0 : " + i0);
            }

            int compteur;
            for(compteur=0; compteur<=10; compteur+=3)
            {
              Console.WriteLine("Valeur de compteur : " + compteur);
            }

            string[] tPrenoms = {"Luc", "Marc", "Jean-Jacques", "Pierre", "Pablo"};
            for( int i1 =0; i1 <tPrenoms.Length; i1++)
            {
              Console.WriteLine("Index : " + i1 + " Valeur : " + tPrenoms[i1]);
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

            // personnaliser la console


            // Console.CursorSize = 200;
            // Console.CursorVisible = true;
            // Console.BackgroundColor = ConsoleColor.Blue;
            // Console.ForegroundColor = ConsoleColor.DarkRed;

            //random
            Random rand = new Random();
            for (int i4=0; i4<1; i4++)
            {
              int nb6 = rand.Next(101);
              Console.WriteLine(nb6);
            }


            // Méthodes ou fonctions
            AffichageErrreur();

            void AffichageErrreur()
            {
              Console.ForegroundColor = ConsoleColor.Red;
              Console.WriteLine("********************");
              Console.ForegroundColor = ConsoleColor.Green;
              Console.WriteLine("Erreur de saisie");
              Console.ForegroundColor = ConsoleColor.Red;
              Console.WriteLine("********************");
              Console.ForegroundColor = ConsoleColor.White;
            }

            void Table2()
            {
              for (int i=0; i<10; i++)
              Console.WriteLine($"{i}*2={i*2}");
            }

            Table2();

            void ditBonjour(string prenomA="Paul", int nbFois=1)
            {
              for (int i=1; i<=nbFois; i++)
              {
                Console.WriteLine("Bonjour "+ prenomA);
              }

            }

            ditBonjour(prenomA: "Etienne", nbFois: 3);

            void Table(int x)
            {
              for (int i=0; i<=10; i++)
              {
                Console.WriteLine($"{i}*{x} = {i*x}");
              }
            }

            Table(5);
            Console.WriteLine("");
            Table(9);

            //fonctions
            int Somme(int nbB =1, int nbC=5)
            {
              int resultatBC = nbB + nbC;
              return resultatBC;
            }

            Console.WriteLine(Somme());

            void NiHao()
            {
              Console.WriteLine("你好");
              return;
              Console.WriteLine("Bonjour");
            }
            NiHao();

            string pgq10(int nombre5)
            {
              if (nombre5 >10)return "Plus grand que 10";
              if (nombre5<10)return "Plus petit que 10";
              return "Egal à 10";
            }

            Console.WriteLine(pgq10(13));

            // méthode Main

            // foreach(string a in args)
            // {
            //   Console.WriteLine(a);
            // }

            // surcharge de méthode
            Somme1(6, 8, 9);

            // Méthode générique

            int nbF = 5;
            string str2 = "Azerty";
            bool condition = true;

            Affiche(str2, "aaa");
            Affiche(nbF, "bbb");
            Affiche(condition, "ccc");

            void Affiche<T>(T element, string str)
            {
              Console.WriteLine($"Valeur:{element} {str}");
              Console.WriteLine($"Type:{element.GetType()}");
              Console.WriteLine();
            }

            // Type var implicite

            var i = 22;
            Console.WriteLine(i.GetType());

            // Mots-clés ref et out.
            // ref : permet de passer une variable par référence. Sinon d'habitutre on passe par valeur.
              // exemple passage par valeur
              string prenom6 = "Jean";
              MethodeParVal(prenom6);
              Console.WriteLine("MethodParVal : " + prenom6);

              void MethodeParVal(string str3)
              {
                str3 = "Bb";
              }
              // exmeple passage par référence
              string prenom7 = "Jean";
              MethodParRef(ref prenom7);
              Console.WriteLine("MethodParRef : " + prenom7);

              void MethodParRef(ref string str4)
              {
                str4 = "Bb";
              }

              // out : permet de retourner plusieurs valeurs à partir d'une méthode
              string prenom8 = "Jean"; /* ou string prenom8; */
              MethodeOut(out prenom8);
              Console.WriteLine("MethodeOut : " + prenom8);

              void MethodeOut(out string str5)
              {
                str5 = "Aa";
              }

              // Dates et heures
              DateTime maintenant = DateTime.Now;
              Console.WriteLine(maintenant.ToString("dd/MM/yyyy"));
              Console.WriteLine(maintenant.ToString("yyyy/MM/dd"));
              Console.WriteLine(maintenant.ToString("dddd dd MMMM yyyy"));
              Console.WriteLine(maintenant.ToString("H:mm:ss"));

              Console.WriteLine("jour est " + maintenant.Day);

              Console.WriteLine("heure est " + maintenant.Hour);

              TimeSpan heureDuJour = maintenant.TimeOfDay;
              Console.WriteLine("heure du jour est " + heureDuJour);

              TimeSpan interval = new TimeSpan(0, 10, 0);
              Console.WriteLine("Heure + 10 minutes : " + heureDuJour.Add(interval));
              Console.WriteLine("Heure - 10 minutes : " + heureDuJour.Subtract(interval));

              DateTime nouvelleDate = maintenant.AddDays(10);
              Console.WriteLine("Dans 10 jours : " + nouvelleDate);

              DateTime CeJour = DateTime.Today;
              Console.WriteLine("Ce jour : " + CeJour );
              Console.WriteLine("Hier nous étions le : " + CeJour.AddDays(-1));


              DateTime DateDeN = new DateTime(1998, 01, 28);
              TimeSpan Resultat = maintenant.Subtract(DateDeN);
              Console.WriteLine("Resultat : " + Resultat);

              DateTime d1 = new DateTime(2021,2,26);
              DateTime d2 = new DateTime(2021,12,28);
              Console.WriteLine(DateTime.Compare(d1, d2));
              int Compare = DateTime.Compare(d1, d2);
              if (Compare == -1) Console.WriteLine(d2 + " est plus récente que " + d1);
              if (Compare == 0) Console.WriteLine(d2 + " est égale à " + d1);
              if (Compare == 1) Console.WriteLine(d2 + " est plus ancienne que " + d1);

              DateTime an = new DateTime(1998, 12, 31);
              TimeSpan diffDate = maintenant -an;
              Console.WriteLine("j'ai " + diffDate.Days + " jours.");

              int min = diffDate.Days *24*60;
              Console.WriteLine("j'ai " + min + " minutes.");

              // Manipuler les chaînes de caractères
              string MaChaine = "Bonjour le langage C#.";
              // MaChaine = MaChaine.ToLower();
              // MaChaine = MaChaine.ToUpper();
              // simple lettre avec ''
              // MaChaine = MaChaine.Replace('C', 'F');
              // MaChaine = MaChaine.Replace("Bonjour", "Salut");
              // MaChaine = MaChaine.Remove(0, 4);
              // Substring avec deux paramètres, il prend la position de départ et le nombre de caractères à prendre
              //  SUbstring avec un seul paramètre, il prend la position de départ et prend tous les caractères jusqu'à la fin
              // MaChaine = MaChaine.Substring(0, 5);
              // if(MaChaine.Contains("C#"))
              // {
              //   Console.WriteLine("La chaîne contient C#");
              // }
              // else
              // {
              //   Console.WriteLine("La chaîne ne contient pas C#");
              // }
              // MaChaine = MaChaine.Trim();
              Console.WriteLine(MaChaine + "YYY");
              Console.WriteLine(MaChaine.LastIndexOf('l'));
              Console.WriteLine(MaChaine.Length);

              string PrenomC = "Jean, Luce, Marcel, Sophie";
              string [] tableauPrenomC = PrenomC.Split(",");
              foreach (string item in tableauPrenomC)
              {
                string prenomChacun = item.Trim();
                Console.WriteLine(prenomChacun);
              }

              string PrenomD = String.Join("@", tableauPrenomC);
              Console.WriteLine(PrenomD);

              //Array
              string[] tableau1 = {"Jean", "Luc", "Marcel", "Sophie", "Pierre", "Luc"};
              string[] tableau2 = new string[tableau1.Length];
              string[] tableau3 = new string[tableau1.Length];

              tableau2 = tableau1;
              foreach(string item in tableau2)
              {
                Console.WriteLine(item);
              }

              Array.Copy(tableau1, tableau3, tableau1.Length);

              Console.WriteLine("Index de Sophie : " + Array.IndexOf(tableau3, "Sophie"));
              Console.WriteLine("Index du dernier Lux : " + Array.LastIndexOf(tableau3, "Luc"));

              // Array.Reverse(tableau3);

              // Array.Resize(ref tableau3, 10);
              // tableau3[8] = "NouveauPrénom";

              Array.Sort(tableau3);
              // tableau3 = null;

              // Array.Clear(tableau3, 1, 2);

              foreach (string item1 in tableau3)
              {
                Console.WriteLine(item1);
              }



            Console.ReadKey();
        }
        static void Somme1(int nbD, int nbE)
        {
          Console.WriteLine(nbD + nbE);
        }

        static void Somme1(int nbD, int nbE, int nbF)
        {
          Console.WriteLine(nbD + nbE + nbF);
        }


    }
}
