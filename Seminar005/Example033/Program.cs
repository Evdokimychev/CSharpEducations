// Задача 33: Задайте массив. Напишите программу, которая
// определяет, присутствует ли заданное число в массиве.

// Пример:
// 4; массив [6, 7, 19, 345, 3] -> нет
// 3; массив [6, 7, 19, 345, 3] -> да

// -------------------------- Начало программы ----------------------------------
#region --- 00. Configuration ---
Console.Clear ();

Console.Title = "Задача 33. Создание массива и поиск элементов";

Console.OutputEncoding = System.Text.Encoding.UTF8;
var curConsoleColor = Console.ForegroundColor;
Console.ForegroundColor = ConsoleColor.DarkGreen;
Console.WriteLine(@"**************************************************************************************
                Задайте массив. Напишите программу, которая
            определяет, присутствует ли заданное число в массиве.
**************************************************************************************");
Console.ForegroundColor = curConsoleColor;
#endregion

#region --- 01. Input operations ---
int count = GetNumberFromUser ("Введите количество элементов в массиве: ", "Ошибка ввода данных!");
int minValue = GetNumberFromUser ("Введите минимальное значение в массиве: ", "Ошибка ввода данных!");
int maxValue = GetNumberFromUser ("Введите максимальное значение в массиве: ", "Ошибка ввода данных!");
int findNumber = GetNumberFromUser ("Введите искомое значение в массиве: ", "Ошибка ввода данных!");

// Вызов метода, создающего массив по данным параметрам
int[] array = GetArray(count, minValue, maxValue);
// Console.WriteLine(String.Join(" ", array));
PrintArray (array);

string result = findEl(array, findNumber);
Console.WriteLine(result);
#endregion --- 01. Input operations ---

#region --- 02. Business logic ---
// int[] newArray = replacingTheSign(array);
// // Console.WriteLine(String.Join(" ", newArray));
// PrintArray (newArray);

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

// Метод изменяет знак на противоположный
// int[] replacingTheSign(int[] arr)
// {
//     int[] newArray = new int[arr.Length];
//     for(int i = 0;i < arr.Length; i++)
//     {
//        newArray[i] = arr[i] * -1;
//     }
//     return newArray;
// }

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

// Метод поиска индекса элемента
// int IndexOf (int[] array, int find)
// {
//     int count = array.Length;
//     int index = 0;
//     int position = -1; // Чтобы обозначить, что элемент не найден
//     while (index < count)
//     {
//         if (array[index] == find)
//         {
//             position = index;
//             break;
//         }
//         index++;
//     }
//     return position;
// }

// Метод проверки нахождения элемента в массиве
string findEl (int[] array, int findNumber)
{
    int count = array.Length;
    int index = 0;
    string result = "";
    while (index < count)
    {
        if (array[index] == findNumber)
        {
            result = "Да";
            break;
        }
        else result = "Нет";
        index++;
    }
    return result;
}
// ---------------------- Конец определения методов ----------------------------