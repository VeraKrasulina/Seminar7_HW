// Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

Console.Write("Введите количество строк массива: ");
int rows = int.Parse(Console.ReadLine());

Console.Write("Введите количество столбцов массива: ");
int columns = int.Parse(Console.ReadLine());

double[,] FillArray2(int line, int col, int min, int max)
{
    double[,] matr = new double[line, col];
    Random rand = new Random();
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = Math.Round((rand.NextDouble() * max), 2);
        }
    }
    return matr;
}

void PrintArray2(double[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write(matr[i, j] + "\t");
        }
        Console.WriteLine();
    }
}

double [,] arrey = FillArray2 (rows, columns, 0, 10);
PrintArray2 (arrey);