using System;
using System.Net;
using System.Web;

namespace InteractiveCsharpApp // Note: actual namespace depends on the project name.
{
    class Program
    {
        static void Main(string[] args)
        {

            var client = new RestClient("https://v6.exchangerate-api.com/v6/e886397062b5c31bb26a553a/latest/EUR");
            client.Timeout = -1;
            var request = new RestRequest(Method.GET);
            request.AddHeader("x-api-key", " e886397062b5c31bb26a553a");
            IRestResponse response = client.Execute(request);
            Console.WriteLine(response.Content);
        }
        //     // Declaration des variables
        //     string? nom, prenom;
        //     int age;


        //     // Reculte des données
        //     try
        //     {
        //         Console.Write("veuillez renseigner votre age ? > ");
        //         age = int.Parse(Console.ReadLine());
        //         Console.Write("Votre nom respectif ? > ");
        //         nom = Console.ReadLine();

        //         Console.Write("Votre prénom respectif ? > ");
        //         prenom = Console.ReadLine();


        //     }
        //     catch (System.Exception)
        //     {

        //         throw;
        //     }




        //     // logout data to the console
        //     Console.WriteLine($"Bonjour, je m'appelle {nom} {prenom} et j'ai {age} ans, bientot vous aurez {age + 1} !  ");
        // }
    
}