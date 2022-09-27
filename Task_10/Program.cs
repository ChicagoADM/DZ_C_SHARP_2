// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
Console.Clear();
Console.Write("Введите трёхзначное число: ");
int number = Convert.ToInt32(Console.ReadLine());
string str = number.ToString();
Console.WriteLine($"Второе число: {str[1]}");

//_________________________________________________________________________
void Zadacha10()
{// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
Console.Clear();
Console.Write("Введите трёхзначное число: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number > 99 && number < 1000)
{
    Console.WriteLine("Вторая цифра числа: " + (number/10%10));
}
else
{
    Console.WriteLine("Введено не трёхзначное число");
}

}
Zadacha10();
