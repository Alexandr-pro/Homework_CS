// Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

Console.Write("Введите первое число NumA: ");
int NumA = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число NumB: ");
int NumB = Convert.ToInt32(Console.ReadLine());

if (NumA > NumB) 
 {
    Console.WriteLine(NumA +  " Больше чем "  + NumB);
 }

else 
{
    Console.WriteLine(NumB +  " Больше чем "  + NumA);
}
