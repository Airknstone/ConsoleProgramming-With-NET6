// See https://aka.ms/new-console-template for more information

// Declare Fixed Size Array
int[] grades = new int[5]; //array of type int will reserve 5 spaces for this array, 0, 1, 2, 3,4 

// Adding values to Fixed Size Array
/*grades[0] = 1;
grades[1] = 2;
grades[2] = 3;

grades[3] = 4;
grades[4] = 5;*/

// Alternativley 
//int[] grades = new int[] { 1, 2, 3, 4, 5 };
Console.WriteLine("Enter All Grades");
for (int i = 0; i < grades.Length; i++)
{
    Console.Write("Enter Grade: ");
    grades[i] = Convert.ToInt32(Console.ReadLine());
}

// Print values in Fixed Size Array
Console.WriteLine("The Grades you have entered are: ");
for(int i = 0; i < grades.Length; i++)
{
    Console.WriteLine($"Index {i} contains {grades[i]}");
}

// Declare Variable Sized Array
string[] studentNames = new string[] {"Test", "Student1", "etc..."};
Console.WriteLine("Enter All Names");
for (int i = 0; i < studentNames.Length; i++)
{
    Console.Write("Enter Grade: ");
    studentNames[i] = Console.ReadLine();
}

for (int i = 0; i < studentNames.Length; i++)
{
    Console.WriteLine(studentNames[i]);
}
