// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет
// находить строку с наименьшей суммой элементов.
// 9 9 9
// 1 1 1
// 5 6 7
// -> вторая строка



void FillArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(0, 10);
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

int SumRow(int[,] array, int i)
{
    int sum = 0;
    for (int j = 0; j < array.GetLength(1); j++)
    {
        sum = sum + array[i, j];
    }
    return sum;
}

int MinRow(int[,] array)
{
    int minSumRow = SumRow(array, 0);
    int indexRow = 1;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        if (minSumRow > SumRow(array, i))
        {
            minSumRow = SumRow(array, i);
            indexRow = i + 1;
        }
    }
    return indexRow;
}

int[,] array = new int[3, 3];
FillArray(array);
PrintArray(array);
Console.WriteLine();
Console.WriteLine(MinRow(array) + " строка");