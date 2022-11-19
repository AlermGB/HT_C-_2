
// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет


Console.WriteLine("Enter day number in Russia: ");
int firstHD = 6;
int secondHD = 7;
int number = Convert.ToInt32(Console.ReadLine());
if (number > 0 && number < 8)
{
    if (number == firstHD || number == secondHD)
    {
        Console.WriteLine("Yes ");
    }
    else
    {
        Console.WriteLine("No ");
    }
}
else
{
    Console.WriteLine("This day doesn't exist ");
}
