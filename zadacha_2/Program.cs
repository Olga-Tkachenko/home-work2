// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей
// цифры нет. Например: 645 - 5; 32679 - 6; 78 - третьей цифры нет.
Console.WriteLine("Введите число");
string? numberString = Console.ReadLine();
int number = int.Parse(numberString!);

if(number>99 && number<1000)
{
    Console.WriteLine(number%10);
}
if(number>999 && number<10000)
{
    Console.WriteLine((number/10)%10);
}
if(number>9999 && number<100000)
{
    Console.WriteLine((number/100)%10);
}

if(number<=99)
{
    Console.WriteLine("третьей цифры нет");
}
