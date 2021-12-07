using System;

namespace Encapsulamento
{
    class Program
    {
        static void Main(string[] args)
        {
            Pessoa p = new Pessoa("Rafael");
            p.Genero = "masculino";
            p.Idade = 19;

            Console.WriteLine(p.Nome);
            Console.WriteLine(p.Idade);
        }
    }
}
