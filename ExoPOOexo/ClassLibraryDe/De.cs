namespace ClassLibraryDe
{
    public class De
    {
        private int numeroFace;
        private readonly int nbFaceMax = 6;

        public int NumeroFace { get => numeroFace;}


        public De()
        {

            Jeter();

        }

        public void Jeter()
        {
            Alea alea = Alea.Instance();
            numeroFace = alea.Nouveau(1, nbFaceMax);
        }

        public string ToString()
        {
            return this.numeroFace.ToString();
        }

        
























    }
}
