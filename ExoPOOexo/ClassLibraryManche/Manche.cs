using ClassLibraryDe;

namespace ClassLibraryManche
{
    public class Manche
    {
        private const int nbrDeLancerMax = 3;
        private int nbLanceDejaLance;
        public ClassLibraryDe.De[] mes3des;

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
            IncrementerLancer();
        }

        public void Lance(int numeroUn, int numeroDeux)
        {
            mes3des[numeroUn - 1].Jeter();
            mes3des[numeroDeux - 1].Jeter();
            IncrementerLancer();
        }

        public void Lance(int numeroUn)
        {
            mes3des[numeroUn - 1].Jeter();
            IncrementerLancer();
        }

        public bool AEncoreUnLancer()
        {
            return nbLanceDejaLance < nbrDeLancerMax;
        }

        private void IncrementerLancer()
        {
            nbLanceDejaLance++;
        }

        public bool EstGagne()
        {
            Trier();
            return mes3des[0].NumeroFace == mes3des[1].NumeroFace &&
                   mes3des[1].NumeroFace == mes3des[2].NumeroFace;
        }

        public void Trier()
        {
            Array.Sort(mes3des);
            Array.Reverse(mes3des);
        }




    }
}
