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
            //try to catch is the triangle is negative
            try
            {
                if (Base < 0 || Hight < 0)
                {
                    throw new ArgumentOutOfRangeException("Base or ight can not be negative");
                }
                double area = (Base * Hight) / 2;
                return area;
            }
            catch (ArgumentOutOfRangeException)
            {
                Console.WriteLine("The triangle can not be negative");
                return 0;
            }
        }
    }
}
