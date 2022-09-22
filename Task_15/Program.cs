//Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
Console.Clear();
Console.Write("Введите цифру дня недели от 1 до 7: ");
int  number = Convert.ToInt32(Console.ReadLine());
if (number > 7) 
{
    Console.WriteLine("Ошибка!!! Введите цифру дня недели от 1 до 7");
}
else if (number <= 5)
{
    Console.WriteLine("Рабочий день");
}
else 
{
    Console.WriteLine("Выходной");
}