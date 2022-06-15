using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_11
{
    internal class Mutiplicar : Calculadora
    {
        public double multiplicarValor()
        {
            double valor;
            double resultadoFuncao;
            Console.WriteLine("Você digitou 3 - Multiplicar");
            Console.WriteLine("Qual valor deseja Multiplicar?");
            try
            {
                valor = double.Parse(Console.ReadLine());
                resultadoFuncao = resultado * valor;
                definirResultadoDaUltimaOperacaoMatematica(resultadoFuncao);
            }

            catch (FormatException ex)
            {
                Console.WriteLine("Você deve digitar um número -> " + ex.Message);
            }

            return pegarResultadoDaUltimaOperacaoMatematica();
        }
    }
}
