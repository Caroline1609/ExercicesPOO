using ClassLibraryPoint;
using System;
using System.Drawing;

namespace Point
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PointYX p1 = new PointYX(21, 35);

            Console.WriteLine("Coordonnées initiales :");
            Console.WriteLine(p1.ToString());

            p1.Permuter();
            Console.WriteLine("Après permutation :");
            Console.WriteLine(p1.ToString());


            PointYX symetrieAbscisse = p1.SymetrieAxeAbscisse();
            Console.WriteLine("Symétrie par rapport à l'axe des abscisses :");
            Console.WriteLine(symetrieAbscisse.ToString());

            // Appliquer la symétrie par rapport à l'axe des ordonnées
            PointYX symetrieOrdonnee = symetrieAbscisse.SymetrieAxeOrdonnee();
            Console.WriteLine("Symétrie par rapport à l'axe des ordonnées :");
            Console.WriteLine(symetrieOrdonnee.ToString());

            // Appliquer la symétrie par rapport à l'origine
            PointYX symetrieOrigine = symetrieOrdonnee.SymetrieOrigine();
            Console.WriteLine("Symétrie par rapport à l'origine :");
            Console.WriteLine(symetrieOrigine.ToString());




            //PointYX symetrieCombinee = p1.SymetrieAxeAbscisse().SymetrieAxeOrdonnee().SymetrieOrigine();


            //Console.WriteLine("Point après application des trois symétries :");
            //Console.WriteLine(symetrieCombinee.ToString());







            Console.ReadLine();
            
        }
    }
}
