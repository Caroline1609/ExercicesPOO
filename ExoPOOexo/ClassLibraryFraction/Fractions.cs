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
            return $"{this.numerateur}/{denominateur}";
        }

        public Fractions Divise(Fractions autreFraction)
        {
            return new Fractions(this.numerateur * autreFraction.denominateur, this.denominateur * autreFraction.numerateur);
        }


        public bool EgalA(Fractions autreFraction)
        {
            bool result;


            if (this.numerateur * autreFraction.denominateur == autreFraction.numerateur * this.denominateur)
            {

                result = true;

            }
            else
            {

                result = false;
            }

            return result;
        }

    }

    

        

        







        //public string ToDisplay()
        //{
        //    return $"{numerateur}/{denominateur}";
        //}


}

