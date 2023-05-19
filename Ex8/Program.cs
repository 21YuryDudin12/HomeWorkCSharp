//Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

int n = int.Parse(Console.ReadLine());
int i = 0;
while (i<=n)
{
    int f = i;
    if (f % 2 == 0)
    {
        Console.WriteLine(f);
    }
    i++;
}