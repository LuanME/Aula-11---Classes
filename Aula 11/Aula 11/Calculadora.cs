
using Aula_11.Operacoes;

namespace Aula_11
{
    public class Calculadora
    {
        public Dictionary<string, Operacao> Operacoes { get; private set; }

        public decimal Visor { get; private set; }

        public Calculadora()
        {
            Operacao soma = new Soma();
            Operacao subtracao = new Subtracao();
            Operacao multiplicacao = new Multiplicacao();
            Operacao divisao = new Divisao();

            this.Operacoes = new Dictionary<string, Operacao>();

            this.Operacoes.Add("1", soma);
            this.Operacoes.Add("2", subtracao);
            this.Operacoes.Add("3", multiplicacao);
            this.Operacoes.Add("4", divisao);

            this.zerar();
        }

        public void zerar()
        {
            this.Visor = 0;
        }

        public void calcular(string operacao, decimal valor)
        {
            if (!this.Operacoes.ContainsKey(operacao))
            {
                throw new Exception("Operacao Nao Encontrada");
            }

            this.Visor = this.Operacoes[operacao].calcular(this.Visor, valor);
        }

    }
}
