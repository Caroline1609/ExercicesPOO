using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

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

        public CompteBancaire? RendCompte(int numero)
        {

            if (numero <= 0)
            {
                throw new ArgumentException(nameof(numero), "Le numéro de compte doit être supérieur à zéro.");
            }

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

        public override string ToString()
        {
            string resultat = $"\n==)La banque {nom} de la ville de {ville}\n\nListe des Comptes :\n";

            foreach (var compte in mesComptes)
            {
                resultat += compte.ToString() + "\n";
            }

            return resultat;
        }

        public bool Transferer(int compteDebiteur, int numeroBeneficiaire, decimal montant)
        {

            if (montant <= 0)
            {
                throw new ArgumentException(nameof(montant), "Le montant à transferer doit être supérieur à zéro.");
            }

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



    



