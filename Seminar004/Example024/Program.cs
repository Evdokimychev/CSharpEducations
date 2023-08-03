// Задача 24: : Напишите программу, которая принимает на вход число (А) 
// и выдаёт сумму чисел от 1 до А

// Пример:
// 4 -> 10 (1+2+3+4=10)
// 7 -> 28
// 8 -> 36

// -------------------------- Начало программы ----------------------------------
#region --- 00. Configuration ---
Console.Clear ();
Console.Title = "Задача 24. Выдача суммы чисел от 1 до введённого числа пользователем";

Console.OutputEncoding = System.Text.Encoding.UTF8;
var curConsoleColor = Console.ForegroundColor;
Console.ForegroundColor = ConsoleColor.DarkGreen;
Console.WriteLine(@"************************************************************************
        Напишите программу, которая принимает на вход число (А) 
                    и выдаёт сумму чисел от 1 до А
************************************************************************");
Console.ForegroundColor = curConsoleColor;
#endregion

#region --- 01. Input operations ---
// Вызов метода, запрашивающего у пользователя целое число (А).
int number = GetNumberFromUser ("Введите число А: ", "Ошибка ввода данных!");
int sumNumbers = GetSumNumbers(number);
#endregion --- 01. Input operations ---

#region --- 02. Business logic ---
string result;
try
{
    // result = GetSummNumber (number);
    GetSumNumbers (number);
}
catch(Exception exc)
{
    Console.WriteLine($"ОШИБКА! {exc.Message}");
    return; // Завершение программы в случае ошибки
}
#endregion --- 02. Business logic ---

#region --- 03. Output operations ---
Console.WriteLine($"{number} -> {sumNumbers}");
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

// Определяем функцию определения суммы чисел от 1 до числа А
// static void GetSumNumbers (int number)
// {  
//     while (number < 0) 
//     {
//         System.Console.WriteLine("Это число меньше 0");
//         number = GetNumberFromUser ("Введите новое число: ", "Ошибка ввода данных!");
//     }

//     int sum = 0;
//     int i = 0;
//     while (i <= number)
//     {
//         sum = sum + i;
//         i++;
//     }
    
//     Console.Write($"{sum} ");
// }

// or

int GetSumNumbers (int number)
{
    int sum = 0;
    while (number > 0)
    {
        sum += number;
        number--;
    }
    return sum;
}
// ---------------------- Конец определения методов ----------------------------
