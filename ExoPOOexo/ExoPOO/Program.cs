using ClassLibraryCompteBancaire;
using System.Numerics;

namespace ExoPOO
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //CompteBancaire compte1 = new CompteBancaire(25485245, "Bruno Le méchant", 1000.00m, -500);
            //CompteBancaire compte2 = new CompteBancaire(25485245, "Caroline", 600.00m, -1000);

                       
            //Console.WriteLine("\tEtat des comptes\n");
            //Console.WriteLine(compte2.ToString());
            //Console.WriteLine(compte1.ToString());

            //Console.WriteLine("\tEtat du compte après Créditage\n");
            //compte1.Crediter(100.00m);

            //Console.WriteLine(compte1.ToString());

            //Console.WriteLine("Etat du compte après Débitage\n");
            //compte1.Debiter(50.00m);
            //Console.WriteLine(compte1.ToString());

            //Console.WriteLine("\tEtat du compte après Transfère de Compte 1 vers Compte 2\n");
            //Console.WriteLine(compte1.Transferer(compte2, 1000.00m));
            //Console.WriteLine(compte1.ToString());
            //Console.WriteLine(compte2.ToString());


            //int c = compte1.CompareTo(compte2);



            //List<CompteBancaire> dreamTeam = new List<CompteBancaire>();
            //dreamTeam.Add(compte2);
            //dreamTeam.Add(compte1);
            //dreamTeam.Sort(new CompteBancaireComparaisonParId());


            Banque b1 = new Banque(new List<CompteBancaire>(), "Crédit Mutuel", "Mulhouse");

            b1.AjouteCompte(15515, "Alice", 8550m, -500);
            b1.AjouteCompte(25185, "Bob", 200m, -1000);
            b1.AjouteCompte(26854, "Bruno Méchant", 8550m, -500);
            b1.AjouteCompte(17895, "Caroline", 400m, -1000);


            CompteBancaire compteSup = b1.CompteSup();
            Console.WriteLine($"\n\tLe Compte avec le solde le plus élever:");
            Console.WriteLine(compteSup == null ? "Aucun compte trouvé." : compteSup);


            Console.WriteLine("\n\tTrouvez le compte");
            CompteBancaire compteTrouve = b1.RendCompte(085);
            Console.WriteLine(compteTrouve == null ? "Aucun compte trouvé." : compteTrouve);










            //Console.WriteLine("\n\tTransfère Argent");
            //if(b1.Transferer(15515, 17895, 100m))
            //{
            //    Console.WriteLine("Transfere réussi");

            //}
            //else
            //{
            //    Console.WriteLine("Transfere impossible");
            //}


            


            Console.ReadLine();

        }
    }
}
