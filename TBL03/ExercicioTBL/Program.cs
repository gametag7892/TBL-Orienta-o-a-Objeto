using Bogus;
using System;
using System.Collections.Generic;

namespace ExercicioTBL
{
    class Program
    {
        static void Main()
        {
            var clientes = FakeDataClientes.ListaClientesFake();

            foreach (var cli in clientes)
            {
                Console.WriteLine(cli.Nome);
                Console.WriteLine(cli.Email);
                Console.WriteLine(cli.Ativo);
            }
            Console.ReadLine();
        }
    }
    public static class FakeDataClientes
    {
        public static List<Usuario> ListaClientesFake()
        {
            var clienteFaker = new Faker<Usuario>("pt_BR")
                .RuleFor(c => c.Id, f => f.IndexFaker)
                .RuleFor(c => c.Nome, f => f.Name.FullName(Bogus.DataSets.Name.Gender.Female))
                .RuleFor(c => c.Email, f => f.Internet.Email(f.Person.FirstName).ToLower())
                .RuleFor(c => c.DataRegistro, f => f.Date.Recent(100))
                .RuleFor(c => c.Ativo, f => f.PickRandomParam(new bool[] { true, true, false }));

            var clientes = clienteFaker.Generate(10);
            return clientes;
        }
    }


    public class Usuario
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public DateTime DataRegistro { get; set; }
        public bool Ativo { get; set; }
    }
}
