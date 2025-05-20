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
            decimal reste = solde - montant;

            if (reste >= decouvertAutorise)
            {
                solde = reste;
                return true;
            }
            else
            {
                return false; 
            }

        }

        public override string ToString()
        {
            return $"Le numero de Compte {this.numero}, avec pour nom {this.nom}, ayant pour solde {this.solde}. Vous avez un découvert autorisé de {this.decouvertAutorise}.";
        }
















    }
}
