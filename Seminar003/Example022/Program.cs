// Задача 22: Напишите программу, которая принимает на вход число (N) 
// и выдаёт таблицу квадратов чисел от 1 до N.

// Пример:
// 5 -> 1, 4, 9, 16, 25.
// 2 -> 1, 4

// -------------------------- Начало программы ----------------------------------
#region --- 00. Configuration ---
Console.Clear ();
Console.Title = "Задача 22. Вывод таблицы квадратов до числа N";

Console.OutputEncoding = System.Text.Encoding.UTF8;
var curConsoleColor = Console.ForegroundColor;
Console.ForegroundColor = ConsoleColor.DarkGreen;
Console.WriteLine(@"************************************************************************
    Напишите программу, которая принимает на вход число (N) 
        и выдаёт таблицу квадратов чисел от 1 до N.
************************************************************************");
Console.ForegroundColor = curConsoleColor;
#endregion

#region --- 01. Input operations ---
// Вызов метода, запрашивающего у пользователя целое число. Введённое число присваивается переменной N
int numberN = GetNumberFromUser("Введите число N: ", "Ошибка ввода данных!");
#endregion --- 01. Input operations ---

#region --- 02. Business logic ---
int result;
try
{
    // Вызов метода, возвращающего номер четверти по переданным координатам x и y.
    // Результат вызова присваивается переменной distance.
    result = GetTableOfSquares (numberN);
}
catch(Exception exc)
{
    Console.WriteLine($"ОШИБКА! {exc.Message}");
    return; // Завершение программы в случае ошибки
}
#endregion --- 02. Business logic ---

#region --- 03. Output operations ---
Console.WriteLine($"-> N = {numberN}");
#endregion --- 03. Output operations ---
// -------------------------- Конец программы ----------------------------------


// -------------------------Определение методов ---------------------------------
// Определяем функцию, выполняющую ввод целого числа с консоли
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

// Определяем функцию поиска расстояния между точками А и В
static int GetTableOfSquares (int numberN)
{
    if (numberN <= 0)
    {
        Console.WriteLine("Введено неверное число");
        return numberN;
    }
    int result = 1;
    while (result <= numberN)
    {
        Console.Write($"{result * result} ");
        result++; // result = result + 1
    }

    return result;
}
// ---------------------- Конец определения методов ----------------------------