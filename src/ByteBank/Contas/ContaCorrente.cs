using System;
using System.Collections.Generic;
using System.Text;

namespace ByteBank.Contas
{
    public class ContaCorrente : Conta
    {
        public ContaCorrente(int numero, int numeroAgencia)
            : base(numero, numeroAgencia)
        {
        }

        public override bool Sacar(double valor)
        {
            double valorComTaxa = valor + 0.25;
            return base.Sacar(valorComTaxa);
        }
    }
}
