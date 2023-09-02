// Задача 55: Задайте двумерный массив. Напишите программу, которая заменяет строки на столбцы. 
// В случае, если это невозможно, программа должна вывести сообщение для пользователя.

// -------------------------- Начало программы ----------------------------------
#region --- 00. Configuration ---
Console.Clear ();

Console.Title = "Задача 55: Создание двумерного массива и транспонирование массива";

Console.OutputEncoding = System.Text.Encoding.UTF8;
var curConsoleColor = Console.ForegroundColor;
Console.ForegroundColor = ConsoleColor.DarkGreen;
Console.WriteLine(@"**************************************************************************************
                    Задайте двумерный массив из целых чисел. 
             Напишите программу, которая заменяет строки на столбцы. 
В случае, если это невозможно, программа должна вывести сообщение для пользователя.
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

// Вызов метода, переворачивающего массив (транспонирование)
int[,] newArray = TranspositionArray2 (array, rows, columns);

#endregion --- 02. Business logic ---

#region --- 03. Output operations ---

Console.WriteLine ($"\nПолучившийся массив:");
// Вызов метода, выводящего массив в консоль
PrintArray (array);

Console.WriteLine ($"\nПолучившийся новый массив:");
// Вызов метода, выводящего массив в консоль
PrintArray (newArray);

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

// Метод транспонирования в двумерном массиве (для квадратных массивов)
int[,] TranspositionArray (int[,] inArray, int m, int n)
{
    int[,] result = new int[m, n];
    for (int i = 0; i < inArray.GetLength(1); i++)
    {
        for (int j = 0; j < inArray.GetLength(0); j++)
        {
            result [i, j] = inArray [j ,i];
        }
    }
    return result;
}

// Метод транспонирования в двумерном массиве (универсальный)
int[,] TranspositionArray2 (int[,] inArray, int m, int n)
{
    int[,] result = new int[n, m];
    for (int i = 0; i < inArray.GetLength(1); i++)
    {
        for (int j = 0; j < inArray.GetLength(0); j++)
        {
            result [i, j] = inArray [j ,i];
        }
    }
    return result;
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