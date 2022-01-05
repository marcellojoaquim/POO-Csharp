// classe filha que herda os atributos da classe pai Pessoa.
using System;
namespace orientacaoObjeto.models
{
    public class Aluno : Pessoa
    {
        public int Nota {get; set;}

        public override void Apresentar()
        {
            Console.WriteLine($"Olá meu nome é {Nome} e minha nota é {Nota}");
        }
    }
}