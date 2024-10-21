namespace CircleArea
{
    internal class Triangle
    {
        public double Base { get; set; }
        public double Hight { get; set; }

        //constructor with two parameter
        public Triangle(double basen, double hight)
        {
            Base = basen;
            Hight = hight;
        }

        //mthod - triangle area
        public double TriangleArea()
        {
            double area = (Base * Hight) / 2;
            return area;
        }
    }
}
