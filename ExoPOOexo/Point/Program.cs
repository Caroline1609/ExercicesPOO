using ClassLibraryPoint;
using System;
using System.Drawing;

namespace Point
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PointYX p1 = new PointYX(8, 25);

            Console.WriteLine("Coordonnées initiales :");
            Console.WriteLine(p1.ToString());

            p1.Permuter();
            Console.WriteLine("Après permutation :");
            Console.WriteLine(p1.ToString());



            p1.SymetrieAxeAbscisse();
            Console.WriteLine("Symetrie Axe Abscisse :");
            Console.WriteLine(p1.ToString());







            Console.ReadLine();
            
        }
    }
}
