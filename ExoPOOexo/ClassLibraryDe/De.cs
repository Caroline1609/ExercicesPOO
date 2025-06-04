namespace ClassLibraryDe
{
    public class De
    {
        private int numeroFace;
        private readonly int nbFaceMax;

        public int NumeroFace { get => numeroFace;}


        public De(int nbFaceMax)
        {

            if (nbFaceMax < 1)
            {
                throw new ArgumentException("Le nombre de faces doit être supérieur à 0.");
            }

            this.nbFaceMax = nbFaceMax;
            this.numeroFace = 1;

        }

        public void Jeter()
        {
            Random de = new Random();
            this.numeroFace = de.Next(1, this.nbFaceMax + 1);
        }

        public string ToString()
        {
            return this.numeroFace.ToString();
        }

        
























    }
}
