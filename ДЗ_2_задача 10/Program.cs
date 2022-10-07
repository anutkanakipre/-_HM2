// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает 
// вторую цифру этого числа.
// 456 -> 5
// 782 -> 8

/**Console.WriteLine("Введите трехзначное число ");
int num = Convert.ToInt32(Console.ReadLine());

int num1 = num/100;
int num3 = num/10;
int result =  (num3 - num1*10); //делим на 10, потому что в одной сотке 10ть десятков.

Console.WriteLine ($"Num1 {num1}");
Console.WriteLine ($"Num3 {num3}");
Console.WriteLine ($"result {result}");**/

Console.WriteLine("Введите трехзначное число ");
int num = Convert.ToInt32(Console.ReadLine());

int num1 = (num/100);
int num3 = (num % 10);
int result =  (num - num1*100 - num3)/10;
Console.WriteLine($"Первое число {num1} ");
Console.WriteLine($"Третье число {num3} ");
Console.WriteLine($"Второе число {result} ");