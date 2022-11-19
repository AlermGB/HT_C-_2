// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

// 645 -> 5

// 78 -> третьей цифры нет

// 32679 -> 6


Console.WriteLine("Enter your number: ");
int number = Convert.ToInt32(Console.ReadLine());
number = Math.Abs(number);
int number1 = number;
if (number >= 100)
{
    int counter = 2;
    number = number / 100;
    while (number > 0)
    {
        number = number / 10;
        counter++;
    }
    int digitNumber = 3;
    counter = counter - digitNumber;
    while (counter > 0)
    {
        number1 = number1 / 10;
        counter--;
    }
    int thirdDigit = number1 % 10;
    Console.WriteLine($"The third digit of your number is {thirdDigit} ");
}
else
{
    Console.WriteLine("The third digit doesn't exist ");
}
