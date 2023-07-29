// Задача 21: Напишите программу, которая принимает на вход координаты двух точек 
// и находит расстояние между ними в 3D пространстве.

// Пример:
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

// -------------------------- Начало программы ----------------------------------
#region --- 00. Configuration ---
Console.Clear ();
Console.Title = "Задача 21. Нахождение расстояния между двумя заданными точками";

Console.OutputEncoding = System.Text.Encoding.UTF8;
var curConsoleColor = Console.ForegroundColor;
Console.ForegroundColor = ConsoleColor.DarkGreen;
Console.WriteLine(@"************************************************************************
    Напишите программу, которая принимает на вход координаты двух точек 
            и находит расстояние между ними в 3D пространстве.
************************************************************************");
Console.ForegroundColor = curConsoleColor;
#endregion

#region --- 01. Input operations ---
// Вызов метода, запрашивающего у пользователя целое число. Введённое число присваивается переменной x точки А
int xA = GetNumberFromUser("Введите координату x точки A: ", "Ошибка ввода данных!");
// Вызов метода, запрашивающего у пользователя целое число. Введённое число присваивается переменной y точки А
int yA = GetNumberFromUser("Введите координату y точки A: ", "Ошибка ввода данных!");
// Вызов метода, запрашивающего у пользователя целое число. Введённое число присваивается переменной z точки А
int zA = GetNumberFromUser("Введите координату z точки A: ", "Ошибка ввода данных!");
// Вызов метода, запрашивающего у пользователя целое число. Введённое число присваивается переменной x точки В
int xB = GetNumberFromUser("Введите координату y точки B: ", "Ошибка ввода данных!");
// Вызов метода, запрашивающего у пользователя целое число. Введённое число присваивается переменной y точки B
int yB = GetNumberFromUser("Введите координату y точки B: ", "Ошибка ввода данных!");
// Вызов метода, запрашивающего у пользователя целое число. Введённое число присваивается переменной z точки B
int zB = GetNumberFromUser("Введите координату z точки B: ", "Ошибка ввода данных!");
#endregion --- 01. Input operations ---

#region --- 02. Business logic ---
double distance; // int = 5 -> 5.0, double 7.8 -> ?
try
{
    // Вызов метода, возвращающего значение дистанции по переданным координатам x, y, z.
    // Результат вызова присваивается переменной distance.
    distance = GetDistanceByCoords(xA, yA, zA, xB, yB, zB);
}
catch(Exception exc)
{
    Console.WriteLine($"ОШИБКА! {exc.Message}");
    return; // Завершение программы в случае ошибки
}
#endregion --- 02. Business logic ---

#region --- 03. Output operations ---
Console.WriteLine($"Расстояние между заданными точками A ({xA}, {yA}, {zA}) и B ({xB}, {yB}, {zB}) в пространстве = {distance}");
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
static double GetDistanceByCoords(int xA, int yA, int zA, int xB, int yB, int zB)
{
         double dX = xA - xB;
         double dY = yA - yB;
         double dZ = zA - zB;
         return (Math.Sqrt((dX * dX) + (dY * dY) + (dZ * dZ)));
}
// ---------------------- Конец определения методов ----------------------------