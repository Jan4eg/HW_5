/*Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

[3, 7, 23, 12] -> 19

[-4, -6, 89, 6] -> 0*/

int Length = Read("длинну массива");
int min = Read("минимальное значение");
int max = Read("максимальное значение");
int [] array = CreatArray(Length, min, max);
Print(array);

int Read(string arg)
{
    int number;
    System.Console.WriteLine($"Введите {arg}: ");
    while (!int.TryParse(Console.ReadLine(), out number))
    {
        System.Console.WriteLine($"Вы ввели некорректное значение. Введите {arg}: ");
    }
    return number;
}

int [] CreatArray(int Length, int min, int max)
{
    int [] array = new int [Length];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(min, max);
    }
    return array;
}

void Print(int [] array)
{
    System.Console.Write("[");
    for (int i = 0; i < array.Length-1; i++)
    {
        System.Console.Write(array[i] + "; ");
    }
    System.Console.Write(array[array.Length-1] + "]");
    int result = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (i % 2 != 0)
        {
            result += array[i];
        }
    }
    System.Console.Write(" -> сумма элементов на нечетных позициях " + result);
}

