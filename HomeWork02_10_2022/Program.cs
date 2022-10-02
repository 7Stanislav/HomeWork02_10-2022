// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

/*
Console.WriteLine("Введите число А: ");
int A = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число B: ");
int B = int.Parse(Console.ReadLine());
Console.WriteLine($"Число {A} в степени {B} равно {Degree(A)}");


int Degree (int first)
{
    int degree = Convert.ToInt32(Math.Pow(A, B));
    return degree;
}
*/


//Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
//452 -> 11
//82 -> 10
//9012 -> 12

/*
Console.Write("Введите число: ");
int A = int.Parse(Console.ReadLine()!);
string arr = A.ToString();
Console.WriteLine($"Сумма цифр в числе равна {GetSum(A)}");

int GetSum(int limit)
{
    int sum = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        sum = sum + A % 10;
        A = A / 10;
    }
    return sum;
}
*/


//Задача 29: Напишите программу, которая задаёт массив из 8 рандомных элементов и выводит их на экран.

//1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]

//6, 1, 33 -> [6, 1, 33]

int[] array = GetBinaryArray(8);
Console.WriteLine($"[{String.Join(", ", array)}]");

int[] GetBinaryArray(int size)
{
    int[] result = new int[size];
    for (int i = 0; i < size; i++)
    {
        result[i] = new Random().Next();
    }
    return result;
}