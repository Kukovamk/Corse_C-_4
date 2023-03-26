//  Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

int SumNum(int a)
{
    int i = 0;
    while (a > 0)
    {
        a /= 10;
        i++;
    }    

   return i;    
}
void SumNumbers(int n, int len)
{
    int sum = 0;
    for (int i = 1; i <= len; i++)
    {
        sum += n % 10;
        n /= 10;
    }
    Console.WriteLine(sum);
}

int a = int.Parse(Console.ReadLine()!);
int n = int.Parse(Console.ReadLine()!);
int len = SumNum(a);
SumNumbers(n, len);
