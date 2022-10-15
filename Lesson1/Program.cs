// Задайте массив заполненный случайными положительными трехзначными числами.
//Напишите программу, которая покажет количество четных чисел в массиве.
//[345,897,568,234]->2

int [] GetMassiv (int length)
{
    int[] array = new int[length];
    Random rnd = new Random();
    for(int i = 0; i < array.Length; i++)
        array[i] = rnd.Next(100, 1000);
    return array;
}

void PrintArray (int[] array)
{
    for(int i =0; i<array.Length; i++)
        Console.Write($"{array[i]} ");
}

int EvenNumbers (int[] array)
{
    int numbersEvent = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if(array[i] % 2 == 0)
            numbersEvent += 1;
    }
    return numbersEvent;
}



Console.WriteLine("Введите длинну массива");
int length = int.Parse(Console.ReadLine());
int [] array = GetMassiv(length);
int events = EvenNumbers(array);
PrintArray(array);
Console.WriteLine();
Console.WriteLine($"Количество четных чисел = {events}");
