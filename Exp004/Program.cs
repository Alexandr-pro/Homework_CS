// Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.


Console.Write("Введите число");
int n = Convert.ToInt32(Console.ReadLine());
int i = n;
if (n == 0)
{
  Console.Write("вы ввели ноль");
}
 
 if (n > 0)
{
        while (i > 1)
    {
        Console.Write($"{n - i + 2} ");
        i = i - 2;
    }
}

else
{
    while (i < -1)
    {
        Console.Write($"{n + (-i - 2)} ");
        i = i + 2;
    }
}



