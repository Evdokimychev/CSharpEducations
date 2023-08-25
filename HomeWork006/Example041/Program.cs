// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

// Пример:
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

// // -------------------------- Начало программы ----------------------------------
// #region --- 00. Configuration ---
// Console.Clear ();

// Console.Title = "Задача 41. Подсчёт чисел больше 0, введённых пользователем";

// Console.OutputEncoding = System.Text.Encoding.UTF8;
// var curConsoleColor = Console.ForegroundColor;
// Console.ForegroundColor = ConsoleColor.DarkGreen;
// Console.WriteLine(@"**************************************************************************************
//                     Пользователь вводит с клавиатуры M чисел. 
//                 Посчитайте, сколько чисел больше 0 ввёл пользователь.
// **************************************************************************************");
// Console.ForegroundColor = curConsoleColor;
// #endregion

// #region --- 01. Input operations ---
// // Вызов метода, запрашивающего данные у пользователя
// int sideOfTheTriangle1 = GetNumberFromUser ("Введите размер первой стороны треугольника: ", "Ошибка ввода данных!");
// int sideOfTheTriangle2 = GetNumberFromUser ("Введите размер второй стороны треугольника: ", "Ошибка ввода данных!");
// int sideOfTheTriangle3 = GetNumberFromUser ("Введите размер третьей стороны треугольника: ", "Ошибка ввода данных!");
// #endregion --- 01. Input operations ---

// #region --- 02. Business logic ---
// // Вызов метода проверки возможности существования треугольника
// string result = FindTheTriangle (sideOfTheTriangle1, sideOfTheTriangle2, sideOfTheTriangle3);
// #endregion --- 02. Business logic ---

// #region --- 03. Output operations ---
// // Выводим результат в консоль согласно примеру
// Console.WriteLine($"\nТреугольник со сторонами AB ({sideOfTheTriangle1}), BC ({sideOfTheTriangle2}), CA ({sideOfTheTriangle3}) -> {result}");
// #endregion --- 03. Output operations ---
// // -------------------------- Конец программы ----------------------------------


// // -------------------------Определение методов ---------------------------------

// // Метод запроса данных у пользователя
// static int GetNumberFromUser (string welcomeMessage, string errorMessage)
// {   
//     while(true)
//     {
//         try
//         {
//             Console.Write(welcomeMessage);
//             return int.Parse(Console.ReadLine() ?? "");            
//         }
//         catch (Exception exc)
//         {
//             Console.WriteLine($"{errorMessage} {exc.Message}");        
//         }
//     }
// }

// // Метод проверки возможности существования треугольника
// string FindTheTriangle (int sideOfTheTriangle1, int sideOfTheTriangle2, int sideOfTheTriangle3)
// {
//     string result;
//     if (sideOfTheTriangle1 + sideOfTheTriangle2 < sideOfTheTriangle3) result = "не может существовать";
//     else if (sideOfTheTriangle1 + sideOfTheTriangle3 < sideOfTheTriangle2) result = "не может существовать";
//     else if (sideOfTheTriangle2 + sideOfTheTriangle3 < sideOfTheTriangle1) result = "не может существовать";
//         else result = "может существовать";
//         return result;
// }


// // ---------------------- Конец определения методов ----------------------------



Console.Write("Введите числа через запятую: ");
int[] numbers = StringToNum(Console.ReadLine());
PrintArray(numbers);
int sum = 0;
for (int i = 0; i < numbers.Length; i++)
{
    if (numbers[i] > 0)
    {
        sum++;
    }
}
Console.WriteLine();
Console.WriteLine($"количество значений больше 0 = {sum}");


int[] StringToNum(string input)
{
    int count = 1;
    for (int i = 0; i < input.Length; i++)
    {
        if (input[i] == ',')
        {
            count++;
        }
    }

    int[] numbers = new int [count];
    int index = 0;

    for (int i = 0; i < input.Length; i++)
    {
        string temp = "";

        while (input [i] != ',')
        {
        if(i != input.Length - 1)
        {
            temp += input [i].ToString();
            i++;
        }
        else
        {
            temp += input [i].ToString();
            break;
        }
        }
        numbers[index] = Convert.ToInt32(temp);
        index++;
    }
    return numbers;
}


void PrintArray(int[] array)
{
    Console.Write("[ ");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.Write("]");
}