// Задача 40: Напишите программу, которая принимает на вход три числа и проверяет, может ли существовать треугольник с сторонами такой длины.*
// * Теорема о неравенстве треугольника: каждая сторона треугольника меньше суммы двух других сторон.

// Пример:
// Треугольник со сторонами A (2), B (5), C (6) -> не может существовать

// -------------------------- Начало программы ----------------------------------
#region --- 00. Configuration ---
Console.Clear ();

Console.Title = "Задача 40. Проверка возможности создания треугольника со сторонами введёнными пользователем";

Console.OutputEncoding = System.Text.Encoding.UTF8;
var curConsoleColor = Console.ForegroundColor;
Console.ForegroundColor = ConsoleColor.DarkGreen;
Console.WriteLine(@"**************************************************************************************
            Напишите программу, которая принимает на вход три числа и проверяет, 
                может ли существовать треугольник с сторонами такой длины.
**************************************************************************************");
Console.ForegroundColor = curConsoleColor;
#endregion

#region --- 01. Input operations ---
// Вызов метода, запрашивающего данные у пользователя
int sideOfTheTriangle1 = GetNumberFromUser ("Введите размер первой стороны треугольника: ", "Ошибка ввода данных!");
int sideOfTheTriangle2 = GetNumberFromUser ("Введите размер второй стороны треугольника: ", "Ошибка ввода данных!");
int sideOfTheTriangle3 = GetNumberFromUser ("Введите размер третьей стороны треугольника: ", "Ошибка ввода данных!");
#endregion --- 01. Input operations ---

#region --- 02. Business logic ---
// Вызов метода проверки возможности существования треугольника
string result = FindTheTriangle (sideOfTheTriangle1, sideOfTheTriangle2, sideOfTheTriangle3);
#endregion --- 02. Business logic ---

#region --- 03. Output operations ---
// Выводим результат в консоль согласно примеру
Console.WriteLine($"\nТреугольник со сторонами AB ({sideOfTheTriangle1}), BC ({sideOfTheTriangle2}), CA ({sideOfTheTriangle3}) -> {result}");
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

// Метод проверки возможности существования треугольника
string FindTheTriangle (int sideOfTheTriangle1, int sideOfTheTriangle2, int sideOfTheTriangle3)
{
    string result;
    if (sideOfTheTriangle1 + sideOfTheTriangle2 < sideOfTheTriangle3) result = "не может существовать";
    else if (sideOfTheTriangle1 + sideOfTheTriangle3 < sideOfTheTriangle2) result = "не может существовать";
    else if (sideOfTheTriangle2 + sideOfTheTriangle3 < sideOfTheTriangle1) result = "не может существовать";
        else result = "может существовать";
        return result;
}


// ---------------------- Конец определения методов ----------------------------