// Задача 52. Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

int[,] CreateRandomArray()
{
    Console.Write("Введите количество строк: ");
    int n = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите количество столбцов: ");
    int m = Convert.ToInt32(Console.ReadLine());

    int[,] array = new int[n, m];
    for (int i = 0; i < n; i++)
        for (int j = 0; j < m; j++)
            array[i, j] = new Random().Next(0, 100);
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
double[] FindAverage(int[,] array)
{

    double[] newarray = new double[array.GetLength(1)];
    for (int j = 0; j < array.GetLength(1); j++)
    {
        double sum = 0;
        for (int i = 0; i < array.GetLength(0); i++)
            sum = sum + array[i, j];
        newarray[j] = Math.Round((sum / array.GetLength(0)),1);
    }  
    return newarray;
}

void Print2Array(double[] array)
{
    Console.Write("Среднее значение столбцов: ");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + "; "); 
    }
}

int[,] Array = CreateRandomArray();
PrintArray(Array);
double[] newarray = FindAverage(Array);
Print2Array(newarray);