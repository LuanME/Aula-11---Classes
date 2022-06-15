using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_11
{
    internal class Soma
    {
        public double somarValor()
        {
            double valor;
            double resultadoFuncao;
            Console.WriteLine("Você digitou 1 - Somar");
            Console.WriteLine("Qual valor deseja Somar");
            try
            {
                valor = double.Parse(Console.ReadLine());
                resultadoFuncao = resultado + valor;
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
