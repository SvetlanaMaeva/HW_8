//     Задача 54: Задайте двумерный массив. Напишите программу, 
//     которая упорядочит по убыванию элементы каждой строки двумерного массива.

// Например, задан массив:

// 1 4 7 2
// 5 9 2 3
// 8 4 2 4

// В итоге получается вот такой массив:
// 1 2 4 7
// 2 3 5 9
// 2 4 4 8

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

void AscendingNumbers(int[,] array)
{

    for (int i = 0; i < array.GetLength(0); i++)
    {

        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(1) - 1; k++)
            {
                if (array[i, k] > array[i, k + 1])
                {
                    int temp = array[i, k];
                    array[i, k] = array[i, k + 1];
                    array[i, k + 1] = temp;
                }
            }
        }
    }
}
AscendingNumbers(matrix);
Console.WriteLine("Результат: ");
PrintArray(matrix);