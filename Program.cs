// See https://aka.ms/new-console-template for more information
using Arrays;
using System;
using System.Runtime.CompilerServices;



int result = RemoveDuplicates.RemoveDuplicate([2, 10, 10, 30, 30, 30]);
return;

Console.WriteLine("Enter array size");
int arraySize = int.Parse(Console.ReadLine());
int arrayLength = 0;
int[] array = new int[arraySize];

for (int i = 0; i < arraySize; i++)
{
    Console.WriteLine($"Enter {i + 1} number");
    array[arrayLength] = int.Parse(Console.ReadLine());
    arrayLength++;
}

int userChoice = -1;

while (userChoice != 0)
{
    Console.WriteLine($"Array size : {arraySize} \nArray items: {string.Join(",", array)}");
    Console.WriteLine("Select operation \n\t 1 - list \n\t 2 - Specific Index \n\t 3 - Delete at the end \n\t 4 - Insert at end\n\t 5 - Insert at Index\n\t 6 - Delete at Index\n\t 0 - Quit ");

    userChoice = int.Parse(Console.ReadLine());

    switch (userChoice)
    {
        case 1:
            DisplayArrayItems();
            break;
        case 2:
            DisplaySpecificIndexItem();
            break;
        case 3:
            DeleteAtEnd();
            break;
        case 4:
            InsertAtEnd();
            break;
        case 5:
            InsertAtIndex();
            break;
        case 6:
            DeleteAtIndex();
            break;
        case 0:
            break;
    }

}

void DisplayArrayItems()
{
    foreach (var item in array)
        Console.WriteLine(item.ToString());

    Console.WriteLine("Time complexity O(n)");
}
void DisplaySpecificIndexItem()
{
    Console.WriteLine("Enter index number");
    int index = int.Parse(Console.ReadLine());
    if (index < 0 || index >= arraySize)
    {
        Console.WriteLine("Out of bound index");
        return;
    }


    Console.WriteLine($"Item at index {index}:{array[index]}");
    Console.WriteLine("Time complexity O(1)");
}

void DeleteAtEnd()
{
    if (arrayLength == 0)
    {
        Console.WriteLine($"Nothing to delete");
        return;
    }

    array[arrayLength - 1] = 0;
    Console.WriteLine($"Deleted item at index {arrayLength}");
    arrayLength--;
    Console.WriteLine("Time complexity O(1)");
}
void InsertAtEnd()
{
    if (arrayLength == arraySize)
    {
        Console.WriteLine($"Array full");
        return;
    }
    Console.WriteLine("Enter number to insert at the end");
    array[arrayLength] = int.Parse(Console.ReadLine());
    arrayLength++;
    Console.WriteLine("Time complexity O(1)");
}

void InsertAtIndex()
{
    if (arrayLength == arraySize)
    {
        Console.WriteLine($"Array full. Cannot insert");
        return;
    }
    Console.WriteLine("Enter index number");
    int index = int.Parse(Console.ReadLine());
    if (index < 0 || index >= arraySize)
    {
        Console.WriteLine("Out of bound index");
        return;
    }
    for (int i = arraySize - 1; i > index; i--)
    {
        array[i] = array[i - 1];
    }
    Console.WriteLine($"Enter number to insert at {index}");

    array[index] = int.Parse(Console.ReadLine());
    arrayLength++;
    Console.WriteLine("Time complexity O(n)");
}

void DeleteAtIndex()
{
    if (arrayLength == 0)
    {
        Console.WriteLine($"Array Empty. Nothing to delete");
        return;
    }

    Console.WriteLine("Enter index number");
    int index = int.Parse(Console.ReadLine());
    if (index < 0 || index >= arrayLength)
    {
        Console.WriteLine("Out of bound index/ No item to delete");
        return;
    }

    for (int i = index + 1; i < arrayLength ; i++)
    {
        array[i - 1] = array[i];
    }
    array[--arrayLength] = 0;
    Console.WriteLine("Time complexity O(n)");
}
