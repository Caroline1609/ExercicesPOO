using System.Security.Principal;

namespace ClassLibraryCompteBancaire
{
    public class CompteBancaire
    {
        private int numero;
        private string nom;
        private decimal solde;
        private int decouvertAutorise;



        public CompteBancaire (int numero, string nom, decimal solde, int decouvertAutorise)
        {
            this.numero = numero;
            this.nom = nom;
            this.solde = solde;
            this.decouvertAutorise = decouvertAutorise;

        }

        public decimal Crediter(decimal montant)
        {
            solde = solde + montant;
            return solde;
        }

        public bool Debiter(decimal montant)
        {
            solde = solde - montant;

            if (solde >= decouvertAutorise)
            {
                return true;
            }
            else
            {
                Console.WriteLine("\tErreur : Le solde dépasserait le découvert autorisé.\n");
                return false; 
            }

        }

        public override string ToString()
        {
            return $"Le numero de Compte : \"{this.numero}\"\nNom : {this.nom}\nSolde : {this.solde} euros \nDécouvert autorisé : {this.decouvertAutorise} euros\n";
        }


        public bool Transferer(CompteBancaire beneficiary, decimal montantAtransferer)
        {
            bool result = this.Debiter(montantAtransferer);

            if (result)
            {
                beneficiary.Crediter(montantAtransferer);
                return true;
            }
            else
            {
                return result;
            }

            
        }

        public bool Comparer(CompteBancaire compteAComparer)
        {

            if (this.solde > compteAComparer.solde)
            {
                return true;
            }
            else
            {
                return false;
            }

        }
    }

}

