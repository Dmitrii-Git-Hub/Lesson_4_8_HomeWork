// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

void FillArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = new Random().Next(1, 10);
        }
    }
}

void PrintArray(int[,] arr)
{
    Console.WriteLine();
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write(arr[i, j] + " ");
        }
        Console.WriteLine();
    }
}

void ArrangeArrayElements(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            int max = arr[i, j];
            for (int k = j; k < arr.GetLength(1); k++)
            {
                if (max < arr[i, k])
                {
                    max = arr[i, k];
                    arr[i, k] = arr[i, j];
                    arr[i, j] = max;
                }
            }
        }
    }
}

//КОД ОСНОВНОЙ ПРОГРАММЫ
int[,] array = new int[3, 4];
FillArray(array);
PrintArray(array);

ArrangeArrayElements(array);
PrintArray(array);