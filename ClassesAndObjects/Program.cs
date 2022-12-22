// See https://aka.ms/new-console-template for more information
//Classes let us define our own datatypes 

// The Class is meant to do all the hard work and logic and is encapsulated away from the implementation
//The implementation is suppose to be as easy as possible like shown below;

// Primitive datatypes
//int, char, double string etc

// Object Oriented Programming - Creating your own datatype
// Class - Blueprint- ex house is an object of the blueprint class

// Single Responsibility Principle
//Shortcut to create a class in VS windows + . then move type to person.cs example
/*class Person // this type has primitive types declared in it
{
    public string Name { get; set; } //Getters and setters used to get and set this property
    public string LastName { get; set; }
    public int Age { get; set; }
}
*/
using ClassesAndObjects;

Person person = new Person();
//Person person1 = new(); //can also be declared like this// new
//Operator Overloading example -- adding middle name to fullname 
string middleName = string.Empty;

Console.WriteLine("Enter First Name: ");
person.FirstName = Console.ReadLine();

Console.WriteLine("Enter Last Name: ");
person.LastName = Console.ReadLine();

Console.WriteLine("Enter Age: ");
person.Age = Convert.ToInt32(Console.ReadLine());

DateTime todaysDate = DateTime.Now;
int yob = todaysDate.Year - person.Age;
Console.WriteLine($"Year of Birth is: {yob}");

Console.WriteLine("Enter Salary: ");
int salary = Convert.ToInt32(Console.ReadLine());
person.setSalary(salary); //Keyboard shortcut click on setSalary and press f12 to go to definition

Console.WriteLine("Enter MiddleName: ");
middleName = Console.ReadLine();

if (string.IsNullOrEmpty(middleName))
{
    Console.WriteLine($"Full Name is: {person.getFullName()}");
}
else
{
    Console.WriteLine("Full Name is " + person.getFullName(middleName)); // will get an error since no param is specified. going to modifiy class to overload, create a method with the same name
}

/*Console.WriteLine($"First Name is: {person.FirstName}");
Console.WriteLine($"Last Name is: {person.LastName}");*/
//Console.WriteLine($"Full Name is: {person.getFullName()}");
Console.WriteLine($"Age is: {person.Age}");
Console.WriteLine("Year of Birth is: " + DateUtil.YearOfBirth(person.Age));
Console.WriteLine($"Salary is: {person.getSalary()}");


// Static Classes, add the key word static inside of the dateutil class to make the class static, add it to the methods as well, 
//DateUtil dateUtil = new DateUtil(); // after making class static- this no longer works
