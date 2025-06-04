using ClassLibraryDe;
using System.Xml.Linq;

namespace Jeu421
{
    internal class Program
    {
        static void Main(string[] args)
        {
            De de1 = new De(6);
            De de2 = new De(6);
            De de3= new De(6);


            de1.Jeter();
            de2.Jeter();
            de3.Jeter();




            Console.WriteLine("Valeur du dé après le lancer: " + de1.ToString());
            Console.WriteLine("Valeur du dé après le lancer: " + de2.ToString());
            Console.WriteLine("Valeur du dé après le lancer: " + de3.ToString());

            
        }
    }
}
