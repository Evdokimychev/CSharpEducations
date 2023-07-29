// Задача 21: Напишите программу, которая принимает на вход координаты двух точек 
// и находит расстояние между ними в 2D пространстве.

// Пример:
// A (3,6); B (2,1) -> 5,09
// A (7,-5); B (1,-1) -> 7,21

// -------------------------- Начало программы ----------------------------------
#region --- 00. Configuration ---
Console.Clear ();
Console.Title = "Задача 21. Нахождение расстояния между двумя заданными точками";

Console.OutputEncoding = System.Text.Encoding.UTF8;
var curConsoleColor = Console.ForegroundColor;
Console.ForegroundColor = ConsoleColor.DarkGreen;
Console.WriteLine(@"************************************************************************
    Напишите программу, которая принимает на вход координаты двух точек 
            и находит расстояние между ними в 2D пространстве.
************************************************************************");
Console.ForegroundColor = curConsoleColor;
#endregion

#region --- 01. Input operations ---
// Вызов метода, запрашивающего у пользователя целое число. Введённое число присваивается переменной x точки А
int xA = GetNumberFromUser("Введите координату x точки A: ", "Ошибка ввода данных!");
// Вызов метода, запрашивающего у пользователя целое число. Введённое число присваивается переменной y точки А
int yA = GetNumberFromUser("Введите координату y точки A: ", "Ошибка ввода данных!");
// Вызов метода, запрашивающего у пользователя целое число. Введённое число присваивается переменной x точки В
int xB = GetNumberFromUser("Введите координату y точки B: ", "Ошибка ввода данных!");
// Вызов метода, запрашивающего у пользователя целое число. Введённое число присваивается переменной y точки B
int yB = GetNumberFromUser("Введите координату y точки B: ", "Ошибка ввода данных!");
#endregion --- 01. Input operations ---

#region --- 02. Business logic ---
double distance; // int = 5 -> 5.0, double 7.8 -> ?
try
{
    // Вызов метода, возвращающего значение дистанции по переданным координатам x и y.
    // Результат вызова присваивается переменной distance.
    distance = GetDistanceByCoords(xA, yA, xB, yB);
}
catch(Exception exc)
{
    Console.WriteLine($"ОШИБКА! {exc.Message}");
    return; // Завершение программы в случае ошибки
}
#endregion --- 02. Business logic ---

#region --- 03. Output operations ---
Console.WriteLine($"Расстояние между заданными точками A({xA}, {yA}) и B({xB}, {yB}) в пространстве = {distance}");
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
static double GetDistanceByCoords(int xA, int yA, int xB, int yB)
{
         double dX = xA-xB;
         double dY = yA-yB; // 1 -> 1.0
         return (Math.Sqrt(dX * dX + dY * dY));
}
// ---------------------- Конец определения методов ----------------------------