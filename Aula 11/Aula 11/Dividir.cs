using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_11
{
    internal class Dividir
    {
        public double dividirValor()
        {

            double valor;
            double resultadoFuncao;
            Console.WriteLine("Você digitou 4 - Dividir");
            Console.WriteLine("Qual valor deseja Dividir?");
            try
            {
                valor = double.Parse(Console.ReadLine());
                try
                {
                    dividePorZero(valor);
                    resultadoFuncao = resultado / valor;
                    definirResultadoDaUltimaOperacaoMatematica(resultadoFuncao);
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Não pode dividir por zero");

                }
            }
            catch (FormatException ex)
            {
                Console.WriteLine("Você deve digitar um número -> " + ex.Message);
            }

            catch (Exception ex)
            {
                Console.WriteLine("Não pode dividir por zero");

            }
            return pegarResultadoDaUltimaOperacaoMatematica();
        }

    }
}
