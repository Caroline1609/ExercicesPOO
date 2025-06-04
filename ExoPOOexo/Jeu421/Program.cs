using ClassLibraryDe;
using System.Xml.Linq;

namespace Jeu421
{
    internal class Program
    {
        static void Main(string[] args)
        {

            De d1 = new De();

            d1.Jeter();

            Console.WriteLine("après le lancer : " + d1.NumeroFace);

        }
    }
}
