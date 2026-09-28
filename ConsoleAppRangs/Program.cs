using System.ComponentModel.Design;

namespace ConsoleAppRangs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int novice, adepte, veteran, maitre;
            string gerrier, mage, rogue;

            Console.WriteLine("Entrez le niveau de votre personnage :");
            int niveau = int.Parse(Console.ReadLine());

            Console.WriteLine("entrez la classe principale (Guerrier, Mage, Rogue) :");
            string classe = Console.ReadLine();

            Console.WriteLine("entrez votre nombre de Quêtes accomplies :");
            int quetes = int.Parse(Console.ReadLine());

            if (niveau < 10)
            {
                Console.WriteLine("Vous êtes un Novice.");
            }
            else if (niveau >= 10 && niveau < 20 && quetes >= 5)
            {
                Console.WriteLine("Vous êtes un Adepte.");
            }
            else if (niveau >= 10 && niveau < 20 && quetes < 5)
            {
                Console.WriteLine("Vous êtes un Apprenti assermenté.");
            }
            else if (niveau >= 20 && niveau < 30 || classe == "Mage" && niveau >= 25)
            {dv
                Console.WriteLine("Vous êtes un Vétéran.");
            }
            else if (quetes > 20 && classe == "Guerrier" || classe == "Rogue") ;
            {
                Console.WriteLine("Vous êtes un Maître.");
            }
            
        }
    }
}
