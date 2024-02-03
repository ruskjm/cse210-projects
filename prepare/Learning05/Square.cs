public class Square : Shape {
    private double _side;

    public Square(string color, string shape, double side): base (color, shape) {
        _side = side;

    }

    public override double GetArea() {
        return _side * _side;
    }

}