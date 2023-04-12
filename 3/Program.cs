/*Задача 38: Задайте массив вещественных чисел. 
Найдите разницу между максимальным и минимальным элементов массива.

[3 7 22 2 78] -> 76*/

int Length = Read("длинну массива");
int min = Read("минимальное значение");
int max = Read("максимальное значение");
double [] array = CreatArray(Length, min, max);
Print(array);

int Read(string arg)
{
    System.Console.WriteLine($"Введите {arg}: ");
    int number = int.Parse(Console.ReadLine());
    return number;
}

double [] CreatArray(int Length, int min, int max)
{
    double [] array = new double [Length];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = Math.Round(new Random().NextDouble() * 10, 2);
    }
    return array;
}

void Print(double [] array)
{
    System.Console.Write("[");
    for (int i = 0; i < array.Length-1; i++)
    {
        System.Console.Write(array[i] + "; ");
    }
    System.Console.Write(array[array.Length-1] + "]");
    double result = 0;
    double min = array[0];
    double max = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] < min) min = array[i];
        if (array[i] > max) max = array[i];
    }
    result = Math.Round((max - min), 2);
    System.Console.Write(" -> "+ "min = " + min + "; max = " + max + "; разница = " + result);
}
