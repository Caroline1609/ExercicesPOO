using ClassLibraryFraction;

namespace Fraction
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Fractions f1 = new Fractions(2, 5);
            Fractions f2 = new Fractions(3, 5);


            Console.WriteLine(f1.ToString());
            Fractions quotient = f1.Divise(f2);
            Console.WriteLine(f1.EgalA(f2));















            Console.ReadLine();

        }
    }
}
