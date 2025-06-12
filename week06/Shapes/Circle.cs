    public class Circle : Shape
    {
        private double _radius;
        
        public double GetRadius() { return _radius; }
        public void SetRadius(double radius) { _radius = radius; }


        public override double GetArea()
        {
            double pi = 3.14;
            double areaCircle = pi * _radius * _radius;
            return areaCircle;
        }


    }

