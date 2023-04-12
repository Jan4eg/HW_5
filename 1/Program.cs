/*Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

[345, 897, 568, 234] -> 2*/

int Length = ReadLength();
int min = Read("минимальное значение");
int max = Read("максимальное значение");
int [] array = CreatArray(Length, min, max);
Print(array);
Chet(array);

int ReadLength()
{
    System.Console.WriteLine("Введите длинну массива: ");
    while (!int.TryParse(System.Console.ReadLine(), out Length) || Length < 0)
    {
        System.Console.Write("Вы ввели некорректное значение. Введите длину массива: ");
    }
    return Length;
}

int Read(string arg)
{
    int number;
    System.Console.WriteLine($"Введите 3-х значное {arg}: ");
    while (!int.TryParse(System.Console.ReadLine(), out number) || number < 100 || number > 999 )
    {
        System.Console.Write($"Вы ввели некорректное значение. Введите 3-х значное {arg}: ");
    }
    return number;
}

int [] CreatArray(int Length, int min, int max)
{
    int [] array = new int [Length];
    for (int i = 0; i < array.Length; i++)
    {
        array [i] = new Random().Next(min, max);
    }
    return array;
}

void Print(int [] array)
{
    System.Console.Write("[");
    for (int i = 0; i < array.Length-1; i++)
    {
    System.Console.Write(array [i] + "; ");
    }
    System.Console.Write(array[array.Length-1] + "]");
}

void Chet(int [] array)
{
    int result = 0;
    for (int i = 0; i < array.Length; i++)
    {
        
        if (array [i] % 2 == 0)
        {
            result = result + 1;
        }
    }
    System.Console.Write("");
    System.Console.WriteLine(" -> " + result + " четных");
}