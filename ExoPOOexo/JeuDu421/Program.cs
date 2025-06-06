using ClassLibraryManche;
using ClassLibraryDe;

namespace JeuDu421
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Manche manche = new Manche();
            bool continuer = true;

            Console.WriteLine("Premier lancer des trois dés :");
            manche.Lancer();
            Console.WriteLine($"Résultats : {manche.mes3des[0].NumeroFace}, {manche.mes3des[1].NumeroFace}, {manche.mes3des[2].NumeroFace}");
            Console.WriteLine($"Est-ce que le joueur a gagné ? {manche.EstGagne()}");

            do
            {
                Console.WriteLine("\nChoisissez une option:");
                Console.WriteLine("1. Lancer deux dés spécifiques");
                Console.WriteLine("2. Lancer un dé spécifique");
                Console.Write("Votre choix: ");

                string choix = Console.ReadLine();

                if (choix == "1")
                {
                    Console.Write("Entrez le numéro du premier dé (1-3): ");
                    int numDeUn = int.Parse(Console.ReadLine());
                    Console.Write("Entrez le numéro du deuxième dé (1-3): ");
                    int numDeDeux = int.Parse(Console.ReadLine());
                    manche.Lance(numDeUn, numDeDeux);
                }
                else if (choix == "2")
                {
                    Console.Write("Entrez le numéro du dé (1-3): ");
                    int numDe = int.Parse(Console.ReadLine()) - 1;
                    manche.Lance(numDe);
                }
                else
                {
                    Console.WriteLine("Option non valide.");
                }

                Console.WriteLine($"Résultats : {manche.mes3des[0].NumeroFace}, {manche.mes3des[1].NumeroFace}, {manche.mes3des[2].NumeroFace}");
                Console.WriteLine($"Est-ce que le joueur a gagné ? {manche.EstGagne()}");

                if (!manche.AEncoreUnLancer())
                {
                    continuer = false;
                    Console.WriteLine("Plus de lancers disponibles.");
                }

            } while (continuer);
        }
    }
}