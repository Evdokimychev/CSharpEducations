// Задача 59: Задайте двумерный массив из целых чисел.
// Напишите программу, которая удалит строку и столбец, на пересечении которых расположен наименьший элемент массива.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Наименьший элемент - 1, на выходе получим следующий массив:
// 9 2 3
// 4 2 4
// 2 6 7

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
int[,] newArray = CleanArray (array, rows, columns);

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

// Метод поиска наименьшего элемента в двумерном массиве
int FindMinEl (int[,] inArray)
{
    int min = inArray[0,0];
    int max = inArray[0,0];
    int indexMinEl1 = 0;
    int indexMinEl2 = 0;
    int indexMaxEl1 = 0;
    int indexMaxEl2 = 0; 
    for (int i = 0; i < inArray.GetLength(1); i++)
    {
        for (int j = 0; j < inArray.GetLength(0); j++)
        {
            if (max < inArray[i, j]) 
            {
                max = inArray[i, j];
                indexMaxEl1 = i;
                indexMaxEl2 = j;
            }
            else if (min > inArray[i, j]) 
            {
                min = inArray[i, j];
                indexMinEl1 = i;
                indexMinEl2 = j;
                i++;
            }
        }
    }
    return indexMinEl1;
    return indexMinEl2;
}


// Метод удаления строки и столбца в двумерном массиве
int[,] CleanArray (int[,] inArray, int m, int n)
{
    int indexMinEl1 = FindMinEl (inArray);
    int indexMinEl2 = FindMinEl (inArray);
    int[,] result = new int[n-1, m-1];
    for (int i = 0; i < inArray.GetLength(0) & i != indexMinEl1; i++)
    {
        for (int j = 0; j < inArray.GetLength(1) & j != indexMinEl2; j++)
        {
            // if (indexMinEl1 == inArray [i ,j]) result [i, j] = inArray [i ,j+1];
            result [i, j] = inArray [i ,j];
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