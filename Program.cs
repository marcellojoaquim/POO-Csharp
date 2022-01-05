// Método principal para instanciar as classes e objetos.

using System;
using orientacaoObjeto.Interfaces;
using orientacaoObjeto.models;

    namespace orientacaoObjeto
    {
        class program
        {
            static void Main(string[] args)
            {
                ICalculadora calc2 = new Calculadora();

                Corrente c = new Corrente();

                Calculadora calc = new Calculadora();

                Aluno a = new Aluno();
                Professor prof = new Professor();

                Pessoa p1 = new Pessoa();
                Animal pet1 = new Animal();

                Retangulo r = new Retangulo();
                Retangulo r2 = new Retangulo();

                //valores válidos.
                r.receberValores(30, 10);
                System.Console.WriteLine($"Area: {r.obterArea()}");

                //valores inválidos.
                r2.receberValores(0, 3);
                System.Console.WriteLine($"Area: {r2.obterArea()}");


                p1.Nome = "Marcello";
                p1.Idade = 6;

                pet1.nomeAnimal = "Negão";
                pet1.idadeAnimal = 3;
                pet1.Raca = "Cachorro";

                p1.Apresentar();
                pet1.ApresentarPET();


                a.Nome = "Joaquim";
                a.Idade = 30;
                a.Nota = 10;

                a.Apresentar();

                prof.Nome = "Silva";
                prof.Idade = 40;
                prof.Salario = 3500;

                prof.Apresentar();

                Console.WriteLine("Resultado da primeira adição " + calc.Soma(10, 11));
                Console.WriteLine("Resultado da segunda adição " + calc.Soma(10, 11, 12));

                c.Creditar(150);
                c.ExibirSaldo();

                System.Console.WriteLine(calc2.Dividir(110, 2));

            }
        }
    }

