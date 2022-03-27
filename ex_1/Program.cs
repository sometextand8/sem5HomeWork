// Задача 1: Задайте массив заполненный случайными положительными трёхзначными числами. 
//Напишите программу, которая покажет количество чётных чисел в массиве.


void FillArray(int[] collection)
{
    int len = collection.Length;
    for (int i = 0; i < len; i++)
    {
        collection[i] = new Random().Next(101, 1000);
    }
}

void PrintArray(int[] collection)
{
    int len = collection.Length;
    
    for (int i = 0; i < len; i++)
    {
        Console.Write(collection[i] + " ");
    }
}

int EvenMean(int[] collection)
{
    int len = collection.Length;
    int count = 0;

    for (int i = 0; i < len; i++)
    {
        if (collection[i] % 2 == 0)
        {
            count++;
        }
    }
    return count;
}

int[] array = new int[20];


FillArray(array);
PrintArray(array);
Console.WriteLine();
Console.WriteLine($"{EvenMean(array)} - чётных чисел в массиве.");

