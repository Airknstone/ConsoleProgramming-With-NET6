// See https://aka.ms/new-console-template for more information

// Declare a list
List<string> names = new List<string>();
string name = string.Empty;

// Add Values to List
//names[0] = "TestName";
names.Add("ME");//USE .ADD instead of assignment above
names.Remove("ME");

Console.WriteLine("Enter Names: ");

//while( name != "-1")
//while( name.Equals("-1") == false)
while (!name.Equals("-1"))
{
    Console.Write("Enter Name: ");
    name = Console.ReadLine();
    if (!string.IsNullOrEmpty(name) && !name.Equals("-1"))
    {
        names.Add(name);
        Console.Write($"{name} was added Successfully.");
    }
}

// Print Values in list
Console.WriteLine("Printing names via for loop");
for (int i = 0; i < names.Count; i++) //NOTE THE USE OF COUNT INSTEAD OF LENGTH, count is used for LISTS
{
    Console.WriteLine(names[i]);
}

//USING FOR EACH LOOP
Console.WriteLine("Printing names via foreach loop");
foreach (string item in names)
{
    Console.WriteLine(item);
}