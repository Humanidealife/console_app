﻿// See https://aka.ms/new-console-template for more information
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
            Console.ReadKey();
        }
    }
}
