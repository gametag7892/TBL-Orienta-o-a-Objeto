// 4.
class Program()
{
    static void Main(string[] args)
    {
        string valor = Console.ReadLine();

        int numero = int.TryParse(valor, out int resultado) ? resultado : -1;

        Console.WriteLine(numero);



        // 5.  Explique por que s1 == s2 é true.
        // R: A expressão compara o conteúdo das strings, e ambas contêm o mesmo valor.
        // Explique por que object.ReferenceEquals(s1, s3) pode ser false
        // R: Porque essa expressão verifica se ambas as variáveis apontam para o mesmo objeto na memória, mesmo que tenha o mesmo conteúdo que s1, dá falso pois s1, s2 e s3 são instancias diferentes na memória.

        // 6. Explique por que numeros1[0] foi alterado.
        // R: Atribuir numeros1 a numeros2 faz com que ambas as variáveis apontem para o mesmo array na memória. Portanto, modificar numeros2 também afeta numeros1.
        // Como evitar que numeros1 seja modificado ao alterar numeros2?
        // R: Para evitar isso, você pode criar uma cópia do array original usando o método Array.Copy


        // 9. A saída do código será: 99
    }


}
