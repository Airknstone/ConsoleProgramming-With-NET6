// See https://aka.ms/new-console-template for more information

// Empty DateTime
using System.Globalization;

DateTime date = new DateTime();

// Create a DateTime from date and time
DateTime dateOfBirth = new DateTime(1980, 06, 13);
Console.WriteLine("My DOB is : " + dateOfBirth);
Console.WriteLine("My day of week : " + dateOfBirth.DayOfWeek);
Console.WriteLine("My Day of year : " + dateOfBirth.DayOfYear);
Console.WriteLine("Time of Day : " + dateOfBirth.TimeOfDay);
Console.WriteLine("Tick : " + dateOfBirth.Ticks);
Console.WriteLine("Kind : " + dateOfBirth.Kind);

// Create a DateTime fomr current timestamp
DateTime now = DateTime.Now;
Console.WriteLine("The time now is: " + now);

// Create a DateTime from a string
DateTime dateFromString = DateTime.Parse("1/1/2020", CultureInfo.InvariantCulture);
Console.WriteLine("The Date from string is: " + dateFromString);

// Add Additional Time
Console.WriteLine("One hour from now is: " + now.AddHours(1));
Console.WriteLine("One day from now is: " + now.AddDays(1));

// Ticks from DateTime
Console.WriteLine("Time as a numeral: " + now.Ticks);

// Date Only
DateOnly dateOnlyOfBirth = DateOnly.FromDateTime(dateOfBirth);
Console.WriteLine("Date Only: " + dateOnlyOfBirth);

// Time Only
TimeOnly timeOnly = TimeOnly.FromDateTime(now);
Console.WriteLine("Time Only: " + timeOnly);