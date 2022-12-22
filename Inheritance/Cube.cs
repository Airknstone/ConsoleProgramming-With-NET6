
// See https://aka.ms/new-console-template for more information

// Inheritance means sharing attributes from common classes
// abstract means it is declared but can never be instantiated;


public class Cube : Shape

{


    public Cube(int width, int height, int length) //overloaded constructor
    {
        Width = width;
        Height = height;
        Length = length;    
    }
    public double Width { get; set; }

    public double getArea()
    {
        return Length * Width;
    }
}


