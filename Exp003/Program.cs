// Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

Console.Clear();
Console.Write("Введите число : ");
int n = Convert.ToInt32(Console.ReadLine());

if  ( n % 2 == 0)
{
    Console.WriteLine("{0} Число чётное" , n);
}
else 
{
    Console.WriteLine("{0} Число нечётное" , n);
}


