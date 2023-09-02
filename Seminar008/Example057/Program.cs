// Задача 57: Составить частотный словарь элементов двумерного массива. Частотный словарь содержит
// информацию о том, сколько раз встречается элемент входных данных.

// Набор данных                    Частотный массив
// { 1, 9, 9, 0, 2, 8, 0, 9 }      1, 2, 3
// 0 встречается 2 раза            4, 6, 1
// 1 встречается 1 раз             2, 1, 6
// 2 встречается 1 раз             1 встречается 3 раза
// 8 встречается 1 раз             2 встречается 2 раз
// 9 встречается 3 раза            3 встречается 1 раз
//                                 4 встречается 1 раз
//                                 6 встречается 2 раза

// -------------------------- Начало программы ----------------------------------
#region --- 00. Configuration ---
Console.Clear ();

Console.Title = "Задача 57: Создание массива и составление частотного словаря элементов";

Console.OutputEncoding = System.Text.Encoding.UTF8;
var curConsoleColor = Console.ForegroundColor;
Console.ForegroundColor = ConsoleColor.DarkGreen;
Console.WriteLine(@"**************************************************************************************
                    Задайте двумерный массив из целых чисел. 
             Составить частотный словарь элементов двумерного массива. 
                Частотный словарь содержит информацию о том,
                сколько раз встречается элемент входных данных.
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
int[,] array = GetArray(rows, columns, 0, 99);

#endregion --- 02. Business logic ---

#region --- 03. Output operations ---

Console.WriteLine ($"\nПолучившийся массив:");
// Вызов метода, выводящего массив в консоль
PrintArray (array);

AFrequencyDictionaryOfElements (array, rows, columns);

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

// Метод составления частотного словаря элементов
void AFrequencyDictionaryOfElements (int[,] inArray, int m, int n)
{
    int[] count = new int[100];
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
         count[inArray[i, j]]++;
        }
    }
    for (int l = 0; l < 100; l++)
    {
        if (count[l] != 0)
        {
        Console.WriteLine($"Число {l} встречается {count[l]} раз");
        }
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