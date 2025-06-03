using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryCompteBancaire
{
    public class Banque
    {
        private List<CompteBancaire> mesComptes;
        private string nom;
        private string ville;

        public List<CompteBancaire> MesComptes { get => mesComptes; }
        public int NbComptes { get => mesComptes.Count; }
        public string Nom { get => nom; }
        public string Ville { get => ville; }




        public Banque(List<CompteBancaire> mesComptes, string nom, string ville)
        {
            this.mesComptes = mesComptes;
            this.nom = nom;
            this.ville = ville;
        }


        public void AjouteCompte(int numero, string nom, decimal solde, int decouvertAutorise)
        {
            CompteBancaire ajouterCompte = new CompteBancaire(numero, nom, solde, decouvertAutorise);
            AjouterCompte(ajouterCompte);
        }


        public void AjouterCompte(CompteBancaire ajouteCompte)
        {
            this.mesComptes.Add(ajouteCompte);
        }


        public CompteBancaire? CompteSup()
        {
            if (mesComptes.Count == 0)
            {
                return null;
            }

            CompteBancaire compteMax = mesComptes[0];

            int i = 1;

            while (i < mesComptes.Count)
            {
                if (mesComptes[i].Solde > compteMax.Solde)
                {

                    compteMax = mesComptes[i];
                }
                i++;
            }

            return compteMax;
        }

        public CompteBancaire RendCompte(int numero)
        {

            int i = 0;

            while (i < mesComptes.Count)
            {
                if (mesComptes[i].Numero == numero)
                {
                    return mesComptes[i];
                }

                i++;
            }

            return null;
        }

        public bool Transferer(int compteDebiteur, int numeroBeneficiaire, decimal montant)
        {

            CompteBancaire compteSource = RendCompte(compteDebiteur);
            CompteBancaire compteDestination = RendCompte(numeroBeneficiaire);

            if (compteSource == null || compteDestination == null)
            {
                return false;
            }

            return compteSource.Transferer(compteDestination, montant);
        }

       

    }
}



    



