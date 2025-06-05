using ClassLibraryDe;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryJeu421
{
    internal class Manche
    {
        private int nbrDeLancerMax = 3;
        private int nbLanceDejaRealise = 1;

        public Manche()
        {

        }

        //public bool EstGagner()
        //{
        //    if ()
        //    {

        //    }
        //}


        public void Lancer()
        {
            De[] des = new De[3];

            for (int i = 0; i < des.Length; i++)
            {
                des[i] = new De();
            }

            

        }


        public bool AEncoreUnLance()
        {
            return nbLanceDejaRealise < nbrDeLancerMax;
        }
    }
}
