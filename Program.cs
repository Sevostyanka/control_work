// Написать программу, которая из имеющегося массива строк
// формирует массив из строк, длинна которых <= 3 символа.
// Первоначальный массив можно либо ввести с клавиатуры, либо задать на старте.
// Не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

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

