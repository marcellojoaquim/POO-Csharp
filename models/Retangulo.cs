//aplicação do Encapsulamento.

namespace orientacaoObjeto.models
{
    public class Retangulo
    {
        private double Comprimento;
        private double Altura;
        private bool valido;

        public void receberValores(double Comprimento, double Altura)
        {
            if(Comprimento > 0 && Altura >0)
            {
            this.Comprimento = Comprimento;
            this.Altura = Altura;
            valido = true;
            }
            else
            {
                System.Console.WriteLine("Valores Inválidos");
            }
        }

        public double obterArea()
        {
            if(valido)
            {
            return Comprimento * Altura;
            }
            else
            {
                System.Console.WriteLine("Preencha valores válidos");
                return 0;
            }
        }
    }
}