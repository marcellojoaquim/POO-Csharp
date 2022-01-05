using orientacaoObjeto.Interfaces;
namespace orientacaoObjeto.models
{
    public class Calculadora : ICalculadora
    {
        public int Soma(int num1, int num2)
        {
            return num1 + num2;
        }
        public int Soma(int num1, int num2, int num3)
        {
            return num1 + num2 + num3;
        }
        public int Dividir(int num1, int num2)
        {
            return num1 / num2;
        }
        public int Multiplicar(int num1, int num2)
        {
            return num1 * num2;
        }
        public int Subtrair(int num1, int num2)
        {
            return num1 - num2;
        }
    }
}