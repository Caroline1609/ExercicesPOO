namespace ClassLibraryPoint
{
    public class PointYX
    {
        private float y;
        private float x;


        //Constructeur par défaut 
        public PointYX() : this(10, 85)

        {

        }
        public PointYX(float x, float y)
        {
            this.x = x;
            this.y = y;

        }

        public float Y { get => y; }
        public float X { get => x; }


        public override string ToString()
        {
            return $"Le Point X : {x}\n et le point Y : {y}\n";
        }

        public void Deplacer(float _nouveauX, float _nouveauY)
        {
            this.x = _nouveauX;
            this.y = _nouveauY;
        }

        public void Permuter()
        {
            float temp = x;
            x = y;
            y = temp;
        }

        public PointYX SymetrieAxeAbscisse()
        {
            return new PointYX(x, -y);
        }

        public PointYX SymetrieAxeOrdonnee()
        {
            return new PointYX(-x, y);
        }

        public PointYX SymetrieOrigine()
        {

            PointYX pontIntermediaire = this.SymetrieAxeOrdonnee();

            PointYX pointFinal = pontIntermediaire.SymetrieAxeAbscisse();
            return pointFinal;
        }

        //Constructeur Par Clonage
        public PointYX(PointYX pointYXACloner) : this(pointYXACloner.x, pointYXACloner.y)

        {

        }























    }
}
