
// See https://aka.ms/new-console-template for more information

// Inheritance means sharing attributes from common classes
// abstract means it is declared but can never be instantiated;



// This is how to inherit an interface, you can inherit multiple interfaces but only 1 class

class Rectangle : Shape, IShape
{
    public double Width { get; set; }
    public double getArea()
    {
        return Length * Width;
    }
}