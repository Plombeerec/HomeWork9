//Задача 64: Задайте значение N.
 //Напишите программу, которая найдет кол-во цифр в числе N рекурсивным методом.


int FindNumbersOfDigit(int n)
 {
    if( n < 10 ) return 1;
    else
    return 1 + FindNumbersOfDigit(n/10);
 }
int number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(FindNumbersOfDigit(number));
