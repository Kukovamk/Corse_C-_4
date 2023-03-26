//  Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

Console.WriteLine("Введите число: ");
int a = int.Parse(Console.ReadLine()!);

int[] array = new int[a];
for (int i = 0; i < a; i++)
{
    array[i] = new Random().Next(a + 1);
    Console.Write(array[i] + ";");
}
Console.WriteLine();