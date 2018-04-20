using System;
using System.Collections.Generic;
using System.Text;

namespace ByteBank.Contas
{
    public abstract class Conta
    {
        public Cliente Titular { get; set; }
        public int Numero { get; private set; }
        public int NumeroAgencia { get; private set; }
        public double Saldo { get; set; }

        public Conta(int numero, int numeroAgencia)
        {
            Numero = numero;
            NumeroAgencia = numeroAgencia;
        }
    }
}
