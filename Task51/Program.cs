// Задача 51. Задайте двумерный массив. Найдите сумму элементов,
// находящихся на главной диагонали(с индексами 0.0, 1.1 и тд)

Console.Write("Введите количество строк массива: ");
int rows = int.Parse(Console.ReadLine()!);
Console.Write("Введите количество столбцов массива: ");
int columns = int.Parse(Console.ReadLine()!);

int[,] array = GetArray(rows, columns, 0,10);
Printarray(array);
// Console.WriteLine(Getsum(array));

int[,] GetArray(int m, int n, int minValue, int maxValue)
{
    int[,] result = new int [m, n];
    for(int i = 0; i<m; i++)
    {
        for (int j=0; j<n; j++)
        {
            result[i,j] = new Random().Next(minValue,maxValue);
        }

    }
    return result;
}
void Printarray(int[,] inarray)
{
    int sum = 0;
    for (int i = 0; i < inarray.GetLength(0); i++)
    {
        for (int j=0; j<inarray.GetLength(1); j++)
        {
            Console.Write($"{inarray[i,j]}  ");
            if(i == j)
            {
               sum += inarray[i,j];;
            }
        }
        Console.WriteLine();
    }
    Console.WriteLine(sum);
}

// int Getsum(int[,] inarray)
// {
//     int sum = 0;
//     for (int i = 0; i < inarray.GetLength(0); i++)
//     {
//         for (int j=0; j<inarray.GetLength(1); j++)
//         {
//             if(i == j)
//             {
//                sum += inarray[i,j];;
//             }
//         }
//     }
// return sum;
// }