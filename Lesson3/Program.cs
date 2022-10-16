// Задайте массив вещественных чисел. Найдите разницу между макс и мин элементов массива.
//[3 7 22 2 78] -> 76
double[] GetArray(int length)
{
    Random rnd = new Random();
    double [] array = new double[length];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = Math.Round((rnd.NextDouble()*(10-2)+2),2);
    }
    return array;
}

void PrintArray(double[] array)
{
    for(int i = 0; i < array.Length; i++)
        Console.Write($"{array[i]} ");
}

double DifferenceMaxMin(double[] array)
{
    double max = array[0];
    double min = array[0];
    for(int i = 0; i < array.Length; i++)
    {
        if(array[i] > max)
            max = array[i];
        if(array[i] < min)
            min = array[i];
    }
    double difference = Math.Round((max-min),2);
    return difference;
}

Console.WriteLine("Введите длинну массива");
int length = int.Parse(Console.ReadLine());
double[] array = GetArray(length);
PrintArray(array);
double diffOfMaxMin = DifferenceMaxMin(array);
Console.WriteLine();
Console.Write($"Разница между макc и мин значениями в массиве = {diffOfMaxMin}");

