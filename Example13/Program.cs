//Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
Console.Clear();
Console.WriteLine("Введите число: ");
int numbers = Convert.ToInt32(Console.ReadLine());

if (numbers > 99 && numbers < 999 )
{
    int a = numbers%10;
    Console.WriteLine($"третья цифра этого числа -> = {a}");
}
if (numbers > 999 && numbers < 9999 )
{
    int a = numbers/10%10;
    Console.WriteLine($"третья цифра этого числа -> = {a}");
}
if (numbers > 9999 && numbers < 99999 )
{
    int a = numbers/100%10;
    Console.WriteLine($"третья цифра этого числа -> = {a}");
}
if (numbers > 99999 && numbers < 999999 )
{
    int a = numbers/1000%10;
    Console.WriteLine($"третья цифра этого числа -> = {a}");
}
if (numbers > 999999 && numbers < 9999999 )
{
    int a = numbers/10000%10;
    Console.WriteLine($"третья цифра этого числа -> = {a}");
}
else
{
    Console.WriteLine("Третьей цифры нет");
}