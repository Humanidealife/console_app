// See https://aka.ms/new-console-template for more information
using System;

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
            Console.ReadKey();
        }
    }
}
