using System;

class Program
{
    static void Main(string[] args)
    {
        Square square1 = new Square();
square1.SetColor("blue");
square1.SetSide(5.9);
double area= square1.GetArea();
Console.WriteLine($"The square is {square1.GetColor()} with the area of {area} m^2");
           
Rectangle rectangle1 = new Rectangle();
rectangle1.SetColor("red");
rectangle1.SetLength(7.9);
rectangle1.SetWidth(9.5);
double areaRect = rectangle1.GetArea();
Console.WriteLine($"The Rectangle is {rectangle1.GetColor()} with the area of {areaRect} m^2");

Circle circle1 = new Circle();
circle1.SetColor("green");
circle1.SetRadius(10.45);
double areaCirc=circle1.GetArea();
Console.WriteLine($"The Circle is {circle1.GetColor()} with the area of {areaCirc} m^2");

List<Shape> shapes = new List<Shape>() {square1,rectangle1,circle1 };

for (int i = 0; i < shapes.Count; i++) {

    Console.WriteLine(shapes[i].GetColor());
    Console.WriteLine();
    Console.WriteLine(shapes[i].GetArea());

}
    }
}