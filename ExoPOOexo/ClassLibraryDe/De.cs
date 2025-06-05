namespace ClassLibraryDe
{
    public class De:IComparable<De>
    {
        private int numeroFace;
        private const int nbFaceMax = 6;

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

        public int CompareTo(De? orther)
        {
            if (orther == null)
            {
                return 1;
            }
            return this.numeroFace.CompareTo(numeroFace); ; 
        }
        
























    }
}
