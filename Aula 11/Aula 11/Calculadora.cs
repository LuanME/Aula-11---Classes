
namespace Aula_11
{
    public class Calculadora
    {
        public double Valor { get; private set; }
        public double Resultado { get; private set; }

        public Calculadora(double valor, double resultado)
        {
            this.Valor = valor;
            this.Resultado = resultado;
        }


        public int menu()
        {
            int op;
            Console.WriteLine("Menu de opções da calculadora");
            Console.WriteLine("1 - Somar");
            Console.WriteLine("2 - Subtrair");
            Console.WriteLine("3 - Multiplicar");
            Console.WriteLine("4 - Dividir");
            Console.WriteLine("5 - Zerar Calculadora");
            Console.WriteLine("0 - Terminar");
            Console.WriteLine("Sua opção: ");
            op = int.Parse(Console.ReadLine());

            return op;
        }

       

        public void zerarResultado()
        {
            this.Resultado = 0;
        }



    }
}
