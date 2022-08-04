// Написать программу, которая из имеющегося массива строк
// формирует массив из строк, длинна которых <= 3 символа.
// Первоначальный массив можно либо ввести с клавиатуры, либо задать на старте.
// Не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.
// Пометка: задаю значения массива сразу для удобства проверки.

// метод, выводящий строку на экран:
void PrintMass (string[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]}, ");
    }
}

// метод укорачивания массива, выдаёт случайные позиции из первичного массива:
string[] ShortString (string[] array)
{
    string[] shortArr = new string[new Random().Next(0,4)];
    for (int i = 0; i < shortArr.Length; i++)
    {
        shortArr[i] = array[new Random().Next(0,array.Length)];
    }
    return shortArr;
}

// данные 1й :
Console.WriteLine("Первичная строка:");
string[] array = {"hello", "why", "123", ":)", "Love you", "nice day", "monkey"};
PrintMass(array);

// данные укороченного:
Console.WriteLine();
Console.WriteLine("Укороченная строка:");
PrintMass(ShortString(array));