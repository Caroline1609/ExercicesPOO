using ClassLibraryCompteBancaire;

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


            //string mot1 = "tutu";
            //string mot2 = "rududu";
            //int r =mot1.CompareTo(mot2);


            int c = compte1.CompareTo(compte2);

            List<CompteBancaire> dreamTeam = new List<CompteBancaire>();
            dreamTeam.Add(compte2);
            dreamTeam.Add(compte1);
            dreamTeam.Sort(new CompteBancaireComparaisonParId());

            ;

            Console.ReadLine();

        }
    }
}
