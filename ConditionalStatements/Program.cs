// See https://aka.ms/new-console-template for more information
//You can use ctrl + . to rename all variables;
Console.WriteLine("Enter number of apples: ");
int numberOfApples = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter number of oranges: ");
int numberOfOranges = Convert.ToInt32(Console.ReadLine());

// If Statements ( ==, < , > , >=, <=, != )
if (numberOfApples > numberOfOranges)
{
    Console.WriteLine("You have more Apples");
}
else if (numberOfApples < numberOfOranges)
{
    Console.WriteLine("You have more Oranges");
}
else if (numberOfApples == numberOfOranges)
{
    Console.WriteLine("You have the same number of apples and oranges");

}
else
{
    Console.WriteLine("Input not valid");
}


Console.WriteLine("Enter Final grade: ");
int grade = Convert.ToInt32(Console.ReadLine());
// Switch Statements
switch (grade)
{
    case int n when n <= 59 && n >= 0:
        Console.WriteLine("You failed");
        break;
    case int n when n >= 60 && n <= 100: //between 60 an 100
        Console.WriteLine("You passed");
        break;
    case 101:
        Console.WriteLine("Example of a single case");
        break;
    default:
        Console.WriteLine("Invalid Grade");
        break;
}


// Ternary Operator
var message = numberOfApples > numberOfOranges ? "You have more Apples" : "You have more Oranges";
Console.WriteLine(message);
