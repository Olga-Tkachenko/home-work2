// Напишите программу, которая принимает на вход цифру, обозначающую день недели и проверяет,
// является ли этот день выходным. Например: 6 - да; 7 - да; 1 - нет.
Console.WriteLine("Введите цифру обозначающую день недели");
string? numberString = Console.ReadLine();
int number = int.Parse(numberString!);
if (number>0 && number<6)
{
    Console.WriteLine("нет");
}
else
if(number==6)
{
    Console.WriteLine("да");
}
else
if(number==7)
{
    Console.WriteLine("да");
}
else
if(number>7)
{
    Console.WriteLine("Неверно введена цифра обозначающая день недели");
}
