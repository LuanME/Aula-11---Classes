using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_11
{
    internal class Subtrair : Calculadora
    {

        public Subtrair(double valor, double resultado) : base(valor, resultado)
        {

        }


        public double subtrairValor()
        {
            double valor;
            double resultadoFuncao;
            Console.WriteLine("Você digitou 2 - Subtrair");
            Console.WriteLine("Qual valor deseja Subtrair?");
            try
            {
                valor = double.Parse(Console.ReadLine());
                resultadoFuncao = Resultado - valor;
                //definirResultadoDaUltimaOperacaoMatematica(resultadoFuncao);
            }
            catch (FormatException ex)
            {
                Console.WriteLine("Você deve digitar um número -> " + ex.Message);
            }




            return pegarResultadoDaUltimaOperacaoMatematica();
        }
    }
}
