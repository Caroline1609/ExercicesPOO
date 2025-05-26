namespace ClassLibraryFraction
{
    public class Fraction
    {
        private int numerateur;
        private int denominateur;

        public int Numerateur { get => numerateur; }
        public int Denominateur { get => denominateur; }


        public Fraction() : this(0, 1) //constructeur par defaut
        {

        }

        public Fraction(int numerateur, int denominateur)
        {

            this.numerateur = numerateur;
            this.denominateur = denominateur;
        }

        public Fraction(Fraction fractionACloner) : this(fractionACloner.numerateur, fractionACloner.denominateur) //constructeur par clonage
        {

        }

        public string ToString()
        {
            return $"Numerateur : {numerateur}/ Denominateur : {denominateur}";
        }

        public Fraction Plus(Fraction autreFraction)
        {
            return new Fraction(numerateur * autreFraction.denominateur + autreFraction.numerateur * denominateur, denominateur * autreFraction.denominateur);
        }

        public Fraction Moins(Fraction autreFraction)
        {
            return new Fraction(numerateur * autreFraction.denominateur - autreFraction.numerateur * denominateur, denominateur * autreFraction.denominateur);
        }

        public Fraction Multiplie(Fraction autreFraction)
        {
            return new Fraction(numerateur * autreFraction.numerateur, denominateur * autreFraction.denominateur);
        }

        public Fraction Diviser(Fraction autre)
        {

            Fraction inverse = new Fraction(autre.denominateur, autre.numerateur);
            return Multiplie(inverse);
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

        private int GetPgcd()
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

        public void Reduire()
        {
            
            int pgcd = GetPgcd();

            if (pgcd != 0)
            {
                numerateur /= pgcd;
                denominateur /= pgcd;

                
                if (denominateur < 0)
                {
                    numerateur = -numerateur;
                    denominateur = -denominateur;
                }
            }
        }



        public string ToDisplay()
        {
            if (denominateur == 1)
            {
                return $"{numerateur}";
            }
            else if (numerateur == 0)
            {
                return "0";
            }
            else if (numerateur == 1)
            {
                return $"1/{denominateur}";
            }
            else
            {
                return $"{numerateur}/{denominateur}";
            }
        }
















    }
















}

