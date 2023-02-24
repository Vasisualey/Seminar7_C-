// Задача 50. Напишите программу, которая на вход принимает позиции 
// элемента в двумерном массиве, и возвращает значение этого элемента 
// или же указание, что такого элемента нет.

Console.Clear();

int m = Input ("Введите количество строк: ");
int n = Input ("Введите количество столбцов: ");
int min = Input ("Введите минимальное значение массива: ");
int max = Input ("Введите максимальное значение массива: ");
int x = Input ("Введите номер строки искомого элемента: ");
int y = Input ("Введите номер столбца искомого элемента: ");
int [,] array = SetArray(m, n);
Printarray(array, x,y);


int Input(string message)
{
    Console.Write (message);
    return Convert.ToInt32 (Console.ReadLine ());
}

int [,] SetArray(int line, int column)
{
    int [,] numArr2D = new int [line, column];
    for (int i = 0; i < line; i++)
    {
        for (int j = 0; j < column; j++)
        {
            numArr2D [i, j] = new Random ().Next (min, max); 
        }
    }
    return numArr2D;
}
void Printarray(int[,] inarray, int x, int y)
{
    int element = 0;
    int k = 0;
    for (int i = 0; i < inarray.GetLength(0); i++)
    {
        for (int j=0; j<inarray.GetLength(1); j++)
        {
            Console.Write($"{inarray[i,j]}  ");
            if(i == x-1 && j == y-1)
            {
               element = inarray[i,j];
               k++;
            }
        }
        Console.WriteLine();
    }
    if(k > 0)
    {
        Console.WriteLine($"Значение искомого элемента = {element}.");
    }
    else
    {
        Console.WriteLine("Элемента с заданными координатами не существует.");
    }
}
// Исходник метода
// void PrintArray2DInt (int [,] array2D)
// {
//     for (int i = 0; i < array2D.GetLength (0); i++)
//     {
//         for (int j = 0; j < array2D.GetLength (1); j++)
//         {
//             Console.Write (array2D [i, j] + " ");
//         }
//         Console.WriteLine ();
//     }
// }



