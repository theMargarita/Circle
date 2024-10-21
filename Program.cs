namespace CircleArea
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //obects
            Circle circle1 = new Circle(5);
            Console.WriteLine(circle1.CircleArea());

            Circle circle2 = new Circle(6);
            Console.WriteLine(circle2.CircleArea());

            Circle sphere1 = new Circle(5);
            Console.WriteLine(sphere1.SphereArea());

            Circle sphere2 = new Circle(6);
            Console.WriteLine(sphere2.SphereArea());

            Triangle triangle1 = new Triangle(5, 5);
            Console.WriteLine(triangle1.TriangleArea());

            Triangle triangle2 = new Triangle(6, 6);
            Console.WriteLine(triangle2.TriangleArea());
        }
    }
}
