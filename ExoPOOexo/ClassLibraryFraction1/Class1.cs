namespace ClassLibraryFraction1
{
        public class Fraction
        {
            private int numerateur;
            private int denominateur;


            public int Numerateur { get => numerateur; }
            public int Denominateur { get => denominateur; }


            public Fraction() : this(1, 2) //constructeur par defaut
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

            public string ToString()
            {
                Reduire();
                return $"{numerateur}/{denominateur}";


            }

            public Fraction Plus(Fraction autreFraction)
            {
                return new Fraction(Numerateur * autreFraction.Denominateur + autreFraction.Numerateur * Denominateur, Denominateur * autreFraction.Denominateur);
            }

            public Fraction Moins(Fraction autreFraction)
            {
                return new Fraction(Numerateur * autreFraction.Denominateur - autreFraction.Numerateur * Denominateur, Denominateur * autreFraction.Denominateur);
            }

            public Fraction Multiplie(Fraction autreFraction)
            {
                return new Fraction(Numerateur * autreFraction.Numerateur, Denominateur * autreFraction.Denominateur);
            }

            public Fraction Diviser(Fraction autre)
            {
                if (autre.Numerateur == 0)
                {
                    throw new ArgumentException("Impossible de diviser par une fraction avec un numérateur de zéro.");
                }

                Fraction inverse = new Fraction(autre.Denominateur, autre.Numerateur);
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

            private void Reduire()
            {
                int pgcd = GetPgcd();
                this.numerateur /= pgcd;
                this.denominateur /= pgcd;

                if (denominateur < 0)
                {
                    numerateur = -numerateur;
                    denominateur = -denominateur;
                }
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

            public string ToDisplay()
            {
                return $"{numerateur}/{denominateur}";
            }


            public Fraction(Fraction fractionACloner) : this(fractionACloner.numerateur, fractionACloner.denominateur) //constructeur par clonage
            {

            }
        }
}
