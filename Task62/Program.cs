void FillArray(int [,] array)
{
    int number = 1;

    for (int j = 0; j < array.GetLength(1); j++)
    {
        array[0, j] = number;
        number++;
    }

    for (int i = 1; i < array.GetLength(0); i++)
    {
        array[i, array.GetLength(1)-1] = number;
        number++;
    }

    for (int j = array.GetLength(1)-2; j >= 0; j--)
    {
        array[array.GetLength(0)-1, j] = number;
        number++;
    }

    for (int i = array.GetLength(0)-2; i > 0; i--)
    {
        array[i, 0] = number;
        number++;
    }

    int x = 1;
    int y = 1;

    while (number < array.GetLength(0) * array.GetLength(1))
    {
        while (array[x, y + 1] == 0)
        {
            array[x, y] = number;
            number++;
            y++;
        }

        while (array[x+1, y] == 0)
        {
            array[x, y] = number;
            number++;
            x++;
        }
        
        while (array[x, y - 1] == 0)
        {
            array[x, y] = number;
            number++;
            y--;
        }

        while (array[x-1, y] == 0)
        {
            array[x, y] = number;
            number++;
            x--;
        }
    }

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i, j] == 0) array[i, j] = number;
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

int[,] array = new int[4, 4];
FillArray(array);
PrintArray(array);