using System;
using System.Collections.Generic;
using System.Text;

namespace ByteBank.Contas
{
    public class ContaCorrente : Conta
    {
        public double Saldo { get; set; }

        public ContaCorrente(int numero, int numeroAgencia)
            : base(numero, numeroAgencia)
        {
        }
    }
}
