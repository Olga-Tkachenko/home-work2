// Напишите программу, которая принимает на вход трехзначное число и на выходе показывает вторую цифру 
//этого числа. Например: 456 - 5; 782- 8; 918 - 1.
Console.WriteLine("Введите трехзначное число");
string? numberString = Console.ReadLine();
int number = int.Parse(numberString!);
if (number<0)
{
    number=number*(-1);
}
while(number>100)
{
    number=number/10;
} 
int result = number%10;
{
    Console.WriteLine(result);
}
