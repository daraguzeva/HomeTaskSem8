//Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

int[,] arr1 = new int[2, 2];
for (int i = 0; i < arr1.GetLength(0); i++)
{
    for (int j = 0; j < arr1.GetLength(1); j++)
    {
        arr1[i, j] = new Random().Next(0, 10);
        Console.Write($"{arr1[i, j]} ");
    }
    Console.WriteLine();
}
Console.WriteLine();

int[,] arr2 = new int[2, 2];
for (int i = 0; i < arr2.GetLength(0); i++)
{
    for (int j = 0; j < arr2.GetLength(1); j++)
    {
        arr2[i, j] = new Random().Next(0, 10);
        Console.Write($"{arr2[i, j]} ");
    }
    Console.WriteLine();
}
Console.WriteLine();
int[,] array = new int[2, 2];
array[0, 0] = arr1[0, 0] * arr2[0, 0] + arr1[1, 0] * arr2[1, 0];

