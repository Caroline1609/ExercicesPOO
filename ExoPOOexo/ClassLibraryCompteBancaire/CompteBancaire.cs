namespace ClassLibraryCompteBancaire
{
    public class CompteBancaire : IComparable, IComparable<CompteBancaire>
    {
        private int numero;
        private string nom;
        private decimal solde;
        private int decouvertAutorise;

        public int Numero { get => numero; }
        public string Nom { get => nom; }
        public decimal Solde { get => solde; }
        public int DecouvertAutorise { get => decouvertAutorise; }




        public int CompareTo(object? obj)
        {
            if (obj == null)
            {
                return 1;
            }

            if (!(obj is CompteBancaire))
            {
                throw new ArgumentException("obj n'est pas du type CompteBancire attendu", nameof(obj));
            }

            //CompteBancaire objCB = (CompteBancaire)obj; //cast

            CompteBancaire? objCB2 = obj as CompteBancaire;
            if (objCB2 != null)
            {
                return this.solde.CompareTo(objCB2.Solde);

            }

            return 1;


        }


        //Constructeur par défaut 
        public CompteBancaire() : this(25485245, "Maria", 250.00m, -1000)

        {

        }


        //Constructeur Par Clonage
        public CompteBancaire(CompteBancaire compteBancaireACloner) : this(compteBancaireACloner.numero, compteBancaireACloner.nom, compteBancaireACloner.solde, compteBancaireACloner.decouvertAutorise)

        {

        }

        public CompteBancaire(int numero, string nom, decimal solde, int decouvertAutorise)
        {
            this.numero = numero;
            this.nom = nom;
            this.solde = solde;
            this.decouvertAutorise = decouvertAutorise;

        }

        public decimal Crediter(decimal montant)
        {

            if (montant <= 0)
            {
                throw new ArgumentException("Le montant à créditer doit être positif.");
            }

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

        public int CompareTo(CompteBancaire? other)
        {
            throw new NotImplementedException();
        }
    }



}

