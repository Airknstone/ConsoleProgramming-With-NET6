// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
//Default values - numbers will default to 0 if no value is given, Strings chars will default to null .

string fullName = string.Empty; // Here we are letting c# set the value as empty for us, it is best practice to do this, the traditional empty quotes could lead to a problem if you accidentally add a space in there.

int age = 0;

double salary = 0.0; // a decimal

//float salary = 0.0f; // f is meant to represent that it is a float

//decimal salary = 0.0M;

char gender = char.MinValue;

bool working = false;

Console.Write("Please Enter Your Name: ");
fullName = Console.ReadLine(); //reads as a string!!

Console.Write("Please Enter Your Age: ");
age = Convert.ToInt32(Console.ReadLine()); //reads as a string!!
                                           //
Console.Write("Please Enter Your Salary: ");
salary = Convert.ToDouble(Console.ReadLine()); //reads as a string!!

Console.Write("Please Enter Your Gender: (M or F)");
gender = Convert.ToChar(Console.ReadLine()); //reads as a string!!

Console.Write("Please Enter Your Working: (True or False) ");
working = Convert.ToBoolean(Console.ReadLine()); //reads as a string!!

//print information, notice how a number is inserted into a block of string, this is because C# will always convert to a string if it can
Console.WriteLine("Your Name is: " + fullName); //concatenation
Console.WriteLine("Your Age is: {0}", age); // arg sequence
Console.WriteLine($"Your Salary is: {salary}"); // interpolation
Console.WriteLine($"Your Gender is: {gender}"); // interpolation
Console.WriteLine($"Your Employed: {working}"); // interpolation