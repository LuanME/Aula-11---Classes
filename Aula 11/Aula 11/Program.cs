using Aula_11;

namespace Aula11
{
    public class Program
    {
        static void Main(string[] args)
        {
            double valor;
            Subtrair subtrai = new Subtrair(Console.ReadLine())
            public int opcao;
            public int continua = 1;    

            do
            {
                calculadora01.opcao = calculadora01.menu();
                switch (calculadora01.opcao)
                {
                    case 0:
                        calculadora01.continua = 0;
                        break;
                    case 1:

                        Console.WriteLine(calculadora01.somarValor());
                        break;
                    case 2:
                        Console.WriteLine(calculadora01.subtrairValor());
                        break;
                    case 3:

                        Console.WriteLine(calculadora01.multiplicarValor());
                        break;
                    case 4:
                        Console.WriteLine(calculadora01.dividirValor());
                        break;
                    case 5:
                        calculadora01.zerarResultado();
                        break;
                    default:
                        Console.WriteLine("Opção invalida! Por favor digite uma das opções acima.");
                        break;
                }

            } while (calculadora01.continua != 0) ;

    }

            

        }
    }

}

    
    
