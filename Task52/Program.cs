//Задача 52.Задайте двумерный массив из целых чисел. 
//Найдите среднее арифметическое элементов в каждом столбце.
Console.Clear();
int[,] GetArray(int m, int n)
{
    int[,] matrix = new int[m, n];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(1, 10);
        }
    }
    return matrix;
}

void PrintArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write("{0,6}\t", matr[i, j]);
        }
        Console.WriteLine();
    }
}

void PillarsArray(int[,] args)
{
    int rows = args.GetLength(0);
    for (int j = 0; j < args.GetLength(1); j++)   //cols 6
    {
        double colsAvg = 0;
        for (int i = 0; i < args.GetLength(0); i++) //rows 4
        {
            colsAvg += args[i, j];
        }
        colsAvg /= rows;
        Console.WriteLine("среднее арифметическое значение в столбце {0} = {1}", j + 1, colsAvg);
    }
}

int[,] matrix = GetArray(4, 6);
PrintArray(matrix);
Console.WriteLine();
PillarsArray(matrix);
