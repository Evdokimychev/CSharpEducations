// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.

// Пример:
// [345, 897, 568, 234] -> 2


// -------------------------- Начало программы ----------------------------------
#region --- 00. Configuration ---
Console.Clear ();

Console.Title = "Задача 34. Создание массива из трёхзначных чисел и поиск количества чётных элементов массива";

Console.OutputEncoding = System.Text.Encoding.UTF8;
var curConsoleColor = Console.ForegroundColor;
Console.ForegroundColor = ConsoleColor.DarkGreen;
Console.WriteLine(@"**************************************************************************************
        Задайте массив заполненный случайными положительными трёхзначными числами. 
        Напишите программу, которая покажет количество чётных чисел в массиве.
**************************************************************************************");
Console.ForegroundColor = curConsoleColor;
#endregion

#region --- 01. Input operations ---
// Вызов метода, запрашивающего данные у пользователя
int count = GetNumberFromUser ("Введите количество элементов в массиве: ", "Ошибка ввода данных!");
// int minValue = GetNumberFromUser ("Введите минимальное трёхзначное значение в массиве: ", "Ошибка ввода данных!");
// int maxValue = GetNumberFromUser ("Введите максимальное трёхзначное значение в массиве: ", "Ошибка ввода данных!");
#endregion --- 01. Input operations ---

#region --- 02. Business logic ---
// Вызов метода, создающего массив по данным параметрам
 int[] array = GetArray(count, 100, 999);

// Вызов метода, выводящего созданный массив в консоль
PrintArray (array);

// Вызов метода, подсчитывающего количество чётных элементов массива
int countEvenEl = FindCountEvenEl (array);

#endregion --- 02. Business logic ---

#region --- 03. Output operations ---
Console.WriteLine($"Количество чётных чисел в массиве -> {countEvenEl}");
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

// Метод, который подсчитывает количество чётных элементов массива
int FindCountEvenEl (int[] array)
{
    int countEvenEl = 0;
    foreach (int el in array)
    {
        if (el % 2 == 0) countEvenEl ++;
    }
    return countEvenEl;
}
// ---------------------- Конец определения методов ----------------------------