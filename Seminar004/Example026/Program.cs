// Задача 26: : Напишите программу, которая принимает
// на вход число и выдаёт количество цифр в числе.

// Пример:
// 456 -> 3
// 78 -> 2
// 89126 -> 5

// -------------------------- Начало программы ----------------------------------
#region --- 00. Configuration ---
Console.Clear ();
Console.Title = "Задача 26. Определение значности введённого числа пользователем";

Console.OutputEncoding = System.Text.Encoding.UTF8;
var curConsoleColor = Console.ForegroundColor;
Console.ForegroundColor = ConsoleColor.DarkGreen;
Console.WriteLine(@"************************************************************************
        Напишите программу, которая принимает на вход число 
                и выдаёт количество цифр в числе.
************************************************************************");
Console.ForegroundColor = curConsoleColor;
#endregion

#region --- 01. Input operations ---
// Вызов метода, запрашивающего у пользователя целое число.
int number = GetNumberFromUser ("Введите число: ", "Ошибка ввода данных!");
int count = GetFindNumbers(number);
#endregion --- 01. Input operations ---

#region --- 02. Business logic ---
string summ;
try
{
    // result = GetSummNumber (number);
    GetFindNumbers (number);
}
catch(Exception exc)
{
    Console.WriteLine($"ОШИБКА! {exc.Message}");
    return; // Завершение программы в случае ошибки
}
#endregion --- 02. Business logic ---

#region --- 03. Output operations ---
Console.WriteLine($"{number} -> {count}");
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
       
        // Вариант 2 (Преподавателя)
        // Console.Write(welcomeMessage);
        // bool isCorrect = int.TryParse(Console.ReadLine(), out int userNumber);
        // if (isCorrect)
        //     return userNumber;
        // Console.Write(errorMessage);
    }

}

// Определяем функцию определения значности числа А

int GetFindNumbers (int number)
{
    int count= 0;
    while (number != 0)
    {
        number = number / 10;
        count++;
    }
    return count;
}
// ---------------------- Конец определения методов ----------------------------
