// See https://aka.ms/new-console-template for more information
using System.Runtime.CompilerServices;

Console.WriteLine("Hello, World!");
Console.WriteLine("Enter array size");
int arraySize = int.Parse(Console.ReadLine());

int[] array = new int[arraySize];

for (int i = 0; i < arraySize; i++)
{
    Console.WriteLine($"Enter {i + 1} number");
    array[i] = int.Parse(Console.ReadLine());
}

int userChoice = -1;

while (userChoice != 0)
{
    Console.WriteLine("Select operation \n 1 - list \n 0 - Quit ");

    userChoice = int.Parse(Console.ReadLine());

    switch (userChoice)
    {
        case 1:
            DisplayArrayItems();
            break;
        case 0:
            DisplayArrayItems();
            break;
    }

}

void DisplayArrayItems()
{
    foreach (var item in array)
        Console.WriteLine(item.ToString());

    Console.WriteLine("Time complexity O(n)");
}

