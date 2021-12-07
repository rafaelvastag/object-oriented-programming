using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulamento
{
    public class Pessoa
    {
        private string nome;
        private string genero;
        private int idade;

        public string Nome { get; }

        public Pessoa(string nome)
        {
            this.Nome = nome;
        }

        public string Genero
        {
            set
            {
                genero = value;
                System.Console.WriteLine(genero);
            }
        }

        public int Idade
        {
            set
            {
                if (value < 18)
                {
                    System.Console.WriteLine("Necessário ser maior de 18 anos");
                }
                else
                {
                    this.idade = value;
                }
            }

            get
            {
                return idade;
            }
        }
    }
}
