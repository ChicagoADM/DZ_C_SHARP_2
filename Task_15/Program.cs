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
//_______________________________________________________________________________________________
void Zadacha15()
{
    Console.Clear();
    Console.Write("Введите цифру дня недели от 1 до 7: ");
    int  number = Convert.ToInt32(Console.ReadLine());
    if (number > 0 && number < 8)
    {
        if (number == 6 || number == 7 )
        {
            Console.WriteLine("Выходной день");
        
        }
        else
        {
            Console.WriteLine("Рабочий день");
        }

    }
    else
    {
        Console.WriteLine("Ошибка!!! Введите цифру дня недели от 1 до 7");
    }
}
Zadacha15();
