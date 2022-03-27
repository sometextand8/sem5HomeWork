// Задача 3: Задайте массив вещественных чисел.
// Найдите разницу между максимальным и минимальным элементов массива.

double RndForArray()
{
    Random rnd = new Random();
    double digit = Convert.ToDouble(rnd.Next(100) / 10.0);

    return digit;
}

void FillArray(double[] collection)


{
    int len = collection.Length;

    for (int i = 0; i < len; i++)
    {
        collection[i] = RndForArray();
    }
}

void PrintArray(double[] collection)
{
    int len = collection.Length;

    for (int i = 0; i < len; i++)
    {
        Console.Write(collection[i] + " => ");
    }
}

double MinOfElem(double[] collection)
{
    double min = collection[0];

    for (int i = 0; i < collection.Length; i++)
    {
        if (min > collection[i]) min = collection[i];
    }
    return min;
}

double MaxOfElem(double[] collection)
{
    double max = collection[0];

    for (int i = 0; i < collection.Length; i++)
    {
        if (max < collection[i]) max = collection[i];
    }
    return max;
}

double[] array = new double[5];


FillArray(array);
PrintArray(array);
Console.WriteLine();
Console.WriteLine($"Min element is - {MinOfElem(array)} and Max element is - {MaxOfElem(array)}.");





