using System;
using System.Collections.Generic;
using System.Linq;
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


        public Banque(Banque banqueACloner) : this(banqueACloner.mesComptes, banqueACloner.nom, banqueACloner.ville)
        {

        }


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


        public CompteBancaire CompteSup()
        { 
            CompteBancaire compteMax = mesComptes[0];

            foreach (var compte in mesComptes)
            {
                if (compte.Solde > compteMax.Solde)
                {
                    compteMax = compte;
                }
                    
            }

            return compteMax;
        }

        public CompteBancaire RendCompte(int numero)
        {
            foreach (var compte in mesComptes)
            {
                if (compte.Numero == numero)
                {
                    return compte;
                }
                    
            }
            return null;
        }

        public bool Transferer(int numDebitaire, int numBeneficiaire, decimal montant)
        {
            CompteBancaire Debitaire = RendCompte(numDebitaire);
            CompteBancaire beneficiaire = RendCompte(numBeneficiaire);

            if ()
            {

            }



        }

        












    }
}
