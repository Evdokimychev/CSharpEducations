// Задача 47: Задайте двумерный массив размером m х n, заполненный случайными вещественными числами.

// Пример:
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

// -------------------------- Начало программы ----------------------------------
#region --- 00. Configuration ---
Console.Clear ();

Console.Title = "Задача 47: Создание двумерного массива размером m х n, заполненного случайными вещественными числами.";

Console.OutputEncoding = System.Text.Encoding.UTF8;
var curConsoleColor = Console.ForegroundColor;
Console.ForegroundColor = ConsoleColor.DarkGreen;
Console.WriteLine(@"**************************************************************************************
    Задайте двумерный массив размером m х n, заполненный случайными вещественными числами.
**************************************************************************************");
Console.ForegroundColor = curConsoleColor;
#endregion

#region --- 01. Input operations ---

// Вызов метода, запрашивающего данные у пользователя
int rows = GetNumberFromUser ("Введите количество строк массива: ", "Ошибка ввода данных!");
int columns = GetNumberFromUser ("Введите количество столбцов массива: ", "Ошибка ввода данных!");

// double minValue = 0;
// double maxValue = 1;

#endregion --- 01. Input operations ---

#region --- 02. Business logic ---

// Вызов метода, создающего массив по данным параметрам
double [,] array = GetArray(rows, columns); //, minValue, maxValue);

#endregion --- 02. Business logic ---

#region --- 03. Output operations ---

Console.WriteLine ($"Получившийся массив: ");
// Вызов метода, выводящего массив в консоль
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

// Метод, возвращающий двумерный массив с вещественными числами
double [,] GetArray (int m, int n) //, double minValue, double maxValue)
{
    double [,] result = new double [m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().NextDouble () * 100; //minValue, maxValue + 1) * 100;
        }
    }
    return result;
}

// Метод вывода двумерного массива с вещественными числами
void PrintArray(double [,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Console.Write("{0,6:F2}", inArray[i, j]);
        }
        Console.WriteLine();
    }
}
// ---------------------- Конец определения методов ----------------------------