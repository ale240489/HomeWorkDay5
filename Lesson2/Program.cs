// Задайте одномерный массив, заполненный случайными числами.
//Найдите сумму элементов, стоящих на нечетных позициях.

int [] GetMassiv(int length)
{
    int[] array = new int [length];
    Random rnd = new Random();
    for(int i = 0; i < array.Length; i++)
        array[i] = rnd.Next(-10, 10);
    return array;
}

void PrintArray (int[] array)
{
    for (int i = 0; i < array.Length; i++)
        Console.Write($"{array[i]} ");
}

int SumOfOdd(int[] array)
{
    int sumOfOdd = 0;
    for(int i = 0; i < array.Length; i++)
    {
        if(i % 2 != 0)
            sumOfOdd = sumOfOdd + array[i];
    }
    return sumOfOdd;
}


Console.WriteLine("Введите длинну массива");
int length = int.Parse(Console.ReadLine());
int[] array = GetMassiv(length);
int summOdd = SumOfOdd(array);
PrintArray(array);
Console.WriteLine();
Console.WriteLine($"Сумма чисел на нечетных позициях = {summOdd}");
