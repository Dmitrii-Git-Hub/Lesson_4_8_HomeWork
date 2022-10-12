// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

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

void FindSmallestSumRowArray(int[,] arr)
{
    int row = 1;
    int minSum = 0;
    for (int i = 0; i < arr.GetLength(1); i++)
    {
        minSum = minSum + arr[0, i];
    }
    for (int j = 1; j < arr.GetLength(0); j++)
    {
        int sum = 0;
        for (int k = 0; k < arr.GetLength(1); k++)
        {
            sum = sum + arr[j, k];
        }
        if (sum < minSum)
        {
            row = j + 1;
            minSum = sum;
        }
        sum = 0;
    }

    Console.WriteLine($"Номер строки с наименьшей суммой элементов: {row} строка");
}

//КОД ОСНОВНОЙ ПРОГРАММЫ
int[,] array = new int[4, 4];
FillArray(array);
PrintArray(array);
FindSmallestSumRowArray(array);