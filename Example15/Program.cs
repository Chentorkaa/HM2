// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
Console.Clear();
Console.WriteLine("Введите цифру: ");
int a = int.Parse(Console.ReadLine());

if (a%6 == 0 | a%7 == 0)
{
   
    Console.WriteLine("Этот день является выходным");
}

else
{
    Console.WriteLine("Этот день не является выходным");
}
