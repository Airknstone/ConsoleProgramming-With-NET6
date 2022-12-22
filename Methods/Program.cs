// See https://aka.ms/new-console-template for more information

// Prototype - Defines the function ( type, name and parameters) - may not always have 

// Definition - Has the code. It contains the code block - always have
// Function Call - Makes the function- always have

//Console.WriteLine(); // this is a void example
//Console.ReadLine(); // this ia a value returning function, a string!

// Void FUnctions- Completes a task and exits, moves along
void PrintName()
{
    Console.WriteLine("My Name");
}

void Addition(int num1, int num2)
{
    Console.WriteLine($"The Sum of {num1} and {num2} is {num1 + num2}");

}

// Value Returning Functions - COmpletes a taska, retuns a result
int LargestNumber(int num1, int num2, int num3)
{
    int largest = num1;

    if(largest < num2)
    {
        largest = num2;
    }
    if (largest < num3)
    {
        largest = num3;
    }
    return largest;
}
PrintName();

Console.WriteLine("Enter a number 1: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter a number 2: ");
int number2 = Convert.ToInt32(Console.ReadLine());

Addition(number1, number2);

Console.WriteLine("Enter a number 3: ");
int number3 = Convert.ToInt32(Console.ReadLine());

int result = LargestNumber(number1, number2, number3);
Console.WriteLine($"The largest number is {result}");
