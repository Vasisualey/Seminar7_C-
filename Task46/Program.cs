// Задача 46: Задайте двумерный массив размером m:n, 
// заполненный случайными целыми числами.
Console.Write("Введите количество строк массива: ");
int rows = int.Parse(Console.ReadLine()!);
Console.Write("Введите количество столбцов массива: ");
int columns = int.Parse(Console.ReadLine()!);

int[,] array = GetArray(rows, columns, 0,10);
Printarray(array);

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
    for (int i = 0; i < inarray.GetLength(0); i++)
    {
        for (int j=0; j<inarray.GetLength(1); j++)
        {
            Console.Write($"{inarray[i,j]}  ");
        }
        Console.WriteLine();
    }
}