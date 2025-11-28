using System;
class Pessoa
{
    public string Nome;
}
class Program
{
    static void Main()
    {
        Pessoa p1 = new Pessoa();

        p1.Nome = "gabriel";

        Pessoa p2 = p1;

        p2.Nome = "max";

        Console.WriteLine(p1.Nome);
        Console.WriteLine(p2.Nome);
    }
}