// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
Console.Clear();
Console.WriteLine("Введите трехзначное число: ");
int numbers = Convert.ToInt32(Console.ReadLine());
int a = numbers/10%10;
if (numbers > 100 && numbers < 999 )
{
    Console.WriteLine($"вторая цифра этого числа -> = {a}");
}
else
{
    Console.WriteLine("Вы ввели не трехначное число");
}
