// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

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

int[,] MatricesProduct(int[,] a, int[,] b)
{
    int[,] c = new int[b.GetLength(0), b.GetLength(1)];
    for (int i = 0; i < b.GetLength(0); i++)
    {
        for (int j = 0; j < b.GetLength(1); j++)
        {
            for (int n = 0; n < a.GetLength(1); n++)
            {
                c[i, j] = c[i, j] + a[i, n] * b[n, j];
            }
        }
    }
    return c;
}

//КОД ОСНОВНОЙ ПРОГРАММЫ
int[,] array1 = new int[,]
{
    {2,4},
    {3,2},
};
int[,] array2 = new int[,]
{
    {3,4},
    {3,3},
};
PrintArray(MatricesProduct(array1, array2));