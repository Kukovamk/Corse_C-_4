﻿//  Напишите цикл, который принимает на вход два числа (A и B)
// и возводит число A в натуральную степень B.

void Degree(int a, int b)
{
    int result = 1;
    for (int i = 1; i <= b; i++)
    {
        result = result * a;
    }
    Console.WriteLine(result);
}
int a = int.Parse(Console.ReadLine()!);
int b = int.Parse(Console.ReadLine()!);
Degree(a, b);
