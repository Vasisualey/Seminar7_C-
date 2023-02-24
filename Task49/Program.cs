// Задача 49. Задайте двумерный массив. Найдите элементы, у которых
// оба индекса четные и замените эти элементы на их квадраты.

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
            if((i%2 == 0) && (j%2 == 0))
            {
                result[i,j] = result[i,j]*result[i,j];
            }
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