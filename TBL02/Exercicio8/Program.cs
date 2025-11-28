using System;
class Program()
{
    static void Main()
    {
        object obj = "123";
        string str = obj.ToString();    // Adicionar um Parse para converter em string
        int x = int.Parse(str);         // Converter o valor via parse para inteiro

    }
}
