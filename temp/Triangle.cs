namespace temp
{
    public class Triangle:Figure
    {
        private double _side1, _side2, _side3;
        public Triangle(double side1,double side2, double side3) { 
            _side1=side1;
            _side2=side2;
            _side3=side3;
        }
        public override double Area()
        {
            var half_perimeter = (_side1 + _side2 + _side3) / 2;
            return Math.Sqrt(half_perimeter*(half_perimeter-_side1)*(half_perimeter-_side2)*(half_perimeter-_side3));
        }

        //не использована в поиске площади, так как это приведет к увеличению необходимого количества операций
        public bool isRectangular()
        {
            return (_side1 * _side1 + _side2 * _side2 == _side3 * _side3) || (_side1 * _side1 + _side3 * _side3 == _side2 * _side2)
                || (_side3 * _side3 + _side2 * _side2 == _side1 * _side1);

        }
    }
}
