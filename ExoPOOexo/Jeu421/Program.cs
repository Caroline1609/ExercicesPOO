using ClassLibraryDe;
using System.Text.RegularExpressions;
using System.Xml.Linq;


namespace Jeu421
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Manche m = new Manche();
            m.Lance();
            m.Lance(1);
            m.Lance(1, 2);


        }
    }
}
