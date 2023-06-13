/*
Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами.
Напишите программу, которая покажет количество чётных чисел в массиве.
[345, 897, 568, 234] -> 2
*/
/*
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
*/

/*
Задача 36: Задайте одномерный массив, заполненный случайными числами.
Найдите сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0
*/

/*
int[] GetArray(int size)
{
    int[] resultArray = new int[size];

    for (int i = 0; i < resultArray.Length; i++)
    {
        resultArray[i] = new Random().Next(100);
    }
    return resultArray;
}
int[] array = GetArray(10);
Console.WriteLine($"Массив: [{String.Join("; ", array)}]");

int sum = 0;
for (int i = 0; i < array.Length; i++)
{
    if (i % 2 != 0)
    {
        sum = sum + array[i];
    }
}
Console.WriteLine($"Сумма элементов, стоящих на нечётных позициях равна {sum}]");
*/



/*
Задача 38: Задайте массив вещественных чисел.
Найдите разницу между максимальным и минимальным элементов массива.
[3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76
*/

double[] GetArray(int size)
{
    double[] resultArray = new double[size];

    for (int i = 0; i < resultArray.Length; i++)
    {
        resultArray[i] = Math.Round(new Random().NextDouble() * 100, 2);
    }
    return resultArray;
}
double[] array = GetArray(5);
Console.WriteLine($"Массив: [{String.Join("; ", array)}]");

double maxValue = array[0];
double minValue = array[0];
double result = 0;
for (int i = 0; i < array.Length; i++)
{
    if (maxValue < array[i])
    {
        maxValue = array[i];
    }
    else if (minValue > array[i])
    {
        minValue = array[i];
    }
}
result = maxValue - minValue;

Console.WriteLine($"Максимальное число: {maxValue}, Минимальное число: {minValue}");
Console.WriteLine($"Разница между максимальным и минимальным элементом массива равна: {Math.Round(result, 2)}");