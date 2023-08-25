﻿// Задача 52: Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов в каждом столбце.

// Пример:
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4

// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

// -------------------------- Начало программы ----------------------------------
#region --- 00. Configuration ---
Console.Clear ();

Console.Title = "Задача 52: Создание двумерного массива размером m х n и нахождение среднего арифметического элементов в каждом столбце";

Console.OutputEncoding = System.Text.Encoding.UTF8;
var curConsoleColor = Console.ForegroundColor;
Console.ForegroundColor = ConsoleColor.DarkGreen;
Console.WriteLine(@"**************************************************************************************
                    Задайте двумерный массив из целых чисел. 
            Найдите среднее арифметическое элементов в каждом столбце.
**************************************************************************************");
Console.ForegroundColor = curConsoleColor;
#endregion

#region --- 01. Input operations ---

// Вызов метода, запрашивающего данные у пользователя
int rows = GetNumberFromUser ("Введите количество строк массива: ", "Ошибка ввода данных!");
int columns = GetNumberFromUser ("Введите количество столбцов массива: ", "Ошибка ввода данных!");

#endregion --- 01. Input operations ---

#region --- 02. Business logic ---

// Вызов метода, создающего массив по данным параметрам
int[,] array = GetArray(rows, columns, 0, 9);

#endregion --- 02. Business logic ---

#region --- 03. Output operations ---

Console.WriteLine ($"Получившийся массив:");
// Вызов метода, выводящего массив в консоль
PrintArray (array);

// Вызов метода, пересобирающего массив по данным параметрам
ArithmeticMeanOfTheColumn (array, rows, columns);

// Console.WriteLine ($"Сумма элементов главной диагонали: = {sum}");

#endregion --- 03. Output operations ---
// -------------------------- Конец программы ----------------------------------


// -------------------------Определение методов ---------------------------------

// Метод запроса данных у пользователя
static int GetNumberFromUser (string welcomeMessage, string errorMessage)
{   
    while(true)
    {
        try
        {
            Console.Write(welcomeMessage);
            return int.Parse(Console.ReadLine() ?? "");            
        }
        catch (Exception exc)
        {
            Console.WriteLine($"{errorMessage} {exc.Message}");        
        }
    }
}

// Метод, возвращающий двумерный массив 
int[,] GetArray (int m, int n, int minValue, int maxValue)
{
    int[,] result = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return result;
}

// Метод, поиска элементов в двумерном массиве и их суммирование
void ArithmeticMeanOfTheColumn (int[,] inArray, int m, int n)
{
    for (int j = 0; j < inArray.GetLength(0); j++)
    {
        int count = 0;
        for (int i = 0; i < inArray.GetLength(1); i++)
        {
            count = count + inArray [i, j];
        }
        double ArithmeticMean = 1.0 * count / m;
        Console.WriteLine($"Среднее арифметическое столбца {j+1} = {ArithmeticMean}");
    }
}

// Метод вывода массива
void PrintArray(int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Console.Write($"{inArray[i, j]} ");
        }
        Console.WriteLine();
    }
}
// ---------------------- Конец определения методов ----------------------------