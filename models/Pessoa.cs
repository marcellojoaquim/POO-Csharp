//Abstraçao para criação dos objetos em POO.
using System;
namespace orientacaoObjeto.models
{
    public class Pessoa
    {
        public string Nome {get; set;}
        public int Idade {get; set;}

        public virtual void Apresentar()
        {
            Console.WriteLine($"Olá meu nome é {Nome} e tenho {Idade} anos");
        }
    }
}