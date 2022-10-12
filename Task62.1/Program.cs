// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

void PrintArray(int[,] arr)
{
    Console.WriteLine();
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            if (arr[i, j] < 10)
            {
                Console.Write($"0{arr[i, j]} ");
            }
            else
            {
            Console.Write(arr[i, j] + " ");
            }
        }
        Console.WriteLine();
    }
}

void FillArray(int[,] arr)
{
    int n = arr.GetLength(1)*arr.GetLength(0);
    int i = 0;
    int j = 0;
    int count = 1;
    arr[i, j] = count;
    while (count < n)
    {
        while (j + 1 < arr.GetLength(1) && arr[i, j + 1] == 0)
        {
            j++;
            count++;
            arr[i, j] = count;
        }
        while (i + 1 < arr.GetLength(0) && arr[i + 1, j] == 0)
        {
            i++;
            count++;
            arr[i, j] = count;
        }
        while (j > 0 && arr[i, j - 1] == 0)
        {
            j--;
            count++;
            arr[i, j] = count;
        }

        while (i > 0 && arr[i - 1, j] == 0)
        {
            i--;
            count++;
            arr[i, j] = count;
        }
    }
}

//КОД ОСНОВНОЙ ПРОГРАММЫ
int[,] array = new int[4, 4];
FillArray(array);
PrintArray(array);
