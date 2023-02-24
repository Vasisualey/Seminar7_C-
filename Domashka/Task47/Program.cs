//Задача 47. Задайте двумерный массив размером m×n, заполненный
//  случайными вещественными числами.

// m = 3, n = 4.

Console.Clear();
int m = Input ("Введите количество строк: ");
int n = Input ("Введите количество столбцов: ");
int min = Input ("Введите минимальное значение массива: ");
int max = Input ("Введите максимальное значение массива: ");

double [,] array = ArrayDouble (m, n, min, max);
PrintArray(array);

int Input (string message)
{
    Console.Write (message);
    return Convert.ToInt32 (Console.ReadLine ());
}

double [,] ArrayDouble (int line, int column, int min, int max)
{
    double [,] numArr2D = new double [line, column];
    for (int i = 0; i < line; i++)
    {
        for (int j = 0; j < column; j++)
        {
            numArr2D [i, j] = new Random ().Next(min, max) + new Random ().NextDouble (); // Эта штука для заполнения случайными дробными числами, запомнить!
            numArr2D [i, j] = Math.Round (numArr2D [i, j], 2);// это округление до 2 знаков после запятой, запомнить!
    }
    }
    return numArr2D;
}


void PrintArray(double [,] array2D)
{
    for (int i = 0; i < array2D.GetLength (0); i++)
    {
        for (int j = 0; j < array2D.GetLength (1); j++)
        {
            Console.Write (array2D [i, j] + " ");
        }
        Console.WriteLine ();
    }
}

