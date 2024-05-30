using Shapes.Library.Models;
using Shapes.Library.Models.Base;

List<Shape> shapes = new List<Shape>();
Circle circle = new Circle(2);
Triangle triangle = new Triangle(1, 2, 3, 90, 45, 45);
shapes.Add(circle);
shapes.Add(triangle);

foreach (var shape in shapes)
{
    Console.WriteLine(shape.Area);
}