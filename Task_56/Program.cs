// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, 
// которая будет находить строку с наименьшей суммой элементов.

// Например, задан массив:

// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7

// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

Console.Write("Введи количество строк: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Введи количество столбцов: ");
int columns = Convert.ToInt32(Console.ReadLine());

Console.Write("Минимальное число матрицы: ");
int minNumber = Convert.ToInt32(Console.ReadLine());
Console.Write("Максиамльное число матрицы: ");
int maxNumber = Convert.ToInt32(Console.ReadLine());

int[,] GetArray(int m, int n, int maxValue, int minValue)
{
    int[,] matrix = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            matrix[i, j] = new Random().Next(maxValue, minValue + 1);
        }
    }
    return matrix;
}

void PrintArray(int[,] array)
{
    for (int k = 0; k < array.GetLength(0); k++)
    {
        for (int l = 0; l < array.GetLength(1); l++)
        {
            Console.Write(array[k, l] + "\t");
        }
        Console.WriteLine();
    }
}

int[,] matrix = GetArray(rows, columns, minNumber, maxNumber);
PrintArray(matrix);

void SumColumns(int[,] array)
{
    int stringMinimumSum = 1;
    int minSum = int.MaxValue;

    for (int i = 0; i < array.GetLength(0); i++)
    {

        for (int j = 0; j < array.GetLength(1); j++)
        {
            int sum = 0;
            sum += matrix[i, j];
            if (sum < minSum)
            {
                minSum = sum;
                stringMinimumSum = i + 1;
            }
        }
    }
    Console.WriteLine($"Строка с наименьшей суммой элементов: {stringMinimumSum}");
}

SumColumns(matrix);

