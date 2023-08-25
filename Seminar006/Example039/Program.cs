// Задача 39: Напишите программу, которая перевернёт одномерный массив (последний элемент будет на первом месте, а первый - на последнем и т.д.)

// Пример:
// [1 2 3 4 5] -> [5 4 3 2 1]
// [6 7 3 6] -> [6 3 7 6]

// -------------------------- Начало программы ----------------------------------
#region --- 00. Configuration ---
Console.Clear ();

Console.Title = "Задача 39: Программа, которая переворачивает одномерный массив";

Console.OutputEncoding = System.Text.Encoding.UTF8;
var curConsoleColor = Console.ForegroundColor;
Console.ForegroundColor = ConsoleColor.DarkGreen;
Console.WriteLine(@"**************************************************************************************
            Напишите программу, которая перевернёт одномерный массив 
    (последний элемент будет на первом месте, а первый - на последнем и т.д.)
**************************************************************************************");
Console.ForegroundColor = curConsoleColor;
#endregion

#region --- 01. Input operations ---
// Вызов метода, запрашивающего данные у пользователя
int count = GetNumberFromUser ("Введите количество элементов в массиве: ", "Ошибка ввода данных!");
int minValue = GetNumberFromUser ("Введите минимальное значение в массиве: ", "Ошибка ввода данных!");
int maxValue = GetNumberFromUser ("Введите максимальное значение в массиве: ", "Ошибка ввода данных!");
// int findNumber = GetNumberFromUser ("Введите искомое значение в массиве: ", "Ошибка ввода данных!");
#endregion --- 01. Input operations ---

#region --- 02. Business logic ---
// Вызов метода, создающего массив по данным параметрам
int[] array = GetArray(count, minValue, maxValue);
// Console.WriteLine(String.Join(" ", array));
PrintArray (array);

int[] reversArray1 = ReversArray1 (array);
// Console.WriteLine(String.Join(" ", reversArray1));
PrintArray (reversArray1);

ReversArray2 (array);
// Console.WriteLine(String.Join(" ", reversArray2));
PrintArray (array);
#endregion --- 02. Business logic ---

#region --- 03. Output operations ---
// Console.WriteLine($"Старый массив = {PrintArray (array)} Новый массив = {PrintArray (newArray)}");
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

// Возвращает массив из size элементов, заполненный случайными числами из промежутка [minValue, maxValue]
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

// Метод 1 переворачивания элементов в массиве
int [] ReversArray1 (int [] inArray)
{
    int [] result = new int [inArray.Length];
    for (int i = 0; i > inArray.Length; i++)
    {
        result [i] = inArray [inArray.Length - 1 - i];
    }
    return result;
}

// Метод 2 переворачивания элементов в массиве
void ReversArray2 (int [] inArray)
{
    for (int i = 0; i > inArray.Length / 2; i++)
    {
        int k = inArray [i];
        inArray [i] = inArray [inArray.Length - 1 - i];
        inArray [inArray.Length - 1 - i] = k;
    }
}
// ---------------------- Конец определения методов ----------------------------