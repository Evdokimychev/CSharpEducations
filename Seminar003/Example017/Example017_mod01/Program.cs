//Напишите программу, которая принимает на вход координаты точки (X и Y), причём X ≠ 0 и Y ≠ 0 
//и выдаёт номер четверти плоскости, в которой находится эта точка.
// -------------------------- Начало программы ----------------------------------
#region --- 00. Configuration ---
Console.Clear();
Console.Title = "Задача 17. Определение номера четверти по заданным координатам";

Console.OutputEncoding = System.Text.Encoding.UTF8;
var curConsoleColor = Console.ForegroundColor;
Console.ForegroundColor = ConsoleColor.DarkGreen;
Console.WriteLine(@"************************************************************************
Напишите программу, которая принимает на вход координаты точки (X и Y),
        причём X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости,
                в которой находится эта точка.
************************************************************************");
Console.ForegroundColor = curConsoleColor;
#endregion

#region --- 01. Input operations ---
// Вызов метода, запрашивающего у пользователя целое число. Введённое число присваивается переменной x
int x = GetNumberFromUser ();
// Вызов метода, запрашивающего у пользователя целое число. Введённое число присваивается переменной y
int y = GetNumberFromUser ();
#endregion --- 01. Input operations ---

#region --- 02. Business logic ---
int quarter;
try
{
    // Вызов метода, возвращающего номер четверти по переданным координатам x и y.
    // Результат вызова присваивается переменной quarter.
    quarter = GetQuarterByCoords (x, y);
}
catch (Exception exc)
{
    Console.WriteLine ($"ОШИБКА! {exc.Message}");
    return; // Завершение программы в случае ошибки
}
#endregion --- 02. Business logic ---

#region --- 03. Output operations ---
Console.WriteLine ($"Номер четверти: {quarter}");
#endregion --- 03. Output operations ---
// -------------------------- Конец программы ----------------------------------


// -------------------------Определение методов ---------------------------------
// Определяем функцию, выполняющую ввод целого числа с консоли
static int GetNumberFromUser ()
{   
    while (true)
    {
        try
        {
            Console.Write ("Введите целое число: ");
            int num = int.Parse (Console.ReadLine () ?? "");
            return num;
        }
        catch (Exception exc)
        {
            Console.WriteLine ($"Ошибка ввода данных! {exc.Message}");        
        }
    }
}

// Определяем функцию, принимающую два аргумента (координаты точки x и y)
// и возвращающую номер четверти плоскости, в которой находится эта точка
// В случае попадания точки на оси координат генерируется исключение
static int GetQuarterByCoords (int x, int y)
{
    if (x > 0 && y > 0)
        return 1;
    else if (x < 0 && y > 0)
        return 2;
    else if (x < 0 && y < 0)
        return 3;
    else if (x > 0 && y < 0)
        return 4;
    else
        throw new Exception ("Точка попадает на оси координат!");
}
// ---------------------- Конец определения методов ----------------------------