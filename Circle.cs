namespace CircleArea
{
    internal class Circle
    {
        public float Pi = 3.1415f;
        private double Radie;

        //honeslty this is unnecessary but ok 
        public double radie
        {
            get { return radie; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Radius can not be negative.");
                }
                radie = value;
            }
        }

        //constructor with one parameter
        public Circle(float radie)
        {
            this.Radie = radie;
        }

        //method - circles area
        public double CircleArea()
        {
            //Rounding up
            double area = Math.Round(Radie * Radie * Pi);
            return area;
        }

        public double SphereArea()
        {
            double area = Math.Round(4 * Radie * Radie * Pi);
            return area;
        }
    }
}
