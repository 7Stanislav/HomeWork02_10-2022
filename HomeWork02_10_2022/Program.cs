// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

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
