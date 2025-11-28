using System;

class Program()
{
    static void Main(string[] args)
    {
        string valor = Console.ReadLine();

        int numero = int.TryParse(valor, out int resultado) ? resultado : -1;

        Console.WriteLine(numero);
    }
}