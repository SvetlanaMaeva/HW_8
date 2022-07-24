// Задача 60. Сформируйте трёхмерный массив из неповторяющихся 
// двузначных чисел. Напишите программу, которая будет построчно выводить массив, 
// добавляя индексы каждого элемента.

// массив размером 2 x 2 x 2

// 12(0,0,0) 22(0,0,1)

// 45(1,0,0) 53(1,0,1)


int sizeArray = 2;
int[,,] array = new int[2,2,2];

for (int i = 0; i < sizeArray; i++)
{
    for (int j = 0; j < sizeArray; j++)
    {
        for (int k = 0; k < sizeArray; k++)
        {
            array[i, j, k] = new Random().Next(10,100);
            System.Console.WriteLine($"{array[i, j, k]} ({i}, {j}, {k}) \t");
        }
        System.Console.WriteLine();
    }
    System.Console.WriteLine();
}