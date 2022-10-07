// Задача 13: Напишите программу, которая выводит третью цифру СЛЕВА заданного числа или сообщает, 
// что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет

Console.WriteLine("Введите случайное число ");

int num = Convert.ToInt32(Console.ReadLine());

if (num < 100)
{
Console.WriteLine($"Третья цифра слева отсутствует");
}
else
{
   while (num >= 1000) 
   {
    num = num / 10;
   }
   int result = num % 10;
   Console.WriteLine($"Третья цифра слева {result}");
}