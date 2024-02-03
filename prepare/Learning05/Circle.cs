public class Circle : Shape {
    private double _radius;

    public Circle(string color, string shape, double radius): base (color, shape) {
        _radius = radius;
    }

    public override double GetArea() {
        return _radius * _radius * Math.PI;
    }

}