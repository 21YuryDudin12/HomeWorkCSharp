//Задача 2. 
//Напишите программу, которая на вход принимает два числа 
//и выдаёт, какое число большее, а какое меньшее.

Console.WriteLine("напишите два числа, программа их сравнит");
int a = int.Parse(Console.ReadLine());
int b = int.Parse(Console.ReadLine());
if (a>b)
{
    int max = a;
    int min = b;
    Console.WriteLine("max = "+ max + " min = " + min);
}
else if (a<b)
{
    int max = b;
    int min = a;
    Console.WriteLine("max = "+ max + " min = " + min);
}
else if (a==b)
{
    Console.WriteLine("числа равны");
}

