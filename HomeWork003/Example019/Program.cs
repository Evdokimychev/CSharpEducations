// Задача 23: Напишите программу, которая принимает на вход пятизначное число 
// и проверяет, является ли оно палиндромом.

// Пример:
// 14212 -> нет
// 23432 -> да
// 12821 -> да

// -------------------------- Начало программы ----------------------------------
#region --- 00. Configuration ---
Console.Clear ();
Console.Title = "Задача 23. Проверка пятизначного числа на палиндромность";

Console.OutputEncoding = System.Text.Encoding.UTF8;
var curConsoleColor = Console.ForegroundColor;
Console.ForegroundColor = ConsoleColor.DarkGreen;
Console.WriteLine(@"************************************************************************
    Напишите программу, которая принимает на вход пятизначное число 
            и проверяет, является ли оно палиндромом.
************************************************************************");
Console.ForegroundColor = curConsoleColor;
#endregion

#region --- 01. Input operations ---
// Вызов метода, запрашивающего у пользователя целое пятизначное число.
int number = GetNumberFromUser ("Введите пятизначное число: ", "Ошибка ввода данных!");
#endregion --- 01. Input operations ---

#region --- 02. Business logic ---
string result;
try
{
    // result = GetPalindromicNumber (number);
    GetPalindromicNumber (number);
}
catch(Exception exc)
{
    Console.WriteLine($"ОШИБКА! {exc.Message}");
    return; // Завершение программы в случае ошибки
}
#endregion --- 02. Business logic ---

#region --- 03. Output operations ---
// Console.WriteLine($"Введённое вами число {number} -> {result}");
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

// Определяем функцию вывода таблицы кубов
static void GetPalindromicNumber (int number)
{  
    while (number < 10000 || number >=100000) 
    {
        System.Console.WriteLine("Это не пятизначное число");
        number = GetNumberFromUser ("Введите новое пятизначное число: ", "Ошибка ввода данных!");
    }

    string result = "";
    int a1 = number / 10000;
    int a2 = number / 1000 % 10;
    int a3 = number / 100 % 10;
    int a4 = number / 10 % 10;
    int a5 = number % 10;
    // Console.WriteLine($"{a1}, {a2}, {a3}, {a4}, {a5}");
    if (a1 == a5 && a2 == a4) result = "является палиндромом";
    else result = "НЕ является палиндромом";
    Console.WriteLine($"Введённое вами число {number} -> {result}");
    return;
}
// ---------------------- Конец определения методов ----------------------------
