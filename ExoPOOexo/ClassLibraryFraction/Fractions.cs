namespace ClassLibraryFraction
{
    public class Fractions
    {
        private int numerateur;
        private int denominateur;


        public int Numerateur { get => numerateur; }
        public int Denominateur { get => denominateur; }

        public Fractions(int numerateur, int denominateur)
        {
            this.numerateur = numerateur;
            this.denominateur = denominateur;

        }

        public string ToString()
        {
            return $"{numerateur}/{denominateur}";
        }

        

        public Fractions Divise(Fractions autreFraction)
        {
            return new Fractions(this.numerateur * autreFraction.denominateur, this.denominateur * autreFraction.numerateur);
        }







        public string ToDisplay()
        {
            return $"{numerateur}/{denominateur}";
        }


    }
}
