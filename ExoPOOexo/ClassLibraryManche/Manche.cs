using ClassLibraryDe;

namespace ClassLibraryManche
{
    internal class Manche
    {
        private const int nbrDeLancerMax = 3;
        private int nbLanceDejaLance;
        private ClassLibraryDe.De[] mes3des;

        public Manche()
        {
            nbLanceDejaLance = 1;
            mes3des = new De[3] { new De(), new De(), new De() };

        }

        public void Lancer()
        {
            foreach (De d in mes3des)
            {
                d.Jeter();

            }
            nbLanceDejaLance++;
        }

        public void Lance(int numeroUn, int numeroDeux)
        {
            mes3des[numeroUn - 1].Jeter();
            mes3des[numeroDeux - 1].Jeter();
            nbLanceDejaLance++;
        }

        public void Lance(int numeroUn)
        {
            mes3des[numeroUn - 1].Jeter();
            nbLanceDejaLance++;
        }

        public bool AEncoreUnLancer()
        {
            return nbLanceDejaLance < nbrDeLancerMax;
        }

        public bool EstGagne()
        {
            
        }

        public void Trier()
        {
            Array.Sort(mes3des);
            Array.Reverse(mes3des);
        }




    }
}
