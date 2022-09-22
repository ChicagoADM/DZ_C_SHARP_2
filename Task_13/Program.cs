// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
Console.Clear();
Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
string str = number.ToString();
if (str.Length > 2)
{
  Console.WriteLine("Третья цифра: " + str[2]);
}
else {
  Console.WriteLine("Третьей цифры нет");
} 