using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice_1
{
    class Program
    {
        static void Main(string[] args)
        {
            string prenom, nom;
            int age;

            // Saisie des trois infos
            Console.Write("Entrez votre prénoms : ");
            prenom = Console.ReadLine();
            Console.Write("Entrez votre nom : ");
            nom = Console.ReadLine();
            Console.Write("Quel est votre âge ? ");
            age = int.Parse(Console.ReadLine());

            // Affichage
            Console.WriteLine("Bonjour " + prenom + " " + nom + ", vous avez " + age + " ans.");
            Console.ReadLine();
        
        }
    }
}
