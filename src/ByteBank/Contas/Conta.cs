using System;
using System.Collections.Generic;
using System.Text;

namespace ByteBank.Contas
{
    public abstract class Conta
    {
        public static int TotalDeContasCriadas { get; private set; }

        private int _agencia;
        private double _saldo = 100;

        public Cliente Titular { get; set; }
        public int Agencia
        {
            get
            {
                return _agencia;
            }
            set
            {
                if (value <= 0)
                {
                    return;
                }

                _agencia = value;
            }
        }
        public int Numero { get; set; }
        public double Saldo
        {
            get
            {
                return _saldo;
            }
            private set
            {
                if (value < 0)
                {
                    return;
                }

                _saldo = value;
            }
        }

        public Conta(int agencia, int numero)
        {
            Agencia = agencia;
            Numero = numero;

            TotalDeContasCriadas++;
        }

        public virtual bool Sacar(double valor)
        {
            if (_saldo < valor)
            {
                return false;
            }

            _saldo -= valor;
            return true;
        }
        public virtual void Depositar(double valor)
        {
            _saldo += valor;
        }
        public virtual bool Transferir(double valor, Conta contaDestino)
            {
                if (_saldo < valor)
                {
                    return false;
                }

                _saldo -= valor;
                contaDestino.Depositar(valor);
                return true;
            }
    }
}
