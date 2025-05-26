using ClassLibraryFraction;
using System.Numerics;

namespace Fraction1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Fraction f1 = new Fraction(1, 9);
            Fraction f2 = new Fraction(0, 2);

            Console.WriteLine($"\nFraction 1: {f1.ToDisplay()}");
            Console.WriteLine($"\nFraction 2: {f2.ToDisplay()}");

            Fraction Addition = f1.Plus(f2);
            Console.WriteLine($"\nAddition: {Addition.ToDisplay()}");

            Addition.Reduire();
            Console.WriteLine($"\nAddition réduite: {Addition.ToDisplay()}");

            Fraction soustraction = f1.Moins(f2);
            Console.WriteLine($"\nSoustraction: {soustraction.ToDisplay()}");

            Fraction multi = f1.Multiplie(f2);
            Console.WriteLine($"\nSoustraction: {multi.ToDisplay()}");

            Fraction fractions = f1.Diviser(f2);
            Console.WriteLine($"\nFractions : {fractions.ToDisplay()}");

            f1.Oppose();
            Console.WriteLine($"\nOpposé de Fraction 1: {f1.ToDisplay()}");

            f2.Inverse();
            Console.WriteLine($"\nInverse de Fraction 2: {f2.ToDisplay()}");
        }
    }

}
