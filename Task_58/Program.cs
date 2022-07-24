// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

// Например, заданы 2 массива:

// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7

// и

// 1 5 8 5
// 4 9 4 2
// 7 2 2 6
// 2 3 4 7

// Их произведение будет равно следующему массиву:

// 1 20 56 10
// 20 81 8 6
// 56 8 4 24
// 10 6 24 49

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
Console.WriteLine();
int[,] firstArray = GetArray(rows, columns, minNumber, maxNumber);
PrintArray(firstArray);
Console.WriteLine("\v");
int[,] secondArray = GetArray(rows, columns, minNumber, maxNumber);
PrintArray(secondArray);
int[,] finalArray = new int[rows, columns];
for (int i = 0; i < rows; i++)
{
    for (int j = 0; j < columns; j++)
    {
       finalArray[i,j] = firstArray[i, j]* secondArray[i,j];
    }
}
Console.WriteLine("\v");
PrintArray(finalArray);
