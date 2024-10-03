using temp;
namespace Test
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Figure figure = new Triangle(3, 4, 5);

            Console.WriteLine(6==figure.Area());
            Console.WriteLine(((Triangle)figure).isRectangular());

            figure = new Circle(4);
            Console.WriteLine(Math.PI*16==figure.Area());

            if(Console.ReadLine()=="C")
                figure = new Circle(double.Parse(Console.ReadLine()));
            else
                figure=new Triangle(double.Parse(Console.ReadLine()), double.Parse(Console.ReadLine()), double.Parse(Console.ReadLine()));

            Console.WriteLine(figure.Area());
        }
    }
}
