/*Задайте массив заполненный случайными положительными трёхзначными числами. 
Напишите программу, которая покажет количество чётных чисел в массиве.*/
int[] array = GetArray(9, 100, 1000);
Console.WriteLine($"В массиве [{String.Join(",", array)}] {numberofeven(array)} четных чисел");

int numberofeven(int[] Num){
    int count = 0;
    for (int i = 0; i < Num.Length; i++)
    {
        if (Num[i] % 2 == 0) count++;
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