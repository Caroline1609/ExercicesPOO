using ClassLibraryCompteBancaire;
using System;
using static ClassLibraryCompteBancaire.CompteBancaire;

namespace ExoPOO
{
    internal class Program
    {
        static void Main(string[] args)
        {

            CompteBancaire compte1 = new CompteBancaire(25485245, "Bruno Le méchant", 1000.00m, -500);
            CompteBancaire compte2 = new CompteBancaire(25485245, "Caroline", 600.00m, -1000);


            Console.WriteLine("\tEtat des comptes\n");
            Console.WriteLine(compte2.ToString());
            Console.WriteLine(compte1.ToString());

            Console.WriteLine("\tEtat du compte après Créditage\n");
            compte1.Crediter(100.00m);

            Console.WriteLine(compte1.ToString());

            Console.WriteLine("Etat du compte après Débitage\n");
            compte1.Debiter(50.00m);
            Console.WriteLine(compte1.ToString());

            Console.WriteLine("\tEtat du compte après Transfère de Compte 1 vers Compte 2\n");
            Console.WriteLine(compte1.Transferer(compte2, 1000.00m));
            Console.WriteLine(compte1.ToString());
            Console.WriteLine(compte2.ToString());


            Console.WriteLine("\tComparer Compte 1 et Compte 2\n");

            ParSolde comparer = new ParSolde();
            decimal result = comparer.Compare(compte1, compte2);

            Console.WriteLine("\nRésultat de la comparaison :");
            if (result > 0)
            {
                Console.WriteLine("Compte 1 a un solde plus élevé que Compte 2.");
            }
            else if (result < 0)
            {
                Console.WriteLine("Compte 1 a un solde plus bas que Compte 2.");
            }
            else
            {
                Console.WriteLine("Compte 1 et Compte 2 ont le même solde.");
            }


            Console.ReadLine();

        }
    }
}
