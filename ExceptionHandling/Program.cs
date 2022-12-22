// See https://aka.ms/new-console-template for more information

/*
 try - a try block attempts an operation 
 catch - catch any fatal error or exception
 finally - whether the try or the catch was successful, do this
 throw - end program execution with the error
 */

Console.WriteLine("Enter a number 1: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter a number 2: ");
int number2 = Convert.ToInt32(Console.ReadLine());

try
{
int quotient = number1 / number2; // will crash if numer2 = 0

    Console.WriteLine($"The result is:  {quotient.ToString()}");
}
//cam do multiple catch blocks
catch (DivideByZeroException ex)
{
    Console.WriteLine($"Illegal operation: {ex.Message}");
}
catch (Exception ex)
{

	throw ex; // Only throw if you want to end a program
}
finally
{
    Console.WriteLine("This is the end of the program");

}



