namespace ClassLibraryFraction
{
    public class Fraction
    {
        private int numerateur;
        private int denominateur;


        public int Numerateur { get => numerateur; }
        public int Denominateur { get => denominateur; }


        public Fraction() : this(1,2)
        {

        }

        public Fraction(int numerateur, int denominateur)
        {
            this.numerateur = numerateur;
            this.denominateur = denominateur;

        }

        public string ToString()
        {
            return $"{this.numerateur}/{denominateur}"; //a modifier
        }  

        public void Oppose()
        {
            this.numerateur = -this.numerateur;
        }

        public void Inverse()
        {
            int temp = this.numerateur;
            this.numerateur = this.denominateur;
            this.denominateur = temp;
        }

        private int getPgcd()
        {
            int a = this.numerateur;
            int b = this.denominateur;
            int pgcd = 1;

            if (a != 0 && b != 0)
            {
                if (a < 0)
                {
                    a = -a;
                }
                if (b < 0)
                {
                    b = -b;
                }
                while (a != b)
                {
                    if (a < b)
                    {
                        b = b - a;
                    }
                    else
                    {
                        a = a - b;
                    }
                }
                pgcd = a;
            }

            return pgcd;
        }

        public bool SuperieurA(Fraction autreFraction)
        {
            bool resultat;

            if (this.numerateur * autreFraction.denominateur > autreFraction.numerateur * this.denominateur)
            {
                resultat = true;
            }
            else
            {
                resultat = false;
            }
            return resultat;
        }

        public bool EgalA(Fraction autreFraction)
        {
            bool resultat;

            if (this.numerateur * autreFraction.denominateur == autreFraction.numerateur * this.denominateur)
            {
                resultat = true;
            }
            else
            {
                resultat = false;
            }
            return resultat;                   

        }



























        public Fraction(Fraction fractionACloner) : this(fractionACloner.numerateur, fractionACloner.denominateur)
        {

        }













    }

    

        

        







        //public string ToDisplay()
        //{
        //    return $"{numerateur}/{denominateur}";
        //}


}

