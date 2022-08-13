// Задача 19. Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.WriteLine("Задача 19. ");
Console.Write("Введите целое положительное пятизначное число: ");
int n = Convert.ToInt32(Console.ReadLine());

int original = n;
int reversed =0;

while (n != 0)
{
    int remainder = n % 10;
    reversed = reversed * 10 + remainder;
    n /= 10;
}
if(original == reversed)
{
    Console.WriteLine($"Ваше число {original} - палиндром");
}
else
{
    Console.WriteLine($"Ваше число {original} - НЕ палиндром");
}
