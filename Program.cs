// See https://aka.ms/new-console-template for more information
using System;
using System.IO.Compression;

namespace console_app // Remplacez MonNamespace par le nom de votre namespace
{
    class Program
    {
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

            Console.WriteLine("Entrez votre prénom ?");
            string prenom2;
            prenom2 = Console.ReadLine();
            Console.WriteLine("Bonjour, " + prenom2);
            Console.WriteLine(prenom2.GetType());
            // ou
            Console.WriteLine("Entrez votre prénom ?");
            string prenom3 = Console.ReadLine();
            Console.WriteLine("Bonjour, " + prenom3);

            Console.ReadKey();
        }
    }
}
