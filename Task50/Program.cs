// Задача 50. Напишите программу, которая на вход принимает позиции 
// элемента в двумерном массиве, и возвращает значение этого элемента 
// или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

int[,] CreateRandomArray()
{
    Console.Write("Введите количество строк: ");
    int n = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите количество столбцов: ");
    int m = Convert.ToInt32(Console.ReadLine());

    int[,] array = new int[n, m];
    for (int i = 0; i < n; i++)
        for (int j = 0; j < m; j++)
            array[i, j] = new Random().Next(-100, 100);
    return array;
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i, j] + " ");

        Console.WriteLine();
    }
}

void FindElement(int[,] array)
{
    Console.Write("Введите индекс 'i' элемента: ");
    int i = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите индекс 'j' элемента: ");
    int j = Convert.ToInt32(Console.ReadLine());
    if ((i >= 0 && i < array.GetLength(0)) && (j >= 0 && j < array.GetLength(1)))
        Console.WriteLine($"Элемент с индексами [{i},{j}] = {array[i, j]}");
    else
        Console.WriteLine("Нет элемента с такими индексами.");
}

int[,] myArray = CreateRandomArray();
PrintArray(myArray);
FindElement(myArray);  