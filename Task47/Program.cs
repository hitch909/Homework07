//Задача 47.Задайте двумерный массив размером m×n, 
//заполненный случайными вещественными числами.

Console.Clear();
double[,] array = new double[5, 10];
void FillArray(double[,] args)
{
    for (int i = 0; i < 5; i++)
    {
        for (int j = 0; j < 10; j++)
        {
            array[i, j] = new Random().NextDouble() * 100;
            Console.Write("{0,6:F2}\t", array[i, j]);
        }
        Console.WriteLine();
    }
}
FillArray(array);
