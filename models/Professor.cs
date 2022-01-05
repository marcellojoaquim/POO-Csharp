// Classe filha que herda os atributos da classe pai Pessoa.

using System;
namespace orientacaoObjeto.models
{
    public class Professor : Pessoa
    {
        public double Salario{get; set;}

        public override void Apresentar()
        {
            Console.WriteLine($"Olá meu nome é {Nome} e meu salário é {Salario}");
        }
    }
}