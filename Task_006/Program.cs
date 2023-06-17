// Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка)

Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

int proverka = number % 2;

if(proverka == 0)
{
    Console.WriteLine("Число чётное");
}
else
{
    Console.WriteLine("Число нечетное");
}
