// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

// // -------------------------- Начало программы ----------------------------------
// #region --- 00. Configuration ---
// Console.Clear ();

// Console.Title = "Задача 54: Создание двумерного массива размером и упорядочивание по убыванию элементов каждой строки";

// Console.OutputEncoding = System.Text.Encoding.UTF8;
// var curConsoleColor = Console.ForegroundColor;
// Console.ForegroundColor = ConsoleColor.DarkGreen;
// Console.WriteLine(@"**************************************************************************************
//                     Задайте двумерный массив из целых чисел. 
// Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// **************************************************************************************");
// Console.ForegroundColor = curConsoleColor;
// #endregion

// #region --- 01. Input operations ---

// // Вызов метода, запрашивающего данные у пользователя
// int rows = GetNumberFromUser ("Введите количество строк массива: ", "Ошибка ввода данных!");
// int columns = GetNumberFromUser ("Введите количество столбцов массива: ", "Ошибка ввода данных!");

// #endregion --- 01. Input operations ---

// #region --- 02. Business logic ---

// // Вызов метода, создающего массив по данным параметрам
// int[,] array = GetArray(rows, columns, 0, 9);

// // Вызов метода, пересобирающего массив по данным параметрам
// int[,] newArray = ExchangeTheRows (array, rows, columns);

// #endregion --- 02. Business logic ---

// #region --- 03. Output operations ---

// Console.WriteLine ($"\nПолучившийся массив:");
// // Вызов метода, выводящего массив в консоль
// PrintArray (array);

// Console.WriteLine ($"\nПолучившийся новый массив:");
// // Вызов метода, выводящего массив в консоль
// PrintArray (newArray);

// #endregion --- 03. Output operations ---
// // -------------------------- Конец программы ----------------------------------


// // -------------------------Определение методов ---------------------------------

// // Метод запроса данных у пользователя
// static int GetNumberFromUser (string welcomeMessage, string errorMessage)
// {   
//     while(true)
//     {
//         try
//         {
//             Console.Write(welcomeMessage);
//             return int.Parse(Console.ReadLine() ?? "");            
//         }
//         catch (Exception exc)
//         {
//             Console.WriteLine($"{errorMessage} {exc.Message}");        
//         }
//     }
// }

// // Метод, возвращающий двумерный массив 
// int[,] GetArray (int m, int n, int minValue, int maxValue)
// {
//     int[,] result = new int[m, n];
//     for (int i = 0; i < m; i++)
//     {
//         for (int j = 0; j < n; j++)
//         {
//             result[i, j] = new Random().Next(minValue, maxValue + 1);
//         }
//     }
//     return result;
// }

// // Метод упорядочивания элементов в двумерном массиве
// int[,] ExchangeTheRows (int[,] inArray, int m, int n)
// {
//     int[,] result = new int[m, n];
//     for (int i = 0; i < inArray.GetLength(0); i++)
//     {
//         for (int j = 0; j < inArray.GetLength(1); j++)
//         {
//             if (i == 0) result [i, j] = inArray [m - 1, j];
//             else if (i == m - 1) result [i, j] = inArray [0, j];
//             else result [i, j] = inArray [i, j];
//         }
//     }
//     return result;
// }

// // Метод вывода массива
// void PrintArray(int[,] inArray)
// {
//     for (int i = 0; i < inArray.GetLength(0); i++)
//     {
//         for (int j = 0; j < inArray.GetLength(1); j++)
//         {
//             Console.Write($"{inArray[i, j]} ");
//         }
//         Console.WriteLine();
//     }
// }
// // ---------------------- Конец определения методов ----------------------------
(int, int) GetArraySize()
{
    int rowSize = 0;
    int colSize = 0;
    string enteredSymbol = string.Empty;
    do
    {
        Console.Clear();
        Console.Write("Создать случайный 2D массив? Нажмите y или n: ");
        enteredSymbol = Console.ReadLine();
        if (enteredSymbol == "y")
        {
            rowSize = new Random().Next(2, 11);
            colSize = new Random().Next(2, 11);
            Console.WriteLine("Значение m: {0}", rowSize);
            Console.WriteLine("Значение n: {0}", colSize);
            Console.WriteLine();
            break;
        }
        else if (enteredSymbol == "n")
        {
            Console.Write("Введите значение m:");
            rowSize = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите значение n:");
            colSize = Convert.ToInt32(Console.ReadLine());
            break;
        }
    } while (true);

    return (rowSize, colSize);
}
void Fill2DArray(int[,] ArrayToFill, int deviation = 10)
{
    for (int i = 0; i < ArrayToFill.GetLength(0); i++)
    {
        for (int j = 0; j < ArrayToFill.GetLength(1); j++)
        {
            ArrayToFill[i, j] = new Random().Next(-deviation, deviation + 1);
        }
    }
}
void Print2DArray(int[,] ArrayToPrint, int coloredElement = 0)
{
    int rowColoredElement = (coloredElement - 1) / ArrayToPrint.GetLength(1);
    int colColoredElement = coloredElement - 1 - rowColoredElement * ArrayToPrint.GetLength(1);
    Console.Write("[X]\t");
    for (int i = 0; i < ArrayToPrint.GetLength(1); i++)
    {
        Console.Write($"[{i}]\t", i);
    }
    Console.WriteLine();
    for (int i = 0; i < ArrayToPrint.GetLength(0); i++)
    {
        Console.Write($"[{i}]\t", i);
        for (int j = 0; j < ArrayToPrint.GetLength(1); j++)
        {
            if (i == rowColoredElement
                && j == colColoredElement)
            {
                Console.BackgroundColor = ConsoleColor.Green;
            }
            if (ArrayToPrint[i, j] < 0)
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
            }
            Console.Write(ArrayToPrint[i, j] + "\t");
            Console.ResetColor();
        }
        Console.WriteLine();
    }
}
void DescendingArrayRowSort(int[,] arrayToSort)
{
    int temp = 0;
    for (int i = 0; i < arrayToSort.GetLength(0); i++)
    {
        for (int j = 0; j < arrayToSort.GetLength(1); j++)
        {
            for (int k = j + 1; k < arrayToSort.GetLength(1); k++)
            {
                if (arrayToSort[i, j] < arrayToSort[i, k])
                {
                    temp = arrayToSort[i, j];
                    arrayToSort[i, j] = arrayToSort[i, k];
                    arrayToSort[i, k] = temp;
                }
            }
        }
    }
}


int rowSize = 0, colSize = 0;
(rowSize, colSize) = GetArraySize();
int[,] arrayToOperate = new int[rowSize, colSize];
Fill2DArray(arrayToOperate, deviation: 90);
Console.WriteLine("Неотсортированный массив:");
Print2DArray(arrayToOperate);
DescendingArrayRowSort(arrayToOperate);
Console.WriteLine();
Console.WriteLine("Отсортированный массив:");
Print2DArray(arrayToOperate);