using System;

namespace Aula22_02
{
    class Program
    {
        static void Main(string[] args)
        {
            operacao op = new operacao(); 
            double soma, multiplicacao, divisao, subtracao;
            Console.WriteLine("Digite o primeiro numero a ser calculado");

            Console.WriteLine("Digite o primeiro numero a ser calculado");
            op.n1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digite o segundo numero a ser calculado");
            op.n2 = Convert.ToDouble(Console.ReadLine());

            soma = op.n1 + op.n2;
            subtracao = op.n1 - op.n2;
            divisao = op.n1 / op.n2;
            multiplicacao = op.n1 * op.n2;

            Console.WriteLine("Soma = "+ soma);
            Console.WriteLine("Subtração = " + subtracao);
            Console.WriteLine("Multiplicação = " + multiplicacao);
            Console.WriteLine("Divisão = " + string.Format("{0:0.00}",divisao));

        }
    }
}
