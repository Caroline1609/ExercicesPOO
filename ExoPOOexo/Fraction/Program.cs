using ClassLibraryFraction;

namespace Fraction
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Fraction f1 = new ClassLibraryFraction.Fraction(25,7);
            Fraction f2 = new ClassLibraryFraction.Fraction(22, 4);


            Console.WriteLine($"Fraction 1 : {f1.ToDisplay()}");
            Console.WriteLine($"Fraction 2 : {f2.ToDisplay()}");
            //Fractions quotient = f1.Divise(f2);


            //f1.Oppose();
            //Console.WriteLine($"Fraction 1 : {f1.ToDisplay()}");

            //f1.Inverse();
            //Console.WriteLine($"Fraction 1 : {f1.ToDisplay()}");

            //bool estSuperieur = f1.SuperieurA(f2);
            //Console.WriteLine($"Supérieure: {estSuperieur}");

            //bool estEgal = f1.EgalA(f2);
            //Console.WriteLine($"Supérieure: {estEgal}");

            //f1.Diviser(f2);
            Console.WriteLine(f1.Diviser(f2).ToDisplay());






        //https://www.kartable.fr/ressources/mathematiques/cours/les-fractions-8/60023








            Console.ReadLine();

        }
    }
}
