public abstract class Shape {

    protected string _color;

    protected string _shape;

    public Shape(string color, string shape) {
        _color = color;
        _shape = shape;
    }

    public string GetColor() {
        return _color;
    }

    public void SetColor(string color) {
        _color = color;
    }

    public string GetShape() {
        return _shape;
    }

    public void SetShape(string shape) {
        _shape = shape;
    }

    public abstract double GetArea();
    
}