// See https://aka.ms/new-console-template for more information

//For Loop (Counter Controlled)
for (int i = 0; i < 10 ; i++)
{
    Console.WriteLine(i);
}

// While Loop (Condition Controlled - Pre Check)
int n = 0;
while(n < 5)
{
    Console.WriteLine(n);
    n++;
}


// Do... While Loop (Condition Controlled - Post Check)
int y = 0;
do
{
    Console.WriteLine("input a number:");
    y = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine($"You entered {y}: ");
} while (y < 5);

// Foreach - Honourable Mention
//foreach (var item in collection)
//{

//}