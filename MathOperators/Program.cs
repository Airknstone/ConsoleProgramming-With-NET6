// See https://aka.ms/new-console-template for more information
// Basic Assignment Operator

int num = 5;


// Arithmetic Operators
int num1 = 11;
int num2 = 12;

Console.WriteLine($"Addition: {num1 + num2}");
Console.WriteLine($"Subtraction: {num1 - num2}");
Console.WriteLine($"Multiplication: {num1 * num2}");
Console.WriteLine($"Division: {num1 / num2}");
Console.WriteLine($"Modulus: {num1 % num2}");

num1 = num1 + 4;
Console.WriteLine($"New Value: {num1}");
Console.WriteLine($"Addition: {num1 + num2}");
Console.WriteLine($"Subtraction: {num1 - num2}");
Console.WriteLine($"Multiplication: {num1 * num2}");
Console.WriteLine($"Division: {num1 / num2}");
Console.WriteLine($"Modulus: {num1 % num2}");

// Compount Assignment Operators
//Changing the value of num1 each time;
num1 += 4; //19
num1 -= 4; //15
num1 *= 4; //60
num1 /= 4; //15
num1 %= 4; //3