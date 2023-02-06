
//Задача 50.Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
//и возвращает значение этого элемента или же указание, что такого элемента нет.

Console.Clear();

int[,] array = { {-8,-14,-19,-18},
                 { 2, 99, 26, 23},
                 { 11,145, 20, 5} };
void PrintArray(int[,] args)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write("{0,6}\t", array[i, j]);
        }
        Console.WriteLine();
    }
}
PrintArray(array);
Console.WriteLine();
//при некорректном вводе выходит ошибка
//как это исправить  пока не знаю.
Console.Write($"введите ЧЕРЕЗ ПРОБЕЛ номер строки и номер столбца  искомого элемента :\t");
string[] s = Console.ReadLine()!.Split(" ");
// второй вариант ввода данных юзером.

//Console.WriteLine("введите номер строки искомого элемента");
//int rows = int.Parse(Console.ReadLine()!);
//Console.WriteLine("введите номер столбца искомого элемента");
//int column = int.Parse(Console.ReadLine()!);

int rows = int.Parse(s[0]);
int column = int.Parse(s[1]);
rows--;
column--;
void SearchNumber(int[,] array)
{
    if (rows < array.GetLength(0) && column < array.GetLength(1))
    {
        Console.WriteLine($"значение искомого элемента = {(array[rows, column])}");
    }
    else Console.WriteLine("искомый элемент отсутствует в массиве");
}
SearchNumber(array);
