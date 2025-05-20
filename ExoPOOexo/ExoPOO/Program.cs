using ClassLibraryCompteBancaire;

namespace ExoPOO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CompteBancaire Compte1 = new CompteBancaire(25485245, "Bruno Le méchant", 521.25m, 500);

            Console.WriteLine(Compte1.ToString());
        }
    }
}
