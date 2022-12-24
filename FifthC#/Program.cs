﻿ /* Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве. */

/*
 int[] CreateRandomArray(int size, int min = 100, int max = 1000)
{
    int[] array = new int[size];

    for(int i = 0; i < array.Length; i++)
        array[i] = new Random().Next(min, max);
    
    return array;
}

void ShowArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}

int EvenNumbers(int[] myArray)
{
    int count = 0;
    for(int i = 0; i < myArray.Length; i++)
    {
        if(myArray[i] % 2 == 0)
        {
            count++;
        }
    }
    return count;
}

Console.Write("Input Number of Elements: ");
int length = Convert.ToInt32(Console.ReadLine());

int[] myArray = CreateRandomArray(length);
ShowArray(myArray);

int result = EvenNumbers(myArray);
Console.Write("The number of even positive elements in the array is " + result);
*/



/* Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях. */

/*
int[] CreateRandomArray(int size, int min, int max)
{
    int[] array = new int[size];
    for(int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(min, max + 1);
    }
    return array;
}

void ShowArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}

int SumOddPositions(int[] array) // Счёт индексов начинается с нулевого.
{
    int sum = 0;
    for(int i = 1; i < array.Length; i += 2)
    {
        sum += array[i];
    }
    return sum;
}

Console.Write("Input Number of Elements: ");
int size = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a min possible Value: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a max possible Value: ");
int max = Convert.ToInt32(Console.ReadLine());

int[] myArray = CreateRandomArray(size, min, max);
ShowArray(myArray);

int sum = SumOddPositions(myArray);
Console.Write("Sum of elements in odd position is " + sum);
*/



/* Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива. */

/*
double[] CreateDoubleArray(int size, int min, int max)
{
    double[] array = new double[size];
    for(int i = 0; i < array.Length; i++)
    {
        array[i] = Math.Round(new Random().Next(min, max) + new Random().NextDouble(), 2);
    }
    return array;
}

void ShowArray(double[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        Console.Write("[" + array[i] + "] ");
    }
    Console.WriteLine();
}

double Difference(double[] array)
{
    double minValue = array[0];
    double maxValue = array[0];
    
    for(int i = 0; i < array.Length; i++)
    {
        if(array[i] < minValue) minValue = array[i];
        if(array[i] > maxValue) maxValue = array[i];
    }

    Console.WriteLine($"Maximum value is [{maxValue}]");
    Console.WriteLine($"Minimum value is [{minValue}]");

    double difference = maxValue - minValue;
    return difference;
}

Console.Write("Input Number of Elements: ");
int size = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a min possible Value: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a max possible Value: ");
int max = Convert.ToInt32(Console.ReadLine());

double[] myArray = CreateDoubleArray(size, min, max);
ShowArray(myArray);

double diff = Math.Round(Difference(myArray), 2);
Console.WriteLine($"The Difference between minValue and maxValue is [{diff}]");
*/