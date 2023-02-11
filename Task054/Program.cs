// Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.


int[,] Sorting(int[,] Array)
{
    // int[] arr = new int[4];
    // for (int i = 0; i < 4; i++)
    // {
    //     for (int k = 0; k < Array.GetLength(1); k++)
    //     {
    //         arr[k] = Array[i, k];
    //         Console.Write($"{arr[k]} ");
    //     }
    //     Console.WriteLine();
    // }
    for (int i = 0; i < Array.GetLength(0); i++)
    {
        for (int j = 0; j < Array.GetLength(1)-1; j++)
        {
            
            if (Array[i, j] > Array[i, j + 1])
            {
                int temp = Array[i, j];
                Array[i, j] = Array[i, j + 1];
                Array[i, j + 1] = temp;
            }
        }
    }
    return Array;
}

int[,] array = new int[4, 4];
for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        array[i, j] = new Random().Next(0, 5);
        Console.Write($"{array[i, j]} ");
    }
    Console.WriteLine();
}
Console.WriteLine();


int[,] A = Sorting(array);
//Array.Sort(array, A);
Console.WriteLine();
for (int k = 0; k < A.GetLength(0); k++)
{
    for (int p = 0; p < A.GetLength(1); p++)
    {
        Console.Write($"{A[k, p]} ");
    }
    Console.WriteLine();
}
Console.WriteLine();