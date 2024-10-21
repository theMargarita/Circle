namespace CircleArea
{
    internal class Circle
    {
        public float Pi = 3.1415f;
        public double Radie { get; set; }

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
    }
}
