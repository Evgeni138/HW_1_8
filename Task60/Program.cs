// Задача 60: Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Вывод:
// a[0, 0, 0] = 2
// a[0, 0, 1] = 4
// ...


void FillArray(int[,,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                int num = 1;
                while (num == 1)
                {
                    num = -1;
                    int number = new Random().Next(10, 40);
                    for (int i1 = 0; i1 < array.GetLength(0); i1++)
                    {
                        for (int j1 = 0; j1 < array.GetLength(1); j1++)
                        {
                            for (int k1 = 0; k1 < array.GetLength(2); k1++)
                            {
                                if (array[i1, j1, k1] == number)
                                {
                                    num = 1;
                                    break;
                                }
                            }
                        }
                    }
                    if (num == -1)
                    {
                        array[i, j, k] = number;
                    }
                }
            }
        }
    }
}

void PrintArray(int[,,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                Console.Write($"a[{i}, {j}, {k}] = {array[i, j, k]}  \n");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }
}

int[,,] array = new int[3, 3, 3];
FillArray(array);
PrintArray(array);
