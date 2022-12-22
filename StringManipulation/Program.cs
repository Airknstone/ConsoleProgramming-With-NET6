// See https://aka.ms/new-console-template for more information

string firstName = "FirstName";
string lastName = "lastName";

DateTime date = DateTime.Now;

// Print to Screen
Console.WriteLine(firstName);
Console.WriteLine("String being Printed");

//Concatenation
Console.WriteLine(firstName + " " + lastName);
Console.WriteLine("My Full name is " + lastName + " "+ firstName);
Console.WriteLine($"My Full name is {lastName}, {firstName}");
Console.WriteLine("My full name is {0}, {1}", lastName, firstName);

// String Length
int length = firstName.Length;
Console.WriteLine($"Your name is {length} letters long.");

// Replace String parts
string newName = firstName.Replace('F', 'f');
Console.WriteLine($"Your new name is {newName}");

//Append to other string variable
string fullName = firstName + " " + lastName;
Console.WriteLine($"Your Full Name is {fullName}");

// Split String
string[] splitName = fullName.Split('N');
for (int i = 0; i < splitName.Length; i++)
{
    Console.WriteLine(splitName[i]);
}

string nullString = null;
string emptyString = "";
string whiteSpaceString = " ";
//Compare Strings
if (string.IsNullOrEmpty(nullString))
{
    Console.WriteLine("String is null");
}
if(firstName == lastName)
{
    Console.WriteLine("names are Equal");
}
if (firstName != lastName)
{
    Console.WriteLine("names are not Equal");
}

int comparisonResult = string.Compare(firstName, lastName);
if (comparisonResult == 0)
{
    Console.WriteLine("names are Equal");
}
else
{
    Console.WriteLine("names are not Equal");
}

//Convert to string
string convertedString = string.Empty;
int number = 123456789;

convertedString = number.ToString();
convertedString = 123123123.ToString();