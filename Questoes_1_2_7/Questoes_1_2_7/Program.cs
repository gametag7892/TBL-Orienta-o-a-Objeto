class Pessoa
{
    public string Nome;
}

class Programa
{
    static void Main()
    {

        //Questao 1


        int a = 10;

        int b = a;

        b = 50;

        Console.WriteLine($"a = {a}");
        Console.WriteLine($"b = {b}");









        // Questao 2

        Pessoa p1 = new Pessoa();

        p1.Nome = "gabriel";

        Pessoa p2 = p1;

        p2.Nome = "max";

        Console.WriteLine(p1.Nome);
        Console.WriteLine(p2.Nome);





        // Questao 7

        /* Variáveis do tipo primitivo armazenam diretamente os dados na memoria stack.
         * quando uma variável de valor é atribuida a outra, uma cópia dela é criada
         * 
         * Ja uma varíavel de referencia, armazenam um endereço de memoria para os dados
         * reais. Quando uma variável de referencia é atribuida a outra, as duas compartilham
         * o mesmo endereço na memoria
        */

        //Ex variavel do tipo primitivo

        int num1 = 20;
        int num2 = num1;

        num2 = 100;
        // Aqui a variavel "num2" está copiando a "num1" e depois alterando o seu valor
        // nesse caso a variável num1 mantem seu valor original e não é modificada, ou seja
        // é independente.


        //Ex variavel do tipo referencia

        Pessoa pessoa1 = new Pessoa();
        Pessoa pessoa2 = pessoa1;
        pessoa1.Nome = "Yasushi";

        pessoa2.Nome = "Superdupermegablaster";

        // Nesse exemplo, como a "pessoa2" está copiando a "pessoa1" e são variaveis de
        // referencia, ao alterar o nome da "pessoa2", isso também altera o nome da pessoa1



    }
}