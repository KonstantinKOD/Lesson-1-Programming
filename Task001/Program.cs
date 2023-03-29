// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

int a = 0, b = 0;

Console.WriteLine("Enter a and b: ");

if (int.TryParse(Console.ReadLine(), out a) && int.TryParse(Console.ReadLine(), out b))
{
    if (a < b)
    {
        int max = b;
        int min = a;
        Console.Write("max ");
        Console.WriteLine(max);
        Console.Write("min ");
        Console.WriteLine(min);


    }
    else
    {
        int max = a;
        int min = b;
        Console.Write("max ");
        Console.WriteLine(max);
        Console.Write("min ");
        Console.WriteLine(min);
        
    }
}
else
{
    Console.WriteLine("it doesn't work that way");
}