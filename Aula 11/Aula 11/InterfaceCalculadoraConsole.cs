using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_11
{
    internal class InterfaceCalculadoraConsole
    {

        private Calculadora calculadora;

        public InterfaceCalculadoraConsole()
        {
            this.calculadora = new Calculadora();
        }

        public void Iniciar()
        {
            int opcao;
            do
            {
                opcao = Menu();
                try
                {
                    switch (opcao)
                    {
                        case 0:
                            break;
                        case 9:
                            this.calculadora.zerar();
                            break;

                        default:

                            this.calculadora.calcular(opcao.ToString(), this.LerValor());
                            Console.WriteLine(this.calculadora.Visor);
                            break;
                    }
                } catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            } while (opcao != 0);
        }

        private int Menu()
        {
            Console.WriteLine("Menu de opções da calculadora");
            Console.WriteLine();

            foreach (var operacao in this.calculadora.Operacoes)
            {
                Console.WriteLine($"{operacao.Key} - {operacao.Value.Nome}");
            }

            Console.WriteLine();
            Console.WriteLine("9 - Zerar Calculadora");
            Console.WriteLine("0 - Terminar");
            Console.WriteLine("Sua opção: ");

            return int.Parse(Console.ReadLine() + "");
        }

        private decimal LerValor()
        {
            Console.WriteLine("digite um número");

            decimal retorno = 0;
            while(!decimal.TryParse(Console.ReadLine(), out retorno))
            {
                Console.WriteLine("Você deve digitar um número");
            }

            return retorno;
        }

    }
}
