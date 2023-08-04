// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.

// Пример:
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

// -------------------------- Начало программы ----------------------------------
#region --- 00. Configuration ---
Console.Clear ();

Console.Title = "Задача 36. Создание массива из случайных чисел и поиск суммы нечётных значений элементов массива";

Console.OutputEncoding = System.Text.Encoding.UTF8;
var curConsoleColor = Console.ForegroundColor;
Console.ForegroundColor = ConsoleColor.DarkGreen;
Console.WriteLine(@"**************************************************************************************
                Задайте одномерный массив, заполненный случайными числами. 
                Найдите сумму элементов, стоящих на нечётных позициях.
**************************************************************************************");
Console.ForegroundColor = curConsoleColor;
#endregion

#region --- 01. Input operations ---
// Вызов метода, запрашивающего данные у пользователя
int count = GetNumberFromUser ("Введите количество элементов в массиве: ", "Ошибка ввода данных!");
int minValue = GetNumberFromUser ("Введите минимальное значение в массиве: ", "Ошибка ввода данных!");
int maxValue = GetNumberFromUser ("Введите максимальное значение в массиве: ", "Ошибка ввода данных!");
#endregion --- 01. Input operations ---

#region --- 02. Business logic ---
// Вызов метода, создающего массив по данным параметрам
 int[] array = GetArray(count, minValue, maxValue);

// Вызов метода, выводящего созданный массив в консоль
PrintArray (array);

// Вызов метода, подсчитывающего сумму нечётных элементов массива
int sumOddEl = FindSumOddEl (array);

#endregion --- 02. Business logic ---

#region --- 03. Output operations ---
Console.WriteLine($"Сумма нечётных значений элементов в массиве -> {sumOddEl}");
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

// Метод, создающий массив. Возвращает массив из size элементов, заполненный случайными числами из промежутка [minValue, maxValue]
int[] GetArray(int size, int minValue, int maxValue)
{
    int[] res = new int[size];
    for (int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(minValue, maxValue + 1);
    }
    return res;
}

// Метод вывода массива
void PrintArray (int[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length - 1; i++)
    {
        Console.Write(arr[i] + ", ");
    }
    Console.WriteLine(arr[arr.Length - 1]+"]");
}

// Метод, который подсчитывает сумму нечётных элементов массива
int FindSumOddEl (int[] array)
{
    int sumOddEl = 0;
    foreach (int el in array)
    {
        if (el % 2 != 0) sumOddEl = sumOddEl + el;
    }
    return sumOddEl;
}
// ---------------------- Конец определения методов ----------------------------