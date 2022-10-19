/*Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.*/
int[] array = GetArray(9, 10, 100);
Console.WriteLine($"Сумма элементов стоящих на нечетных позициях массива [{String.Join(",", array)}] = {SumEvenNumbers(array)}");

int SumEvenNumbers(int[] Num){
    int count = 0;
    for (int i = 0; i < Num.Length; i++)
    {
        if (i % 2 != 0)
        {
            count += Num[i];
        }
    }
    return count;
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
