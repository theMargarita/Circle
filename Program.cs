namespace CircleArea
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Circle circle1 = new Circle(5);
            Console.WriteLine(circle1.CircleArea());

            Circle circle2 = new Circle(6);
            Console.WriteLine(circle2.CircleArea());

            Circle sphere1 = new Circle(5);
            Console.WriteLine(sphere1.SphereArea());

            Circle sphere2 = new Circle(6);
            Console.WriteLine(sphere2.SphereArea());
        }
    }
}
