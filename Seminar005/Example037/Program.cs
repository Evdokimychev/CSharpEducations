// Задача 37: Найдите произведение пар чисел в одномерном массиве.
// Парой считаем первый и последний элемент, второй и предпоследний и т.д. 
// Результат запишите в новом массиве.

// Пример:
// [1 2 3 4 5] -> 5 8 3
// [6 7 3 6] -> 36 21

// -------------------------- Начало программы ----------------------------------
#region --- 00. Configuration ---
Console.Clear ();

Console.Title = "Задача 37. Создание массива и поиск произведения симметричных элементов относительно центра массива";

Console.OutputEncoding = System.Text.Encoding.UTF8;
var curConsoleColor = Console.ForegroundColor;
Console.ForegroundColor = ConsoleColor.DarkGreen;
Console.WriteLine(@"**************************************************************************************
                Найдите произведение пар чисел в одномерном массиве.
        Парой считаем первый и последний элемент, второй и предпоследний и т.д. 
                        Результат запишите в новом массиве.
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
// Console.WriteLine(String.Join(" ", array));

// Вызов метода, выводящего созданный массив в консоль
PrintArray (array);

// Вызов метода, выводящего произведения симметричных элементов относительно центра массива
// PrintResultProduct (array);
int[] resArr = ConvertArr (array);
PrintArray (resArr);
// Вызов метода, подсчитыющего колличество совпадающих элементов с отрезка
// int result = findCountEl(array, minValueSection, maxValueSection);
// Console.WriteLine(result);
#endregion --- 02. Business logic ---

#region --- 03. Output operations ---
// Console.WriteLine($"-> {result}");
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
// string findEl (int[] array, int findNumber)
// {
//     int count = array.Length;
//     int index = 0;
//     string result = "";
//     while (index < count)
//     {
//         if (array[index] == findNumber)
//         {
//             result = "Да";
//             break;
//         }
//         else result = "Нет";
//         index++;
//     }
//     return result;
// }

// Метод проверки нахождения колличества элемента в массиве
// int findCountEl (int[] array, int minValueSection, int maxValueSection )
// {
//     int res = 0;
//     for (int i = 0; i < array.Length; i++)
//     {
//         if (Test(array[i]))
//         {
//             res++;
//         }
//     }
//     return res;
// }

// bool Test(int n)
// {
//     return (n > minValueSection && n < maxValueSection);
// }

// Метод, выводящий произведения симметричных элементов относительно центра массива
// (не работает)
// void PrintResultProduct (int[] array)
// {
//     int count = array.Length;
//     int resultProduct = 0;
//     int index = 0;
//     while (index != count)
//     {
//         resultProduct = array[index] * array[count];
//         Console.Write (resultProduct);
//         index++;
//         count--;
//     }
// }

// Метод, выводящий произведения симметричных элементов относительно центра массива
int[] ConvertArr(int[] arr)
{
    int[] resArr = new int[(arr.Length/2)+1];
    for (int i = 0; i < resArr.Length; i++)
    {
        resArr[i]=arr[i] * arr[arr.Length - 1 - i];
    }
    return resArr;
}
// ---------------------- Конец определения методов ----------------------------