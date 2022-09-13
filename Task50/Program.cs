// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
// принимает позиции элемента в двумерном массиве,
// возвращает значение этого элемента или же указание, что такого элемента нет.

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

int[,] arrey = GetArray(10, 10, 0, 100);

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

Console.Write("Введите адрес ячейки массива через пробел: ");
string imput = Console.ReadLine();

int[] ConvertToIntArrey(string text, char separator)
{
    string[] imput = text.Split(separator);
    int[] numbers = new int[imput.Length];
    for (int i = 0; i < numbers.Length; i++)
    {
        int j;
        string temp = imput[i];
        if (int.TryParse(temp, out j)) { numbers[i] = j; }
    }
    return numbers;
}

int[] output = ConvertToIntArrey(imput, ' ');

if (output[0] <= arrey.GetLength(0) - 1 && output[1] <= arrey.GetLength(1) - 1)
{
    Console.WriteLine();
    Console.WriteLine($"Значение в ячейке массива {output[0]},{output[1]} является {arrey[output[0], output[1]]}.");
}
else Console.WriteLine($"Ячейки массива с адресом {output[0]},{output[1]} не существует.");