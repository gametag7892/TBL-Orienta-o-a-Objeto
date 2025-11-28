using System;

class Program()
{
    static void Main()
    {
        Console.Write("Escreva um número:");            // Texto do input que pede um número
        double num = double.Parse(Console.ReadLine());  // Converte o input para double

        Console.WriteLine($"Antes: {num}");             // Mostra o número antes da conversão

        num = (int)num;
        num = Math.Truncate(num);

        Console.WriteLine($"Depois: {num}");             // Mostra o número antes da conversão

    }
}