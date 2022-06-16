using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_11.Operacoes
{
    public abstract class Operacao
    {
        public string Sinal { get; private set; }
        public string Nome { get; private set; }

        protected Operacao(string sinal, string nome)
        {
            this.Sinal = sinal;
            this.Nome = nome;
        }

        public abstract decimal calcular(decimal valor1, decimal valor2);
    }
}
