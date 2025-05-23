using ClassLibraryFraction;

namespace Fraction
{
    internal class Program
    {
        static void Main(string[] args)
        {

            ClassLibraryFraction.Fraction f1 = new ClassLibraryFraction.Fraction(11,7);
            ClassLibraryFraction.Fraction f2 = new ClassLibraryFraction.Fraction(22, 14);


            Console.WriteLine($"Fraction 1 : {f1.ToString()}");
            Console.WriteLine($"Fraction 2 : {f2.ToString()}");
            //Fractions quotient = f1.Divise(f2);


            //f1.Oppose();
            //Console.WriteLine(f1.ToString());

            //f1.Inverse();
            //Console.WriteLine(f1.ToString());

            bool estSuperieur = f1.SuperieurA(f2);
            Console.WriteLine($"Supérieure: {estSuperieur}");

            bool estEgal = f1.EgalA(f2);
            Console.WriteLine($"Supérieure: {estEgal}");













            Console.ReadLine();

        }
    }
}
