// Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
int[] Sorting(int[,] array, int [] Sum)
{
for (int i = 0; i < array.GetLength(0); i++)
    {
        int summ = 0;
        for (int j = 0; j < array.GetLength(1); j++)
        {
            summ = summ + array[i, j];
        }
        Sum[i] = summ;
    }
    return Sum;
}
int[] Sum = new int[4];
int[,] array = new int[4, 3];
for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        array[i, j] = new Random().Next(0, 15);
        Console.Write($"{array[i, j]} ");
    }
    Console.WriteLine();
}
Console.WriteLine();
Sorting(array, Sum);
for (int i = 0; i < Sum.Length; i++)
{
    Console.Write($"{Sum[i]} ");
}
Console.WriteLine();
int min = Sum[0];
for (int k = 0; k < Sum.Length; k++)
{
    if (Sum[k] < min)
    {
        min = Sum[k]; 
        Console.WriteLine($"Минимальная сумма в строке {k}");
    }
}

