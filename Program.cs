using System;

Console.ForegroundColor = ConsoleColor.DarkBlue;
Console.WriteLine("Choose the way you want to sort the array:");
Console.WriteLine("1. Ascending");
Console.WriteLine("2. Descending");
Console.Write("Enter your choice: ");
Console.WriteLine("True for Ascending, False for Descending");
bool choice = Convert.ToBoolean(Console.ReadLine());
Console.WriteLine();

int[] arr = { 5, 2, 8, 6, 1, 9, 3, 7, 4 };

int[] ArraySort(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        for (int j = i + 1; j < arr.Length; j++)
        {
            if (choice)
            {
                if (arr[i] > arr[j])
                {
                    int temp = arr[i];
                    arr[i] = arr[j];
                    arr[j] = temp;
                }
            }
            else
            {
                if (arr[i] < arr[j])
                {
                    int temp = arr[i];
                    arr[i] = arr[j];
                    arr[j] = temp;
                }
            }
        }
    }
    return arr;
}

int[] sortedArray = ArraySort(arr);
for (int i = 0; i < sortedArray.Length; i++)
{
    Console.Write(sortedArray[i] + " ");
}