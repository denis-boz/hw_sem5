/*
Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами.
Напишите программу, которая покажет количество чётных чисел в массиве.
[345, 897, 568, 234] -> 2
*/
int[] GetArray(int size, int minValue, int maxValue)
{
    int[] resultArray = new int[size];

    for (int i = 0; i < resultArray.Length; i++)
    {
        resultArray[i] = new Random().Next(minValue, maxValue + 1);
    }
    return resultArray;
}
int[] array = GetArray(10, 100, 1000);
Console.WriteLine($"Массив: [{String.Join("; ", array)}]");
int quantity = 0;
for (int i = 0; i < array.Length; i++)
{
    if (array[i] % 2 == 0)
    {
        quantity ++;
    }
}
Console.WriteLine($"Количество четных чисел в массиве: {quantity}");