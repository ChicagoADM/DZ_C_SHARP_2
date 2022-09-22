// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
Console.Clear();
Console.Write("Введите трёхзначное число: ");
int number = Convert.ToInt32(Console.ReadLine());
string str = number.ToString();
Console.WriteLine($"Второе число: {str[1]}");