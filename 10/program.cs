// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.WriteLine("Enter three-digit number: ");
int number = Math.Abs(Convert.ToInt32(Console.ReadLine()));
number= Math.Abs(number);
if (number>=100 && number<1000){
    int number1 = number/100;
    number=(number-number1*100)/10;
    Console.WriteLine($"The second digit of your number is {number} ");
}
else {
    Console.WriteLine("It is not three-digit number ");
}
