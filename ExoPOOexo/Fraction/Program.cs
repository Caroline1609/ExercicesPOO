using ClassLibraryFraction;

namespace Fraction
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Fraction f1 = new Fraction(1, 2);
            Fraction f2 = new Fraction(3, 4);


            Fraction f1 = f1.Plus(f2);
            Console.WriteLine($"Addition: {f1.ToDisplay()} + {f2.ToDisplay()} = {f1.ToDisplay()}");
        }

    }
}
