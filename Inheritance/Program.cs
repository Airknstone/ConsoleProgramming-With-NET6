
// See https://aka.ms/new-console-template for more information

// Inheritance means sharing attributes from common classes
// abstract means it is declared but can never be instantiated;





Console.WriteLine("Enter Length: ");
int length = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter width: ");
int width = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter height: ");
int height = Convert.ToInt32(Console.ReadLine());

Cube cube = new Cube(width, height, length);
var rectangle = new Rectangle();

rectangle.Length = length;
rectangle.Width = width;
rectangle.Height = height;

Console.WriteLine("Cube Area is: " + cube.getArea());
Console.WriteLine("Recangle Area is: " + rectangle.getArea());