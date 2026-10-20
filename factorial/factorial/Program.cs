using System;
class Program
{
    static long Factorial(int n)
    {
        if (n == 0)
            return 1;
        return n * Factorial(n - 1);
    }
    static void Main()
    {
        Console.WriteLine("Ingrese un numero");
        int n = int.Parse(Console.ReadLine());
        if (n < 0 || n > 20)
        {
            Console.WriteLine("El numero debe ser entre 0 y 20");
            return;
        }
        Console.WriteLine("El factorial es:" + Factorial(n));

    }

}
