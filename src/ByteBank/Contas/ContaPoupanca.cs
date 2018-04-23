using System;
using System.Collections.Generic;
using System.Text;

namespace ByteBank.Contas
{
    public class ContaPoupanca : Conta
    {
        public DateTime DataVencimento { get; private set; }

        public ContaPoupanca(int agencia, int numero, DateTime dataVencimento)
            : base(agencia, numero)
        {
            DataVencimento = dataVencimento;
        }
    }
}
