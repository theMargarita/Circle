namespace CircleArea
{
    internal class Circle
    {
        public float Pi = 3.1415f;
        public double Radius { get; set; }

        //constructor with one parameter
        public Circle(float radius)
        {
            this.Radius = radius;
        }

        //method - circles area
        public double CircleArea()
        {
            //Rounding up
            double area = Math.Round(Radius * Radius * Pi);
            return area;
        }

        public double SphereArea()
        {
            double area = Math.Round(4 * Radius * Radius * Pi);
            return area;
        }
    }
}
