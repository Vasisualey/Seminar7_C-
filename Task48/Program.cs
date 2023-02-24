// Задача 48. Задайте двумерный массив размера m на n,
// Каждый элемент в массиве находится по формуле Amn =m+n


int m = 3;
int n = 4;

Print2darray(Generatearray(m, n));


void Print2darray(int[,] somearray)
{
    for(int i = 0; i < somearray.GetLength(0); i++)
    {
        for(int j =0; j<somearray.GetLength(1); j++)
        {
            Console.Write(somearray[i,j]+" ");
        }
        Console.WriteLine();
    }
}

int[,] Generatearray(int m, int n)
{
    int[,] res = new int[m,n];
    for(int i = 0; i<m; i++)
    {
        for(int j =0; j < n; j++)
        {
            res[i,j] = i+j;
        }
    }
    return res;
}