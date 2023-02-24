// Задача 52. Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов в каждом столбце.

Console.Clear();

int m = Input ("Введите количество строк: ");
int n = Input ("Введите количество столбцов: ");
int min = Input ("Введите минимальное значение массива: ");
int max = Input ("Введите максимальное значение массива: ");
int [,] array = SetArray(m, n);
PrintArray(array);
PrintAverage(array);



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
void PrintArray (int [,] array2D)
{
    for (int i = 0; i < array2D.GetLength (0); i++)
    {
        for (int j = 0; j < array2D.GetLength (1); j++)
        {
            Console.Write (array2D [i, j] + " ");
        }
        Console.WriteLine ();
    }
    Console.WriteLine ();
}

void PrintAverage (int [,] array2D)
{
    double sum = 0;
    double result = 0;
    for (int j = 0; j < array2D.GetLength(1); j++)
    {
        for (int i = 0; i < array2D.GetLength(0); i++)
        {
            sum += array2D[i, j];
        }
        result = sum / array2D.GetLength(1);
        result = Math.Round(result, 2);
        Console.Write(result + " ");
        result = 0;
        sum = 0;
    }
}







