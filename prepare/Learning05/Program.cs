using System;

class Program {
    static void Main(string[] args) {

        List<Shape> shapes = new List<Shape>();

        Square square = new Square("blue", "square", 5);
        shapes.Add(square);

        // string color = square.GetColor();
        // string shape = square.GetShape();
        // double area = square.GetArea();
        // Console.WriteLine($"The {color} {shape} has an area of {area}.");

        Rectangle rectangle = new Rectangle("red", "rectangle", 5, 10);
        shapes.Add(rectangle);

        // color = rectangle.GetColor();
        // shape = rectangle.GetShape();
        // area = rectangle.GetArea();
        // Console.WriteLine($"The {color} {shape} has an area of {area}.");

        Circle circle = new Circle("green", "circle", 8);
        shapes.Add(circle);

        // color = circle.GetColor();
        // shape = circle.GetShape();
        // area = circle.GetArea();
        //Console.WriteLine($"The {color} {shape} has an area of {area}.");
       
        foreach (Shape s in shapes) {
            string color = s.GetColor();
            double area = s.GetArea();
            string shape = s.GetShape();

            Console.WriteLine($"The {color} {shape} has an area of {area}.");
        }

    }
}