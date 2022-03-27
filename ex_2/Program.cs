//Задача 2: Задайте одномерный массив, заполненный случайными числами.
//Найдите сумму элементов, стоящих на нечётных позициях.

void FillArray(int[] collection)
{
    int len = collection.Length;
    
    for (int i = 0; i < len; i++)
    {
        collection[i] = new Random().Next(1, 31);
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

int SumOfElements(int[] collection)
{
    int len = collection.Length;
    int sum = 0;
    int pos = 1;

    for (int i = 1; i < len; i++)
    {
        pos++;
        if (pos%2 == 0)
        {
            sum += collection[i];
        }
    }
    return sum;
}

int[] array = new int[10];

FillArray(array);
PrintArray(array);
Console.WriteLine();
Console.Write($"{SumOfElements(array)} - сумму элементов, стоящих на нечётных позициях.");