using ClassLibraryFraction;
using System.Numerics;

namespace Fraction1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Fraction f1 = new Fraction(11, 7);
            Fraction f2 = new Fraction(5, 4);

            Console.WriteLine("Affichage des fractions");
            Console.WriteLine($"Fraction 1: {f1.ToString()}");
            Console.WriteLine($"Fraction 2: {f2.ToString()}");



            //Console.WriteLine("\nAffichage des Operations");

            //Console.WriteLine($"Fraction 1: {f1.ToDisplay()}");
            //Console.WriteLine($"Fraction 2: {f2.ToDisplay()}");

            //Fraction Addition = f1.Plus(f2);
            //Console.WriteLine($"\nAddition: {Addition.ToDisplay()}");

            //Addition.Reduire();
            //Console.WriteLine($"\nAddition réduite: {Addition.ToDisplay()}");

            //Fraction soustraction = f1.Moins(f2);
            //Console.WriteLine($"\nSoustraction: {soustraction.ToDisplay()}");

            //Fraction multi = f1.Multiplie(f2);
            //Console.WriteLine($"\nMultiplication: {multi.ToDisplay()}");

            //Fraction fractions = f1.Diviser(f2);
            //Console.WriteLine($"\nFractions : {fractions.ToDisplay()}");

            //f1.Oppose();
            //Console.WriteLine($"\nOpposé de Fraction 1: {f1.ToDisplay()}");

            //f2.Inverse();
            //Console.WriteLine($"\nInverse de Fraction 2: {f2.ToDisplay()}");


            //Console.WriteLine($"\nFraction 1 est Supérieur a la Fraction 2 ? {f1.SuperieurA(f2)}");



            //Console.WriteLine($"F1: {f1.ToDisplay()},  F2: {f2.ToDisplay()}");
            //Console.WriteLine($"\nf1 == f2 ? {f1.EgaleA(f2)}");



            Console.WriteLine($"\ntest Surchage");

            Fraction addi = f1 + f2;
            Console.WriteLine($"Addition : {addi.ToDisplay()}");

            Fraction moins = f1 - f2;
            Console.WriteLine($"Soustraction : {moins.ToDisplay()}");

            Fraction multiple = f1 * f2;
            Console.WriteLine($"Multiplier :  {multiple.ToDisplay()}");

            Fraction divise = f1 - f2;
            Console.WriteLine($"Division : {divise.ToDisplay()}");



        }
    }

}
