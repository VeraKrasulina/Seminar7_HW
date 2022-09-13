// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Найдите среднее арифметическое элементов в каждом столбце.

int[,] GetArray(int m, int n, int minValue, int maxValue)
{
    int[,] res = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            res[i, j] = new Random().Next(minValue, maxValue);
        }
    }
    return res;
}

int[,] arrey = GetArray(5, 5, 0, 5);

void PrintArray(int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Console.Write(inArray[i, j] + "\t");
        }
        Console.WriteLine();
    }
}

PrintArray(arrey);
Console.WriteLine();

int sum = 0;
for (int j = 0; j <= arrey.GetLength(1) - 1; j++)
{
    for (int i = 0; i < arrey.GetLength(0); i++)
    {
        sum = sum + arrey[i, j];
    }
    double average = (double)sum / arrey.GetLength(1);
    Console.WriteLine($"Среднее арифметическое значение стобца {j} - {Math.Round(average, 1)}.");
    sum=0;
}
