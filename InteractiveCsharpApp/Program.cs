using System;

namespace InteractiveCsharpApp // Note: actual namespace depends on the project name.
{
    class Program
    {
        static void Main(string[] args)
        {   

            // Declaration des variables
            string? age,nom,prenom;

            // Reculte des données
            Console.Write("veuillez renseigner votre age ? > ");
            age = Console.ReadLine();
            Console.Write("Votre nom respectif ? > ");
            nom = Console.ReadLine();
            Console.Write("Votre prénom respectif ? > ");
            prenom = Console.ReadLine();

            // logout data to the console
            Console.WriteLine($"Bonjour, je m'appelle {nom} {prenom} et j'ai {age} ans !  ");
        } 
    }
}