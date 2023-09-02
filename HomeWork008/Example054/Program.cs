// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

// -------------------------- Начало программы ----------------------------------
#region --- 00. Configuration ---
Console.Clear ();

Console.Title = "Задача 54: Создание двумерного массива размером и упорядочивание по убыванию элементов каждой строки";

Console.OutputEncoding = System.Text.Encoding.UTF8;
var curConsoleColor = Console.ForegroundColor;
Console.ForegroundColor = ConsoleColor.DarkGreen;
Console.WriteLine(@"**************************************************************************************
                    Задайте двумерный массив из целых чисел. 
Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
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

// Вызов метода, пересобирающего массив по данным параметрам

#endregion --- 02. Business logic ---

#region --- 03. Output operations ---

Console.WriteLine ($"\nПолучившийся массив:");
// Вызов метода, выводящего массив в консоль
PrintArray (array);

Console.WriteLine ($"\nПолучившийся новый массив:");
// Вызов метода, выводящего новый массив в консоль
DescendingArrayRowSort (array);
PrintArray (array);

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

// Метод, сортирующий строки двумерного массива
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