using System.Drawing;

namespace ClassLibraryPoint
{
    public class PointYX
    {
        private float y;
        private float x;


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
            return new PointYX(-x, -y);
        }

        





















    }
}
