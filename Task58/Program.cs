// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Пример скоро будет.


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

int[,] Product(int[,] array1, int[,] array2)
{
    int[,] arrayProduct = new int[array1.GetLength(0), array1.GetLength(1)];
    for (int i = 0; i < array1.GetLength(0); i++)
    {
        for (int j = 0; j < array1.GetLength(1); j++)
        {
            arrayProduct[i, j] = array1[i, j] * array2[i, j];
        }
    }
    return arrayProduct;
}

int[,] array1 = new int[3, 3];
int[,] array2 = new int[3, 3];
FillArray(array1);
PrintArray(array1);
Console.WriteLine();
FillArray(array2);
PrintArray(array2);
Console.WriteLine();
int[,] arrayProduct = Product(array1, array2);
PrintArray(arrayProduct);