// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// 6 4 1 9
// 4 9 1 2
// ->
// 9 6 4 1
// 9 4 2 1


void FillArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(0, 100);
        }
    }
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++) 
        {
            Console.Write($"{array[i, j], 4}");
        }
        Console.WriteLine();
    }
}

int[,] SortArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int k = 0; k < array.GetLength(1)-1; k++)
        {
            int min = array[i, 0];
            for (int j = 1; j < array.GetLength(1); j++)
            {
                    
                if (array[i, j] > min)
                {
                    int help = array[i, j-1];
                    array[i, j-1] = array[i, j];
                    array[i, j] = help;
                }
                else min = array[i, j];
            }
        }
    }
    return array;
}

int[,] array = new int[5, 6];
FillArray(array);
PrintArray(array);
Console.WriteLine();
SortArray(array);
PrintArray(array);

