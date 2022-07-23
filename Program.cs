// Семинар 8

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

void ChangeRows(int[,] matrix)
{
    int indexLastRows = matrix.GetLength(0)-1;
    for (int p = 0; p < matrix.GetLength(1); p++)
    {
        int temp = matrix[0,p];
        matrix[0,p] = matrix[indexLastRows,p];
        matrix[indexLastRows,p] = temp;
    }
}

ChangeRows(matrix);
Console.WriteLine("Результат: ");
PrintArray(matrix);