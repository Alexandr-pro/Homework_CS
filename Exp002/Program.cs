// Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

Console.Write("Введите первое число A: ");
int A = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число B: ");
int B = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите третье число C: ");
int C = Convert.ToInt32(Console.ReadLine());

 int Maximal = Math.Max(Math.Max(A, B), C);
        int Minimal = Math.Min(Math.Min(A, B), C);
 
        Console.WriteLine("{0} -> {1} -> {2}",
            Minimal,
            A + B + C - Maximal - Minimal,
            Maximal);

Console.WriteLine( " Максимальное число {0}  " , Maximal);