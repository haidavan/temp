namespace temp
{
    public class Circle : Figure
    {
        private double _radius;
        public Circle(double radius) => _radius = radius;
        public override double Area() => Math.PI * _radius * _radius;
    }
}
