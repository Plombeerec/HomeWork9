// Задайте значения M и N. Напишите программу, которая найдёт сумму
// натуральных элементов в промежутке от M до N.


int SumOfDigits(int m, int n)
{
    if(m < n) return n+SumOfDigits(m, n-1);
    else return m;
}

int MinNum = Convert.ToInt32(Console.ReadLine());
int MaxNum = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(SumOfDigits(MinNum, MaxNum));