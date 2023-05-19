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