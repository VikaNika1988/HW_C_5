/*Задайте массив вещественных чисел(просто от минус бесконечности, до плюс бесконечности, с дробными не работаем). 
Найдите разницу между максимальным и минимальным элементов массива.*/
int[] array = GetArray(5, -1000, 1000);// не нашла как ставить бесконечность
Console.WriteLine($"Разница между максимальным и минимальным элементами массива [{string.Join(",", array)}] = {difference(array)}");

int difference(int[] arr)
{
    int min = arr[0];
    int max = arr[0];
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > max) max = arr[i];
        if (arr[i] < min) min = arr[i];
    }
    int diff = max - min;
    return diff;
}

int[] GetArray(int size, int minValue, int maxValue)
{
    int[] res = new int[size];

    for (int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(minValue, maxValue + 1);
    }
    return res;
}