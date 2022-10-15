// Задайте массив вещественных чисел. Найдите разницу между макс и мин элементов массива.
//[3 7 22 2 78] -> 76
int[] GetArray(int length)
{
    Random rnd = new Random();
    int [] array = new int[length];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.Next(1,30);
    }
    return array;
}

void PrintArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
        Console.Write($"{array[i]} ");
}

int DifferenceMaxMin(int[] array)
{
    int max = array[0];
    int min = array[0];
    for(int i = 0; i < array.Length; i++)
    {
        if(array[i] > max)
            max = array[i];
        if(array[i] < min)
            min = array[i];
    }
    int difference = max-min;
    return difference;
}

Console.WriteLine("Введите длинну массива");
int length = int.Parse(Console.ReadLine());
int[] array = GetArray(length);
PrintArray(array);
int diffOfMaxMin = DifferenceMaxMin(array);
Console.WriteLine();
Console.Write($"Разница между макc и мин значениями в массиве = {diffOfMaxMin}");

