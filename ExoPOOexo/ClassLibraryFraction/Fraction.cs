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

            if (denominateur == 0)
            {
                throw new ArgumentException("Le dénominateur ne peut pas être zéro.");
            }

            this.numerateur = numerateur;
            this.denominateur = denominateur;


        }

        public Fraction(Fraction fractionACloner) : this(fractionACloner.numerateur, fractionACloner.denominateur) //constructeur par clonage
        {

        }

        public string ToString()
        {
            return $"{numerateur}/{denominateur}";
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

            if (autre.numerateur == 0)
            {
                throw new ArgumentException("Division par zéro impossible.");
            }

            Fraction inverse = new Fraction(autre.denominateur, autre.numerateur);
            return Multiplie(inverse);
        }

        public void Oppose()
        {
            this.numerateur = -this.numerateur;
        }

        public void Inverse()
        {

            if (numerateur == 0)
            {
                throw new ArgumentException("Impossible d'inverser une fraction avec un numérateur de zéro.");
            }

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

        public bool SuperieurA(Fraction autreFraction)
        {
            if (this.Evalue() > autreFraction.Evalue())
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        double Evalue()
        {
            return this.numerateur / this.denominateur;
        }

        public bool EgaleA(Fraction autreFraction)
        {
            if (this.Evalue() == autreFraction.Evalue())
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public string ToDisplay()
        {
            if (denominateur == 1) // Si le denominateur est égale à 1 alors retourner numérateur
            {
                return $"{numerateur}";
            }
            else if (numerateur == 0) // sinon Si le numerateur est égale à 0 alors retourner 0
            {
                return "0";
            }
            else // sinon afficher le numerateur et le dénominateur
            {
                return $"{numerateur}/{denominateur}";
            }
        }



        //Surcharge d'opérateur
        public static Fraction operator +(Fraction f1, Fraction f2)
        {
            return f1.Plus(f2);
        }

        public static Fraction operator -(Fraction f1, Fraction f2)
        {
            return f1.Moins(f2);
        }

        public static Fraction operator *(Fraction f1, Fraction f2)
        {
            return f1.Multiplie(f2);
        }

        public static Fraction operator /(Fraction f1, Fraction f2)
        {
            return f1.Diviser(f2);
        }












    }
















}

