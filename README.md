# Задание
Написать программу, которая из имеющегося массива строк
формирует массив из строк, длинна которых <= 3 символа.
Первоначальный массив можно либо ввести с клавиатуры, либо задать на старте.
Не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

# Решение
* задан строковый массив __array__.
* написан метод **PrintMass**, выводящий в терминал все элементы массива. Метод void, на вход получает строковый одномерный массив.
* прописан метод **ShortString**, укорачивающий заданный массив на произвольное число элементов в диапазоне от 0 до 3 включительно. Описание:
  * принимает строковый одномерный массив и возвращает строковый одномерный массив. 
  * задан новый строковый массив *shortArr*, длинна которого рандомна в диапазоне 0-3.
  * в цикле *for* элементам массива *shortArr* присваиваются значения рандомных элементов первоначального массива *array*.
  * возвращается готовый массив *shortArr*.
* выводится на экран первоначально заданный **array** через **PrintMass**.
* выводитя на экран укороченый вариант **array** через **PrintMass** и **ShortString**.
